using Sameday.Http;
using System;

namespace Sameday.Requests
{
    public class SamedayPutAwbCODAmountRequest : ISamedayRequest
    {
        public SamedayPutAwbCODAmountRequest(string awbNumber, float codAmount)
        {
            AwbNumber = awbNumber;
            CodAmount = codAmount;
        }

        public string AwbNumber { get; set; }
        public float CodAmount { get; set; }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
