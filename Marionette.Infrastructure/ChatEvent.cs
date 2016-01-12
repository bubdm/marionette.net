using Marionette.Infrastructure.Models;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marionette.Infrastructure
{
    public class ChatEvent : PubSubEvent<ChatEventArgs>
    {
    }
}
