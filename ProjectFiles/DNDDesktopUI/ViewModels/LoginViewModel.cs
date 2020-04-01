using Caliburn.Micro;
using DNDDesktopUI.EventModels;
using DNDDesktopUI.Library.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI.ViewModels
{
    public class LoginViewModel : Screen//this is our view model - below we will have the properties for username and password (password is kind of annoying)
    {//
		private string _userName;//this is a private backing field - modify the prop, not me!
		private string _password;//we just supply and hold the properties value
		private IAPIHelper _apiHelper;
		private IEventAggregator _events;

		public LoginViewModel(IAPIHelper apiHelper, IEventAggregator events)
		{
			_apiHelper = apiHelper;//depend injection to use this for this view model
			_events = events;
		}


		public string UserName
		{
			get { return _userName; }
			set 
			{ 
				_userName = value;
				NotifyOfPropertyChange(() => UserName);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		

		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				NotifyOfPropertyChange(() => Password);//hit the property to update it accordingly
				NotifyOfPropertyChange(() => CanLogIn);//lets see if we can enable the login button?
			}
		}

		public bool IsErrorVisible
		{
			get //this is just a get and does a calculation
			{
				bool output = false;
				
				if(String.IsNullOrWhiteSpace(ErrorMessage) == false)
				{
					output = true;
				}

				return output;
			}
			
		}

		private string _errorMessage;

		public string ErrorMessage
		{
			get { return _errorMessage; }
			set 
			{
				_errorMessage = value;
				NotifyOfPropertyChange(() => ErrorMessage);
				NotifyOfPropertyChange(() => IsErrorVisible);

			}
		}



		public bool CanLogIn//we use the properties instead of the private backing fields
		{
			get
			{
				bool output = false;
				if (UserName?.Length > 0 && Password?.Length > 0)//it is valid! something with question mark syntax
				{
					output = true;
				}

				return output;
			}


		}

		public async Task LogIn()//this method calls our API helper - since we are calling the API helper, we need to make it asyncronous
		{
			try
			{
				ErrorMessage = "";
				var result = await _apiHelper.Authenticate(UserName, Password);//pass in the property values - remember this model has prop Access_Token!!

				// capture more information about the user
				await _apiHelper.GetLoggedInUserInfo(result.Access_Token);//we are using the access token, which will be saved to the singleton class
																		  //and will be used to validate API calls

				//now we are going to raise an event - other UIs can use it w/out crossthreading issues
				_events.PublishOnUIThread(new LogOnEvent());//we create something and see if something in the software is looking for it
				//this will trigger the ShellViewModel event
				
			}
			catch (Exception ex)//if it fails we can use the ex to display/record the message
			{
				ErrorMessage = ex.Message;
			}
		}


	}
}
