using DNDDesktopUI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace DNDDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        HttpClient ApiClient { get; }//this property can be used for other classes
        

        Task GetLoggedInUserInfo(string token);
    }
}