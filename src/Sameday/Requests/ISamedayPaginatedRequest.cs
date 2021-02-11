namespace Sameday.Requests
{
    /// <summary>
    /// Interface that encapsulates a paginated request
    /// </summary>
    public interface ISamedayPaginatedRequest : ISamedayRequest
    {
        /// <summary>
        /// Gets or sets the page to be requested
        /// </summary>
        int Page { get; set; } 

        /// <summary>
        /// Gets or sets the number of elements to be requested
        /// </summary>
        int CountPerPage { get; set; }
    }
}
