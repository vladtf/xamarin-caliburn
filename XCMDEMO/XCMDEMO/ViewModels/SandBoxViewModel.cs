using Caliburn.Micro;
using Xamarin.Forms;

namespace XCMDEMO.ViewModels
{
    public class SandBoxViewModel : Screen, IChildViewModel
    {
        public SandBoxViewModel()
        {
        }

        public string DisplayName { get; set; } = "SandBox";

        public void ButtonClick(object sender)
        {
            if (sender?.GetType() == typeof(Button))
            {
                Button button = (Button)sender;
                string text = button.Text;

                App.Current.MainPage.DisplayAlert("Alert!", text, "Ok", "Cancel");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Alert!", "Press ok to continue.", "Ok", "Cancel");
            }
        }
    }
}