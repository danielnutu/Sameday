using Sameday.Http;
using Sameday.Requests;

namespace Sameday.Responses
{
    /// <summary>
    /// Abstract class that encapsulates a request+raw response pair
    /// </summary>
    public abstract class SamedayResponse : ISamedayResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="request"></param>
        /// <param name="rawResponse"></param>
        protected SamedayResponse(ISamedayRequest request, SamedayRawResponse rawResponse)
        {
            Request = request;
            RawResponse = rawResponse;
        }

        /// <summary>
        /// Gets or sets the request
        /// </summary>
        public ISamedayRequest Request { get; }

        /// <summary>
        /// Gets or sets the raw response
        /// </summary>
        public SamedayRawResponse RawResponse { get; }
    }
}
