using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace DevProtocol.Pi.IdsrvDemo.Web.Configuration
{
    public class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new[]
            {
                StandardScopes.OpenId,
                StandardScopes.ProfileAlwaysInclude,
                StandardScopes.EmailAlwaysInclude,

                new Scope
                {
                    Name = "apipi",
                    DisplayName = "my pi api",
                    Type = ScopeType.Resource,

                    Claims = new List<ScopeClaim>
                    {
                        new ScopeClaim("role")
                    }
                }
            };
        }
    }
}