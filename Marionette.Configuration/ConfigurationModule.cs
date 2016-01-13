using Marionette.Infrastructure.Interfaces;
using Prism.Logging;
using Prism.Mef.Modularity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marionette.Configuration
{
    [ModuleExport(typeof(ConfigurationModule))]
    public class ConfigurationModule : IModule, IConfigurationService
    {
        private readonly ILoggerFacade logger;

        [ImportingConstructor]
        public ConfigurationModule(ILoggerFacade logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException("logger");
            }

            this.logger = logger;
        }

        public void Initialize()
        {
            this.logger.Log("Configuration module initialized.", Category.Info, Priority.Medium);
            // Read in configuration
        }

        public string GetConfigurationValue(string name)
        {
            throw new NotImplementedException();
        }
    }
}
