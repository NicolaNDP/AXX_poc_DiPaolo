using AXX_poc_DiPaolo.Models;

namespace AXX_poc_DiPaolo.Services.Interfaces
{
    public interface ITransporterService
    {
        IEnumerable<Request?> CollectAvailableRequests();
        IEnumerable<Request?> CollectRequestHistory(string username);
        IEnumerable<Request?> CollectActiveRequests(string username);
        bool AssignRequest(Guid id, string username, DateTime pickupDate);
    }
}
