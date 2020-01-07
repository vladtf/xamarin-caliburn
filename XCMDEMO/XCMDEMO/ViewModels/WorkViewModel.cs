using Caliburn.Micro;
using System;
using XCMDEMO.NavigateToMessage;

namespace XCMDEMO.ViewModels
{
    public class WorkViewModel : Screen, IChildViewModel
    {
        public WorkViewModel(EventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public string DisplayName { get; set; } = "Work";

        private string _text;
        private readonly EventAggregator _eventAggregator;

        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }

        public void NavigateToHome()
        {
            _eventAggregator.PublishOnUIThreadAsync(new NavigateToMessage.NavigateToMessage(NavigateToEnum.HomeViewModel));
        }
    }
}