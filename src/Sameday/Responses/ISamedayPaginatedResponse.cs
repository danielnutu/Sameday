namespace Sameday.Responses
{
    /// <summary>
    /// Interface to encapsulate response pagination
    /// </summary>
    public interface ISamedayPaginatedResponse : ISamedayResponse
    {
        /// <summary>
        /// 
        /// </summary>
        int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int CurrentPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int PerPage { get; set; }
    }
}
