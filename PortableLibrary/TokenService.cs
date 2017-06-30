using System;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace PortableLibrary
{
    public class TokenService
    {
		private readonly string authority;

		public TokenService(string authority)
		{
			this.authority = authority;
		}

		public async Task<string> GetTokenAsync(string resource, string clientId, string returnUrl, IPlatformParameters platformParameters)
		{
			var context = new AuthenticationContext(authority);
			var response = await context.AcquireTokenAsync(resource, clientId, new Uri(returnUrl), platformParameters);
			return response.AccessToken;
		}
    }
}
