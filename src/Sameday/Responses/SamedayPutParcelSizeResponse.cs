using Sameday.Http;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayPutParcelSizeResponse : SamedayResponse
    {
        public SamedayPutParcelSizeResponse(SamedayPutParcelSizeRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }
    }
}
