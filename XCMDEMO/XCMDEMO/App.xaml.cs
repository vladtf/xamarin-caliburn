using Caliburn.Micro.Xamarin.Forms;
using Xamarin.Forms;
using XCMDEMO.ViewModels;

namespace XCMDEMO
{
    public partial class App : FormsApplication
    {
        public App(ShellViewModel shell)
        {
            InitializeComponent();

            MessageBinder.SpecialValues.Add("$selecteditem", c =>
            {
                var listView = c.Source as ListView;

                return listView?.SelectedItem;
            });
            MessageBinder.SpecialValues.Add("$sender", c =>
            {
                return c?.Source;
            });

            DisplayRootViewFor<ShellViewModel>();
        }
    }
}