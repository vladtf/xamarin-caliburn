using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using XCMDEMO.ViewModels;

namespace XCMDEMO
{
    public partial class App : FormsApplication
    {
        private readonly SimpleContainer _simpleContainer;

        public App(SimpleContainer simpleContainer)
        {

            _simpleContainer = simpleContainer;

            Initialize();

            DisplayRootViewFor<ShellViewModel>();
        }

    }
}