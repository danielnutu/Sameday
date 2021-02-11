using Sameday.Http;
using Sameday.Objects.AwbStatusHistory;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetParcelStatusHistoryResponse : SamedayResponse
    {
        public SamedayGetParcelStatusHistoryResponse(SamedayGetParcelStatusHistoryRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        public SummaryObject Summary { get; set; }
        public HistoryObject[] History { get; set; }
        public ExpeditionObject ExpeditionStatus { get; set; }
    }
}
