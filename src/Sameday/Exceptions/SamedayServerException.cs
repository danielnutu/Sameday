using Sameday.Http;

namespace Sameday.Exceptions
{
    public class SamedayServerException : SamedaySDKException
    {

        public SamedayServerException(SamedayRequest request, SamedayRawResponse rawResponse) : this(request, rawResponse, null)
        {

        }

        public SamedayServerException(SamedayRequest request, SamedayRawResponse rawResponse, string message) : base(message)
        {
            Request = request;
            RawResponse = rawResponse;
        }

        public SamedayRequest Request { get; }
        public SamedayRawResponse RawResponse { get; }
    }
}
