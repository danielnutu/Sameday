using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayGetParcelStatusHistoryRequest : ISamedayRequest
    {
        public SamedayGetParcelStatusHistoryRequest(string parcel)
        {
            Parcel = parcel;
        }

        public string Parcel { get; set; }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
