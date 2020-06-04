using Sameday.Http;

namespace Sameday.Exceptions
{
    public class SamedayAuthenticationException : SamedayServerException
    {
        public SamedayAuthenticationException(SamedayRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }
    }
}
