using Sameday.Http;

namespace Sameday.Exceptions
{
    public class SamedayBadRequestException : SamedayServerException
    {
        public SamedayBadRequestException(SamedayRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }
    }
}
