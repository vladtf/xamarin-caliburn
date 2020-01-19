using Caliburn.Micro;
using XCMDEMO.NavigateToMessageEvent;

namespace XCMDEMO.ViewModels
{
    public class WorkViewModel : Screen, IChildViewModel
    {
        public string Title { get; set; } = "Work";

        public WorkViewModel()
        {
        }

        private string _text;
        private readonly EventAggregator _eventAggregator = (EventAggregator)IoC.Get<EventAggregator>();

        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }

        public void NavigateToHome()
        {
            _eventAggregator.PublishOnUIThreadAsync(new NavigateToMessage(NavigateToEnum.HomeViewModel));
        }
    }
}