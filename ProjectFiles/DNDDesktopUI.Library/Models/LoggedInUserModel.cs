using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI.Library.Models
{
    public class LoggedInUserModel : ILoggedInUserModel
    //we are repeating ourselves, but they are really two different things in the library
    {//loggedinusermodel and usermodel are two different things

        public string Token { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
