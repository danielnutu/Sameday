using Sameday.Http;
using Sameday.Objects.AwbStatusHistory;
using Sameday.Requests;

namespace Sameday.Responses
{
    public class SamedayGetAwbStatusHistoryResponse : SamedayResponse
    {
        public SamedayGetAwbStatusHistoryResponse(SamedayGetAwbStatusHistoryRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public SummaryObject Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HistoryObject[] Histories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ExpeditionObject ExpeditionStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ParcelObject[] Parcels { get; set; }
    }
}
