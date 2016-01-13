using Marionette.Infrastructure.Interfaces;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marionette.Chat.Services
{
    [Export(typeof(IChatService))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    class ChatService : IChatService
    {

        private IEventAggregator EventAggregator { get; set; }

        [ImportingConstructor]
        public ChatService(IEventAggregator eventAggregator)
        {
            this.EventAggregator = eventAggregator;
        }

        public string BroadcasterChannel
        {
            get { throw new NotImplementedException(); }
        }

        public ReadOnlyObservableCollection<string> UserList
        {
            get { throw new NotImplementedException(); }
        }

        public bool SendChatMessage(string channel, string message)
        {
            throw new NotImplementedException();
        }
    }
}
