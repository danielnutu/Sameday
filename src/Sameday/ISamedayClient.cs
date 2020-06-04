using Sameday.Http;

namespace Sameday
{
    public interface ISamedayClient
    {
        SamedayRawResponse SendRequest(SamedayRequest request);

        bool Login();

        void Logoff();
    }
}
