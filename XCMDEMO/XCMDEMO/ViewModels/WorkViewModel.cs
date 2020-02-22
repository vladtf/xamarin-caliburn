using Caliburn.Micro;
using XCMDEMO.NavigateToMessageEvent;

namespace XCMDEMO.ViewModels
{
    public class WorkViewModel : Screen, IChildViewModel
    {
        private readonly EventAggregator _eventAggregator;
        private string _text;

        public string Title { get; set; } = "Work";

        public WorkViewModel()
        {
            _eventAggregator = (EventAggregator)IoC.Get<EventAggregator>();
        }

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