using Sameday.Http;

namespace Sameday.Exceptions
{
    public class SamedayNotFoundException : SamedayServerException
    {
        public SamedayNotFoundException(SamedayRequest request, SamedayRawResponse rawResponse) : base(request, rawResponse)
        {
        }
    }
}
