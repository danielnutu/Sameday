using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayGetCountiesRequest : ISamedayPaginatedRequest
    {
        public SamedayGetCountiesRequest(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Page { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CountPerPage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
