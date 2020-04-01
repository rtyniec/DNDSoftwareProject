using DNDDesktopUI.Models;
using System.Threading.Tasks;

namespace DNDDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        Task GetLoggedInUserInfo(string token);
    }
}