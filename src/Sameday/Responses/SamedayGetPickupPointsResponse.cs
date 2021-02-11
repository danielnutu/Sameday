using Sameday.Http;
using Sameday.Objects.PickupPoint;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetPickupPointsResponse : SamedayPaginatedResponse
    {
        public SamedayGetPickupPointsResponse(SamedayGetPickupPointsRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public PickupPointObject[] PickupPoints { get; set; }
    }
}
