using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayGetStatusSyncRequest : ISamedayPaginatedRequest
    {
        public SamedayGetStatusSyncRequest(int startTimestamp, int endTimestamp)
        {
            StartTimestamp = startTimestamp;
            EndTimestamp = endTimestamp;
        }

        public int StartTimestamp { get; set; }
        public int EndTimestamp { get; set; }
        public int Page { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CountPerPage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }

    }
}
