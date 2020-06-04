using Sameday.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sameday.Requests
{
    public class SamedayAuthenticateRequest : ISamedayRequest
    {
        private readonly string _userName;
        private readonly string _password;

        public SamedayAuthenticateRequest(string userName, string password)
        {
            this._userName = userName;
            this._password = password;
        }

        public SamedayRequest BuildRequest()
        {
            return new SamedayRequest();
        }
    }
}
