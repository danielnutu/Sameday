namespace Sameday.Http
{
    /// <summary>
    /// Class that encapsulates a raw HTTP response
    /// </summary>
    public class SamedayRawResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SamedayRawResponse()
        {
        }

        /// <summary>
        /// Gets or sets the body of the response
        /// </summary>
        public string Body { get; set; }
    }
}
