using DNDTransfer.Library.DataAccess;
using DNDTransfer.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DNDTransfer.Controllers
{
    //[Authorize]
    public class CharacterController : ApiController
    {
        //this is our actual API call
        [HttpGet]
        public List<CharacterModel> GetById()
        {//create a new connection to our library and call the user data method
            string userId = RequestContext.Principal.Identity.GetUserId();//get the user ID from who is logged in using EF DB

            CharacterData data = new CharacterData();//dependency - UserData is our intermediate class

            return data.GetCharacters(userId);//we are sending a whole list of this

        }
    }
}
