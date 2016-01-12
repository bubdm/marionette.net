using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marionette.Infrastructure.Interfaces
{
    public interface IChatService
    {
        /// <summary>
        /// The broadcaster channel name
        /// Typically, this is the broadcaster's name prefixed with #
        /// 
        /// Example: #vgpowerlord
        /// </summary>
        string BroadcasterChannel { get; }

        /// <summary>
        /// Retrieve the current User list from Twitch
        /// </summary>
        /// <returns>a List of user names</returns>
        ReadOnlyObservableCollection<string> UserList { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channel">Channel or user to send message to</param>
        /// <param name="message">The message to send</param>
        /// <returns>True if chat message was sent</returns>
        bool SendChatMessage(string channel, string message);
    }

    public static class ChatServiceExtensions
    {
        /// <summary>
        /// This is for people who didn't read the documentation for SendChatMessage and think that Private Messages
        /// are treated differently.
        /// </summary>
        /// <param name="chatService">The chatService object</param>
        /// <param name="user">The user to send a message to</param>
        /// <param name="message">The message to send</param>
        /// <returns>True if chat message was sent</returns>
        static bool SendPrivateMessage(this IChatService chatService, string user, string message)
        {
            return chatService.SendChatMessage(user, message);
        }

        /// <summary>
        /// A shortcut for SendChatMessage when you're messaging the owner's channel.
        /// </summary>
        /// <param name="chatService">The chatService object</param>
        /// <param name="message">The message to send</param>
        /// <returns>True if chat message was sent</returns>
        static bool SendChatMessage(this IChatService chatService, string message)
        {
            return chatService.SendChatMessage(chatService.BroadcasterChannel, message);
        }
    }

}
