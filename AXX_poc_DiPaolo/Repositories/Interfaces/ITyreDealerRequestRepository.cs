using AXX_poc_DiPaolo.Models;

namespace AXX_poc_DiPaolo.Repositories.Interfaces
{
    public interface ITyreDealerRequestRepository
    {
        void AddRequest(Request request);
        IEnumerable<Request?> FindActiveRequests(string username);
        IEnumerable<Request> FindRequestHistory(string username);
        public string FindCompanyName(string username);
        public string FindCompanyAddress(string username);
        bool SaveChanges();
    }
}
