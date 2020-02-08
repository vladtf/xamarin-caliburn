using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XCMDEMO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingletonDemoView : ContentView
    {
        public SingletonDemoView()
        {
            InitializeComponent();
        }
    }
}