using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XCMDEMO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellView : TabbedPage
    {
        public ShellView()
        {
            InitializeComponent();
        }
    }
}