using Caliburn.Micro.Xamarin.Forms;
using XCMDEMO.ViewModels;

namespace XCMDEMO
{
    public partial class App : FormsApplication
    {
        public App(ShellViewModel shell)
        {
            InitializeComponent();

            DisplayRootViewFor<ShellViewModel>();
        }
    }
}