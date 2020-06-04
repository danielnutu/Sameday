using Sameday.Http;

namespace Sameday.Exceptions
{
    public class SamedayAuthorizationException : SamedayServerException
    {
        public SamedayAuthorizationException(SamedayRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }
    }
}
