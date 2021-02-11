using Sameday.Requests;
using System.Collections.Generic;
using System.Linq;

namespace Sameday.Responses.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class SamedayResponsePaginationExtensions
    {
        /// <summary>
        /// Parse pagination response
        /// </summary>
        /// <param name="response"></param>
        /// <param name="request"></param>
        /// <param name="data"></param>
        public static void ParsePagination(this ISamedayPaginatedResponse response, ISamedayPaginatedRequest request, IDictionary<string, int> data)
        {
            response.CurrentPage = request.Page;
            response.PerPage = request.CountPerPage;

            if (data == null || !data.Any())
            {
                return;
            }

            response.Total = data["total"];
            response.CurrentPage = data["currentPage"];
            response.Pages = data["pages"];
            response.PerPage = data["perPage"];
        }
    }
}
