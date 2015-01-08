// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Collections;
using Alachisoft.NCache.Common.Net;

using Alachisoft.NGroups.Stack;

namespace Alachisoft.NGroups
{
	/// <summary>
	/// Abstract class for any implementation of a channel
	/// <p><b>Author:</b> Chris Koiak, Bela Ban</p>
	/// <p><b>Date:</b>  12/03/2003</p>
	/// </summary>
	public abstract class Channel : Transport 
	{
		public const int BLOCK = 0;
		public const int SUSPECT = 2;
		public const int LOCAL = 3;
		public const int GET_STATE_EVENTS = 4;
		public const int AUTO_RECONNECT = 5;
		public const int AUTO_GETSTATE = 6;
		
		/// <summary>
		/// All events will be sent to this class once received.
		/// </summary>
		protected UpHandler        up_handler=null; 
		/// <summary>
		/// Allows listening on the channel. The listener will be notified of channel closing, etc.
		/// </summary>
		protected ChannelListener  channel_listener=null;

		/// <summary>
		/// Constructor: Uses predefined stack.
		/// </summary>
		protected Channel(){}

		/// <summary>
		/// Constructor: Stack and properties are specified
		/// </summary>
		/// <param name="properties">Properties of Channel stack</param>
		protected Channel(Object properties) {}

#region "properties"
		/// <summary>Determines whether the channel is open, ie. the protocol stack has been created (may not be connected though).</summary>
		abstract public bool IsOpen{get;}
		/// <summary>Determines whether the channel is connected to a group. This implies it is open. If true is returned,
		/// then the channel can be used to send and receive messages.
		/// </summary>
		abstract public bool IsConnected{get;}
		/// <summary> Returns the number of messages that are waiting. Those messages can be
		/// removed by {@link #receive(long)}. Note that this number could change after
		/// calling this method and before calling <tt>receive()</tt> (e.g. the latter
		/// method might be called by a different thread).
		/// </summary>
		/// <returns> The number of messages on the queue, or -1 if the queue/channel
		/// is closed/disconnected.
		/// </returns>
		virtual public int NumMessages
		{
			get
			{
				return - 1;
			}
			
		}
		/// <summary> Gets the current view. This does <em>not</em> retrieve a new view, use
		/// <code>receive()</code> to do so. The view may only be available after a successful
		/// <code>connect()</code>. The result of calling this method on an unconnected channel
		/// is implementation defined (may return null). Calling it on a channel that is not
		/// enabled to receive view events (via <code>setOpt</code>) returns
		/// <code>null</code>. Calling this method on a closed channel returns a null view.
		/// </summary>
		/// <returns> The current view.  
		/// </returns>
		abstract public View View{get;}
		/// <summary>Returns the channel's own address. The result of calling this method on an unconnected
		/// channel is implementation defined (may return null). Calling this method on a closed
		/// channel returns null.
		/// </summary>
		/// <returns> The channel's address. Generated by the underlying transport, and opaque.
		/// Addresses can be used as destination in the <code>Send</code> operation.
		/// </returns>
		abstract public Address LocalAddress{get;}
		/// <summary>Returns the group address of the group of which the channel is a member. This is
		/// the object that was the argument to <code>Connect</code>. Calling this method on a closed
		/// channel returns <code>null</code>.
		/// </summary>
		/// <returns> The group address 
		/// </returns>
		abstract public string ChannelName{get;}
		/// <summary>When up_handler is set, all events will be passed to it directly. These will not be received
		/// by the channel (except connect/disconnect, state retrieval and the like). This can be used by
		/// building blocks on top of a channel; thus the channel is used as a pass-through medium, and
		/// the building blocks take over some of the channel's tasks. However, tasks such as connection
		/// management and state transfer is still handled by the channel.
		/// </summary>
		virtual public UpHandler UpHandler
		{
			set
			{
				this.up_handler = value;
			}
			
		}
		/// <summary>Allows to be notified when a channel event such as connect, disconnect or close occurs.
		/// E.g. a PullPushAdapter may choose to stop when the channel is closed, or to start when
		/// it is opened.
		/// </summary>
		virtual public ChannelListener ChannelListener
		{
			set
			{
				this.channel_listener = value;
			}
			
		}
#endregion
		
		
		/// <summary>
		/// Connects the Channel to a group.
		/// </summary>
		/// <param name="channel_name">Group to connect to (or create).</param>
        abstract public void connect(string channel_name, string subGroup_name, bool isStartedAsMirror, bool twoPhaseInitialization);
        abstract public void connectPhase2();

		/// <summary>
		/// Disconnects the Channel from the group
		/// </summary>
		abstract public void disconnect();

		/// <summary>
		/// Disconnects and closes the Channel.
		/// </summary>
		abstract public void close();

		/// <summary>
		/// Re-opens a closed channel.
		/// </summary>
		abstract public void open();

		/// <summary>
		/// Sends a message through the Channel
		/// </summary>
		/// <param name="msg">Message to be sent</param>
		abstract public void send(Message msg);

		/// <summary>Helper method. Will create a Message(dst, src, obj) and use send(Message).</summary>
		/// <param name="dst">Destination address for message. If null, message will be sent to all current group members
		/// </param>
		/// <param name="src">Source (sender's) address. If null, it will be set by the protocol's transport layer before
		/// being put on the wire. Can usually be set to null.
		/// </param>
		/// <param name="obj">Serializable object. Will be serialized into the byte buffer of the Message. If it is <em>
		/// not</em> serializable, the byte buffer will be null.
		/// </param>
		abstract public void  send(Address dst, Address src, object obj);

		/// <summary>
		/// Passes an event down the protocol stack
		/// </summary>
		/// <param name="evt">Event to be passed down the stack</param>
		virtual public void down(Event evt) {}

		/// <summary>
		/// Receives an event from the channel
		/// </summary>
		/// <param name="timeout">Time (ms) to wait for a message</param>
		/// <returns>The next Event received by the channel</returns>
		abstract public Object receive(long timeout);

		/// <summary>
		/// Performs the same as <c>receive()</c> but does not remove the Event
		/// </summary>
		/// <param name="timeout">Time (ms) to wait for a message</param>
		/// <returns>The next Event received by the channel</returns>
		abstract public Event peek(long timeout) ;

		/// <summary>
		/// Sets a variety of options within the channel
		/// </summary>
		/// <param name="option">The string representation of the option</param>
		/// <param name="value">The value that the option should be set to</param>
		abstract public void    setOpt(int option, Object value);

		/// <summary>Gets an option. This method can be called on an unconnected channel.  Calling this
		/// method on a closed channel returns <code>null</code>.
		/// </summary>
		/// <param name="option"> The option to be returned.
		/// </param>
		/// <returns> The object associated with an option.
		/// </returns>
		abstract public object getOpt(int option);

		/// <summary>Called to acknowledge a block() (callback in <code>MembershipListener</code> or
		/// <code>BlockEvent</code> received from call to <code>Receive</code>).
		/// After sending BlockOk, no messages should be sent until a new view has been received.
		/// Calling this method on a closed channel has no effect.
		/// </summary>
		abstract public void  blockOk();


        /// <summary>
        /// Get cluster stat collector instance to get values to publish on wmis
        /// </summary>
        abstract public PerfStatsCollector ClusterStatCollector { get;}

		public static string option2String(int option)
		{
			switch (option)
			{
				case BLOCK: 
					return "BLOCK";

				case SUSPECT: 
					return "SUSPECT";
				case LOCAL: 
					return "LOCAL";
				case GET_STATE_EVENTS: 
					return "GET_STATE_EVENTS";
				case AUTO_RECONNECT: 
					return "AUTO_RECONNECT";
				case AUTO_GETSTATE: 
					return "AUTO_GETSTATE";
				default: 
					return "unknown (" + option + ')';
			}
		}
	}

}