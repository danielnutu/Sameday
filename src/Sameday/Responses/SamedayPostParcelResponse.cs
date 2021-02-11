using Sameday.Http;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayPostParcelResponse : SamedayResponse
    {
        public SamedayPostParcelResponse(SamedayPostParcelRequest request, SamedayRawResponse rawResponse, string parcelAwbNumber) : base(request, rawResponse)
        {
            ParcelAwbNumber = parcelAwbNumber;
        }

        public string ParcelAwbNumber { get; set; }
    }
}
