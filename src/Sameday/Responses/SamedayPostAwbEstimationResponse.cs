using Sameday.Http;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayPostAwbEstimationResponse : SamedayResponse
    {
        public SamedayPostAwbEstimationResponse(SamedayPostAwbEstimationRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public float Cost { get; set; }
        public string Currency { get; set; }
        public int Time { get; set; }
    }
}
