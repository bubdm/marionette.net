using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marionette.Infrastructure.Interfaces
{
    public interface IConfigurationService
    {
        public string GetConfigurationValue(string name);
    }
}
