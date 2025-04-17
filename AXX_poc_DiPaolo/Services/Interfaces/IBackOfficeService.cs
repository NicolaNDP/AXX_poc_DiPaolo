using AXX_poc_DiPaolo.Models;

namespace AXX_poc_DiPaolo.Services.Interfaces
{
    public interface IBackOfficeService
    {
        IEnumerable<Request?> CollectAllRequests();
        IEnumerable<Request?> CollectCompletedRequests();
        IEnumerable<Request?> CollectAvailableRequests();
        IEnumerable<Request?> CollectInProgressRequests();
        Request? CollectRequestById(Guid id);
        bool ValidateRequest(Guid id, int quantity);
    }
}
