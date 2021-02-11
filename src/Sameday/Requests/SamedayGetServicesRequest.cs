using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayGetServicesRequest : ISamedayPaginatedRequest
    {
        public SamedayGetServicesRequest()
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
