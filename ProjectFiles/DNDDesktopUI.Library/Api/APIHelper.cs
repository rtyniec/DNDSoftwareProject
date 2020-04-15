using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using DNDDesktopUI.Models;
using DNDDesktopUI.Library.Models;

namespace DNDDesktopUI.Library.Api
{
    public class APIHelper : IAPIHelper
    {
        private HttpClient _apiClient { get; set; }//i am going to need this outside of here...
        private ILoggedInUserModel _loggedInUser;

        public APIHelper(ILoggedInUserModel loggedInUser)
        {
            InitializeClient();
            _loggedInUser = loggedInUser;
        }

        public HttpClient ApiClient//this property can be used for other classes
        { 
            get
            {
                return _apiClient;
            }
        }


        private void InitializeClient()
        {
            //for this, I added the default localhost gateway to the app.config file, and added a reference for System.Configuration in the References of the UI
            string api = ConfigurationManager.AppSettings["api"];
            
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            //we will send url encoded content to the API in the form of a JSON key value pair array
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)

            });

            //the URL is going to change, we are going to do it a different way
            using (HttpResponseMessage response = await _apiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();//we use our actual data model here to get what we need
                    return result;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }//if the API call (in which we get the link from the app.config file) is successful, we grab the data from the Content, read the data asyncronously, adapt the data into the
            //authenticated user model, and return the models
        }

        public async Task GetLoggedInUserInfo(string token)//will save our token info for future calls - we need to pass in our token now
        {//since the apiClient lives the lifespan of the application, we should only have to do this once

            _apiClient.DefaultRequestHeaders.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Clear();//clear makes sure we did not add anything
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer { token }");//for every call, the default request headers need the token!
            //this makes sure that we will always send our credentials - YES - we use our GUID or short lived token

            using (HttpResponseMessage response = await _apiClient.GetAsync("/api/User"))
            {
                if(response.IsSuccessStatusCode)
                {//since this is a singleton, we do not have to save it since it exists for the life of the app
                    var result = await response.Content.ReadAsAsync<LoggedInUserModel>();
                    _loggedInUser.CreatedDate = result.CreatedDate;
                    _loggedInUser.EmailAddress = result.EmailAddress;
                    _loggedInUser.FirstName = result.FirstName;
                    _loggedInUser.LastName = result.LastName;
                    _loggedInUser.Id = result.Id;
                    _loggedInUser.Token = token;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
