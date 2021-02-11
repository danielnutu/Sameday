using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayGetLockersRequest : ISamedayRequest
    {
        public SamedayGetLockersRequest(string[] lockerIds)
        {
            LockerIds = lockerIds;
        }

        public string[] LockerIds { get; set; }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
