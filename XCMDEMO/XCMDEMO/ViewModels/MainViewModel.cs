using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCMDEMO.ViewModels
{
    public class MainViewModel : Conductor<object>.Collection.OneActive
    {
        public ShellViewModel ShellView;

        public MainViewModel()
        {
            //ShellView = IoC.Get<ShellViewModel>();

            //ActivateItem(ShellView);

            IEnumerable<IChildViewModel> children = IoC.Get<IEnumerable<IChildViewModel>>();

            ActivateItem(children.FirstOrDefault());

            Items.AddRange(children);
        }
    }
}
