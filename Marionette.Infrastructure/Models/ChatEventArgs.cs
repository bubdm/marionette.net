using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marionette.Infrastructure.Models
{
    public class ChatEventArgs : EventArgs
    {
        public string ChatText { get; private set; }

        public string Sender { get; private set; }

        public bool Action { get; private set; }

        public bool PrivateChat { get; private set; }

        public ChatEventArgs(string sender, string chatText, bool action, bool privateChat)
        {
            this.Sender = sender;
            this.ChatText = chatText;
            this.Action = action;
            this.PrivateChat = privateChat;
        }
    }
}
