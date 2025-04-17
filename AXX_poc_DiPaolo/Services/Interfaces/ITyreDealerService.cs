using AXX_poc_DiPaolo.Models;

namespace AXX_poc_DiPaolo.Services.Interfaces
{
    public interface ITyreDealerService
    {
        bool PublishRequest(string username, int quantity);
        IEnumerable<Request?> CollectActiveRequests(string username);
        IEnumerable<Request?> CollectRequestHistory(string username);
    }
}
