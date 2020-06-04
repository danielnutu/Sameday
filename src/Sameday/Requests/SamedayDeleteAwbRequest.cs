using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayDeleteAwbRequest : ISamedayRequest
    {
        private readonly string _awb;

        public SamedayDeleteAwbRequest(string awb)
        {
            this._awb = awb;
        }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
