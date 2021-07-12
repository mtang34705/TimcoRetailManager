using System.Net.Http;
using System.Threading.Tasks;
using TRMWPFUserInterface.Models;

namespace TRMWPFUserInterface.Helpers
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}