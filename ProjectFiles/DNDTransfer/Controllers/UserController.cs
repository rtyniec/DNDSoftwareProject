using DNDTransfer.Library.DataAccess;
using DNDTransfer.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace DNDTransfer.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {

        //this is our actual API call
        [HttpGet]
        public UserModel GetById()
        {//create a new connection to our library and call the user data method
            string userId = RequestContext.Principal.Identity.GetUserId();//get the user ID from who is logged in using EF DB

            UserData data = new UserData();//dependency - UserData is our intermediate class

             return data.GetUserById(userId).First();//this is why our users table has the guid, not a number
            
        }

     
    }
}
