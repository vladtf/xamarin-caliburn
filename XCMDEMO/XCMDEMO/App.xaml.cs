using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using XCMDEMO.ViewModels;

namespace XCMDEMO
{
    public partial class App : FormsApplication
    {
        public App()
        {
            Initialize();

            DisplayRootViewFor<HomeViewModel>();
        }
    }
}