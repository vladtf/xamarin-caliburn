using Caliburn.Micro;
using System;
using XCMDEMO.NavigateToMessageEvent;

namespace XCMDEMO.ViewModels
{
    public class WorkViewModel : Screen, IChildViewModel
    {
        public WorkViewModel()
        {
        }
        public string DisplayName { get; set; } = "Work";

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