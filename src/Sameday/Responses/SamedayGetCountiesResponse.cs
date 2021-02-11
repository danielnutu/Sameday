using Sameday.Http;
using Sameday.Objects;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetCountiesResponse : SamedayPaginatedResponse
    {
        public SamedayGetCountiesResponse(SamedayGetCountiesRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public CountyObject[] Counties { get; set; }
    }
}
