using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace XCMDEMO.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive, IHandle<NavigateToMessageEvent.NavigateToMessage>
    {
        public ShellViewModel()
        {
            //SandBoxViewModel sand = (SandBoxViewModel)IoC.GetInstance(typeof(SandBoxViewModel), null);
            //WorkViewModel work = (WorkViewModel)IoC.GetInstance(typeof(WorkViewModel), null);

            //Items.Add(sand);
            //Items.Add(work);

            IEnumerable<IChildViewModel> children = IoC.Get<IEnumerable<IChildViewModel>>();

            Items.AddRange(children);
            ActiveItem = Items.FirstOrDefault();

            //Subscribe on EventAggregator

            EventAggregator eventAggregator = IoC.Get<EventAggregator>();
            eventAggregator.SubscribeOnUIThread(this);
        }

        public Task HandleAsync(NavigateToMessageEvent.NavigateToMessage message, CancellationToken cancellationToken)
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