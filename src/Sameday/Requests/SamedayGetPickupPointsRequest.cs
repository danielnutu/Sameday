using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayGetPickupPointsRequest : ISamedayPaginatedRequest
    {
        public SamedayGetPickupPointsRequest()
        {
        }

        public int Page { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CountPerPage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
