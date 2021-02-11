using Sameday.Http;
using Sameday.Objects;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetCitiesResponse : SamedayPaginatedResponse
    {
        public SamedayGetCitiesResponse(SamedayGetCitiesRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public CityObject[] Cities { get; set; }
    }
}
