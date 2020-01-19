using Caliburn.Micro;
using Xamarin.Forms;

namespace XCMDEMO.ViewModels
{
    public class SandBoxViewModel : Screen, IChildViewModel
    {
        public string Title { get; set; } = "SandBox";

        public SandBoxViewModel()
        {
        }

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