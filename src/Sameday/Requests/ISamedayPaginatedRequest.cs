namespace Sameday.Requests
{
    public interface ISamedayPaginatedRequest : ISamedayRequest
    {
        int GetPage();
        int GetCountPerPage();
    }
}
