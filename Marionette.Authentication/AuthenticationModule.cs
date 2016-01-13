using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Logging;
using System.ComponentModel.Composition;

namespace Marionette.Authentication
{

    [ModuleExport(typeof(AuthenticationModule))]
    public class AuthenticationModule : IModule
    {
        private readonly ILoggerFacade logger;

        [ImportingConstructor]
        public AuthenticationModule(ILoggerFacade logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }

            this.logger = logger;
        }

        public void Initialize()
        {
            this.logger.Log("Authentication Module initialized.", Category.Info, Priority.Medium);
        }
    }
}
