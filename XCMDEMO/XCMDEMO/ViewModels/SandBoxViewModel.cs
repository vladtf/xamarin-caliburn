using Caliburn.Micro;
using System;

namespace XCMDEMO.ViewModels
{
    public class SandBoxViewModel : Screen
    {
        public SandBoxViewModel()
        {

        }

        public string DisplayName { get; set; } = "SandBox";

        public async void ButtonClick(object args)
        {
            await App.Current.MainPage.DisplayAlert("Alert!", "Press ok to continue.", "Ok", "Cancel");
        }
    }
}