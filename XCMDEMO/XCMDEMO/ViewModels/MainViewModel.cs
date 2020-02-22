using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using XCMDEMO.NavigateToMessageEvent;

namespace XCMDEMO.ViewModels
{
    public class MainViewModel : Conductor<object>.Collection.OneActive, IHandle<NavigateToMessage>
    {
        private bool masterListAvailable;

        public ShellViewModel ShellView;

        public MainViewModel()
        {
            MasterListAvailable = true;

            //ShellView = IoC.Get<ShellViewModel>();
            //ActivateItem(ShellView);

            IEnumerable<IChildViewModel> children = IoC.Get<IEnumerable<IChildViewModel>>();

            Items.AddRange(children);

            ActivateItem(children.First());

            //Subscribe on Eventaggregator
            EventAggregator eventAggregator = IoC.Get<EventAggregator>();
            eventAggregator.SubscribeOnUIThread(this);
        }

        protected override void OnActivationProcessed(object item, bool success)
        {
            MasterListAvailable = item == null;
        }

        public bool MasterListAvailable
        {
            get { return masterListAvailable; }
            set
            {
                masterListAvailable = value;
                NotifyOfPropertyChange();
            }
        }

        public Task HandleAsync(NavigateToMessage message, CancellationToken cancellationToken)
        {
            foreach (var item in Items)
            {
                //Check if type of item ends with published enum
                if (item.GetType().ToString().EndsWith(message.NavigateToEnum.ToString()))
                {
                    ActivateItem(item);
                    return Task.CompletedTask;
                }
            }
            return Task.CompletedTask;
        }
    }
}