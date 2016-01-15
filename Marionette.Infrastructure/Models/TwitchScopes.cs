using System;
using System.Collections.Generic;

namespace Marionette.Infrastructure
{ 
    [Flags]
    public enum TwitchScopes
    {
        none = 0,

        /// <summary>
        /// Read access to non-public user information, such as email address.
        /// </summary>
        user_read = (1 << 0),

        /// <summary>
        /// Ability to ignore or unignore on behalf of a user.
        /// </summary>
        user_blocks_edit = (1 << 1),

        /// <summary>
        /// Read access to a user's list of ignored users.
        /// </summary>
        user_blocks_read = (1 << 2),

        /// <summary>
        /// Access to manage a user's followed channels.
        /// </summary>
        user_follows_edit = (1 << 3),

        /// <summary>
        /// Read access to non-public channel information, including email address and stream key.
        /// </summary>
        channel_read = (1 << 4),

        /// <summary>
        /// Write access to channel metadata (game, status, etc).
        /// </summary>
        channel_editor = (1 << 5),

        /// <summary>
        /// Access to trigger commercials on channel.
        /// </summary>
        channel_commercial = (1 << 6),

        /// <summary>
        /// Ability to reset a channel's stream key.
        /// </summary>
        channel_stream = (1 << 7),

        /// <summary>
        /// Read access to all subscribers to your channel.
        /// </summary>
        channel_subscriptions = (1 << 8),

        /// <summary>
        /// Read access to subscriptions of a user.
        /// </summary>
        user_subscriptions = (1 << 9),

        /// <summary>
        /// Read access to check if a user is subscribed to your channel.
        /// </summary>
        channel_check_subscriptions = (1 << 10),

        /// <summary>
        /// Ability to log into chat and send messages.
        /// </summary>
        chat_login = (1 << 11)
    }

    public static class TwitchScopesExtensions
    {
        /// <summary>
        /// Turn a set of scope flags into a string
        /// </summary>
        /// <param name="scopes">TwitchScopes flag list</param>
        /// <returns>Space-separated scope string</returns>
        public static string ScopesToString(TwitchScopes scopes)
        {
            if (!scopes.Equals(TwitchScopes.none))
            {
                return String.Empty;
            }

            string outVal = scopes.ToString("g");
            // Replace commas with spaces
            return outVal.Replace(",", " ");
        }

        public static TwitchScopes StringToScopes(string stringVal)
        {
            // Replace spaces with commas
            string inVal = stringVal.Replace(" ", ",");
            TwitchScopes outVal;

            if (!Enum.TryParse<TwitchScopes>(inVal, out outVal))
            {
                throw new ArgumentException("Invalid scope list string", stringVal);
            }

            return outVal;
        }
    }
}