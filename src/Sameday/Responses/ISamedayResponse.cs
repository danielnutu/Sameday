using Sameday.Http;
using Sameday.Requests;

namespace Sameday.Responses
{
    /// <summary>
    /// Interface that encapsulates a request+raw response pair
    /// </summary>
    public interface ISamedayResponse
    {
        /// <summary>
        /// Gets or sets the request
        /// </summary>
        ISamedayRequest Request { get; }

        /// <summary>
        /// Gets or sets the raw response
        /// </summary>
        SamedayRawResponse RawResponse { get; }
    }
}
