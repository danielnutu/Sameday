using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayGetAwbStatusHistoryRequest : ISamedayRequest
    {
        public SamedayGetAwbStatusHistoryRequest(string awb)
        {
            Awb = awb;
        }

        public string Awb { get; set; }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
