using DNDDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI.Library.Api
{
    public class CharacterEndpoint : ICharacterEndpoint
    {
        private IAPIHelper _apiHelper;
        public CharacterEndpoint(IAPIHelper apiHelper)//since this needs to talk to API, we bring in the apiHelper through dep. injection
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<CharacterModel>> GetAll()//return a list of the data represented as a character model
        {//remember, this returns all characters created by the USER ONLY!!!
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Character"))//ApiClient is a property in the ApiHelper
            {//above is where we call the api controller in the DNDTransfer project
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<CharacterModel>>();//this will store multiple character models
                    return result;//should satisfy what we need?
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
