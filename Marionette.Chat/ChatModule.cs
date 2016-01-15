using Prism.Modularity;
using Prism.Mef.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marionette.Chat
{
    [ModuleExport(typeof(ChatModule), DependsOnModuleNames= new string[] { "AuthenticationModule"})]
    public class ChatModule : IModule
    {
        public void Initialize()
        {
            throw new NotImplementedException();
        }

    }
}
