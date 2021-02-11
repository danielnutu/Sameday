using Sameday.Http;

namespace Sameday.HttpClients
{
    public interface ISamedayHttpClient
    {
        SamedayRawResponse Send();
    }
}
