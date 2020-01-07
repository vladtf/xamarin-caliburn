﻿using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using XCMDEMO.NavigateToMessage;

namespace XCMDEMO.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive,IHandle<NavigateToMessage.NavigateToMessage>
    {
        public ShellViewModel(IEnumerable<IChildViewModel> children, EventAggregator eventAggregator)
        {
            //SandBoxViewModel sand = (SandBoxViewModel)IoC.GetInstance(typeof(SandBoxViewModel), null);
            //WorkViewModel work = (WorkViewModel)IoC.GetInstance(typeof(WorkViewModel), null);

            //Items.Add(sand);
            //Items.Add(work);

            Items.AddRange(children);
            ActiveItem = Items.FirstOrDefault();

            eventAggregator.SubscribeOnUIThread(this);

        }

        public Task HandleAsync(NavigateToMessage.NavigateToMessage message, CancellationToken cancellationToken)
        {
            foreach (var item in Items)
            {
                //Check if type of item ends with published enum 
                if(item.GetType().ToString().EndsWith(message.NavigateToEnum.ToString()))
                {
                    ActivateItem(item);
                    return null;
                }
            }
            return null;
        }
    }
}