using Acr.UserDialogs;
using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XCMDEMO.ViewModels;

namespace XCMDEMO
{
    public partial class App : FormsApplication
    {
        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            this.container = container;

            // TODO: Register additional viewmodels and services
            container
                .Singleton<IEventAggregator, EventAggregator>()
                .PerRequest<HomeViewModel>()
                .PerRequest<MenuViewModel>();


            Initialize();

            DisplayRootViewFor<HomeViewModel>();
        }


        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
