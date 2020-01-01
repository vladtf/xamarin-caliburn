using Caliburn.Micro;
using System;
using XCMDEMO.Helpers;

namespace XCMDEMO.ViewModels
{
    public class SandBoxViewModel : Screen, IChildViewModel
    {
        public SandBoxViewModel()
        {
        }

        public string DisplayName { get; set; } = "SandBox";

        public void ButtonClick(object args)
        {
            //App.Current.MainPage.DisplayAlert("Alert!", "Press ok to continue.", "Ok", "Cancel");

            //var result = SQLDataAcces.GetPeople();

            if (args != null)
                Console.WriteLine();
        }
    }
}