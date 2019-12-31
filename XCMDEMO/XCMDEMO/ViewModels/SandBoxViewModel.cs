using Caliburn.Micro;
using XCMDEMO.Helpers;

namespace XCMDEMO.ViewModels
{
    public class SandBoxViewModel : Screen
    {
        public SandBoxViewModel()
        {
            DisplayName = "SandBox";

            var result = SQLDataAcces.GetPeople();
        }

        public async void ButtonClick(object args)
        {
            await App.Current.MainPage.DisplayAlert("Alert!", "Press ok to continue.", "Ok", "Cancel");
        }
    }
}