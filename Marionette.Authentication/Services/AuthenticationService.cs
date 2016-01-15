using Marionette.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marionette.Authentication.Services
{
    [Export(typeof(IAuthenticationService))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    class AuthenticationService : IAuthenticationService
    {
        public bool IsAuthorizationComplete
        {
            get { throw new NotImplementedException(); }
        }

        public string AuthorizationToken
        {
            get { throw new NotImplementedException(); }
        }
    }
}
