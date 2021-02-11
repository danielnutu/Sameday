using Sameday.Http;
using Sameday.Objects.Types;
using System;

namespace Sameday.Requests
{
    public class SamedayGetAwbPdfRequest : ISamedayRequest
    {
        public SamedayGetAwbPdfRequest(string awbNumber, AwbPdfType awbPdfType)
        {
            AwbNumber = awbNumber;
            AwbPdfType = awbPdfType;
        }

        public string AwbNumber { get; set; }
        public AwbPdfType AwbPdfType { get; set; }

        public SamedayRequest BuildRequest()
        {
            throw new NotImplementedException();
        }
    }
}
