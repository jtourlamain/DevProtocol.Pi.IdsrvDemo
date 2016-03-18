using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;

namespace DevProtocol.Pi.IdsrvDemo.Web.Configuration
{
    public class Users
    {
        public static List<InMemoryUser> Get()
        {
            var users = new List<InMemoryUser>
            {
                 new InMemoryUser{Subject = "123", Username = "bob", Password = "secret",
                    Claims = new Claim[]
                    {
                        new Claim(Constants.ClaimTypes.Name, "Bob Smith"),
                        new Claim(Constants.ClaimTypes.GivenName, "Bob"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Smith"),
                        new Claim(Constants.ClaimTypes.Email, "BobSmith@email.com"),
                        new Claim(Constants.ClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(Constants.ClaimTypes.Role, "Developer"),
                        new Claim(Constants.ClaimTypes.Role, "Geek"),
                    }
                },
                new InMemoryUser{Subject = "456", Username = "jan", Password = "secret",
                    Claims = new Claim[]
                    {
                        new Claim(Constants.ClaimTypes.Name, "Jan Tourlamain"),
                        new Claim(Constants.ClaimTypes.GivenName, "Jan"),
                        new Claim(Constants.ClaimTypes.FamilyName, "Tourlamain"),
                        new Claim(Constants.ClaimTypes.Email, "jtourlamain@email.com"),
                        new Claim(Constants.ClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(Constants.ClaimTypes.Role, "Developer"),
                        new Claim(Constants.ClaimTypes.Role, "Admin"),
                    }
                }
            };

            return users;
        }
    }
}