using Sameday.Http;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayDeleteAwbResponse : SamedayResponse
    {
        public SamedayDeleteAwbResponse(SamedayDeleteAwbRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }
    }
}
