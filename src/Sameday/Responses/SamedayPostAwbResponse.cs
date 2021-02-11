using Sameday.Http;
using Sameday.Objects.PostAwb;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayPostAwbResponse : SamedayResponse
    {
        public SamedayPostAwbResponse(SamedayPostAwbRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public string AwbNumber { get; set; }
        public float Cost { get; set; }
        public ParcelObject[] Parcels { get; set; }
    }
}
