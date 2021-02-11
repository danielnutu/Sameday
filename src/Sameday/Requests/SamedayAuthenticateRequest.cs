using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayAuthenticateRequest : ISamedayRequest
    {
        public SamedayAuthenticateRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; set; }
        public string Password { get; set; }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
