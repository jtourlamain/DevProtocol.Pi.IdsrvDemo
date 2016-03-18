using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace DevProtocol.Pi.IdsrvDemo.Web.Configuration
{
    public class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    Enabled = true,
                    ClientId = "implicitmobile",
                    ClientName = "Mobile Client",
                    Flow = Flows.Implicit,
                    RequireConsent = true,
                    
                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "email",
                        "profile",
                        "apipi"
                    },
                     RedirectUris = new List<string>
                    {
                        "http://devprotocol.pi/redirect"
                    }
                },
            };
        }
    }
}