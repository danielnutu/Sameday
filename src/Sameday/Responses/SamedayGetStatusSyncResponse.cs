using Sameday.Http;
using Sameday.Objects.StatusSync;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetStatusSyncResponse : SamedayPaginatedResponse
    {
        public SamedayGetStatusSyncResponse(SamedayGetStatusSyncRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public StatusObject[] Statuses { get; set; }
    }
}
