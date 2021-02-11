using Sameday.Http;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetAwbPdfResponse : SamedayResponse
    {
        public SamedayGetAwbPdfResponse(SamedayGetAwbPdfRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public string GetPdf()
        {
            return RawResponse.Body;
        }
    }
}
