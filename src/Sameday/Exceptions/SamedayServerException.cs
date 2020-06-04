using Sameday.Http;

namespace Sameday.Exceptions
{
    public class SamedayServerException: SamedaySDKException
    {
        public SamedayServerException(SamedayRequest request, SamedayRawResponse rawResponse)
        {
            Request = request;
            RawResponse = rawResponse;
        }

        public SamedayRequest Request { get; }
        public SamedayRawResponse RawResponse { get; }
    }
}
