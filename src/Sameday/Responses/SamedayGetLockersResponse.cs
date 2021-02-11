using Sameday.Http;
using Sameday.Objects.Locker;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetLockersResponse : SamedayResponse
    {
        public SamedayGetLockersResponse(SamedayGetLockersRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public LockerObject[] Lockers { get; set; }
    }
}
