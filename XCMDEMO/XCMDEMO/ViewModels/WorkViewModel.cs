using Caliburn.Micro;

namespace XCMDEMO.ViewModels
{
    public class WorkViewModel : Screen
    {
        public WorkViewModel()
        {
            DisplayName = "Work";
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }
    }
}