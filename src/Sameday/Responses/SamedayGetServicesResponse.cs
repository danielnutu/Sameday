using Sameday.Http;
using Sameday.Objects.Service;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetServicesResponse : SamedayPaginatedResponse
    {
        public SamedayGetServicesResponse(SamedayGetServicesRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public ServiceObject[] Services { get; set; }
    }
}
