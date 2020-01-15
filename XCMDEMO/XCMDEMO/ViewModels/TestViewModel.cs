using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XCMDEMO.Models;
using XCMDEMO.NavigateToMessageEvent;

namespace XCMDEMO.ViewModels
{
    public class TestViewModel : Screen, IChildViewModel,IHandle<PersonModel>
    {
        private readonly EventAggregator _eventAggregator;
        private PersonModel _person;
        public TestViewModel()
        {
            _eventAggregator = IoC.Get<EventAggregator>();
            _eventAggregator.SubscribeOnUIThread(this);

            Person = new PersonModel();

            Person.FirstName = "FirstName";
            Person.LastName = "LastName";
        }

        public string DisplayName { get; set; } = "Test";

        public Task HandleAsync(PersonModel message, CancellationToken cancellationToken)
        {
            Person = message;

            _eventAggregator.PublishOnUIThreadAsync(new NavigateToMessage(NavigateToEnum.TestViewModel));

            return null;
        }


        public PersonModel Person
        {
            get { return _person; }
            set { Set(ref _person, value); }
        }


        public void ToWork()
        {
            _eventAggregator.PublishOnUIThreadAsync(new NavigateToMessage(NavigateToEnum.WorkViewModel));
        }


    }
}
