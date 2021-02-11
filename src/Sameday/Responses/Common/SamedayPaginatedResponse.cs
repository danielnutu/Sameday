using Sameday.Http;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayPaginatedResponse : SamedayResponse, ISamedayPaginatedResponse
    {
        public SamedayPaginatedResponse(ISamedayRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public int Total { get; set; }
        public int CurrentPage { get; set; }
        public int Pages { get; set; }
        public int PerPage { get; set; }
    }
}
