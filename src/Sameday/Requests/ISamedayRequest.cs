using Sameday.Http;

namespace Sameday.Requests
{
    public interface ISamedayRequest
    {
        SamedayRequest BuildRequest();
    }
}
