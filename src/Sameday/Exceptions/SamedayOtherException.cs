using Sameday.Http;

namespace Sameday.Exceptions
{
    public class SamedayOtherException : SamedayServerException
    {
        public SamedayOtherException(SamedayRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }
    }
}
