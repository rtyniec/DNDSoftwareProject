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

        public async Task<List<CharacterModel>> GetAll()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Character"))
            {
                if (response.IsSuccessStatusCode)
                {//since this is a singleton, we do not have to save it since it exists for the life of the app
                    var result = await response.Content.ReadAsAsync<List<CharacterModel>>();//this will store multiple character models
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
