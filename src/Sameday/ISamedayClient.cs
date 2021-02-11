using Sameday.Http;

namespace Sameday
{
    /// <summary>
    /// Interface that encapsulates a HTTP client requests
    /// </summary>
    public interface ISamedayClient
    {
        /// <summary>
        /// Send a request and return raw response
        /// </summary>
        /// <param name="request"><see cref="SamedayRequest"/></param>
        /// <returns><see cref="SamedayRawResponse"/></returns>
        SamedayRawResponse SendRequest(SamedayRequest request);

        /// <summary>
        /// Attempt to authenticate to api
        /// </summary>
        /// <returns></returns>
        bool Login();

        /// <summary>
        /// Logout from api, removing persistent data
        /// </summary>
        void Logoff();
    }
}
