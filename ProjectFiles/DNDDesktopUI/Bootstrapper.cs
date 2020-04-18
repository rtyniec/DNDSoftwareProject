using Caliburn.Micro;
using DNDDesktopUI.Helpers;
using DNDDesktopUI.Library.Api;
using DNDDesktopUI.Library.Models;
using DNDDesktopUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DNDDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();//main class used for dependency injection
        public Bootstrapper()//we need this constructor to wire up our API on startup
        {
            Initialize();

            ConventionManager.AddElementConvention<PasswordBox>(
            PasswordBoxHelper.BoundPasswordProperty,
            "Password",
            "PasswordChanged");
        }

        protected override void Configure()//we override the BootstrapperBase Class method Configure - this method grabs all of our viewmodels automatically
        {
            _container.Instance(_container)
                .PerRequest<ICharacterEndpoint, CharacterEndpoint>();//this is a per request - its here because it is not a singleton

            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>()//part of caliburn.micro
                .Singleton<ILoggedInUserModel, LoggedInUserModel>()
                .Singleton<IAPIHelper, APIHelper>();//we only want one, and it is used for the entire life of the application - perfect use case for a singleton

            GetType().Assembly.GetTypes()//this will grab all of the viewmodel classes in the ViewModel folder in the UI project
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _container.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType));
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();//launch the shell view model
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);//use container to get shell view
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
