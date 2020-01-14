using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCMDEMO.ViewModels
{
    public class MainViewModel : Conductor<object>.Collection.OneActive
    {
        public ShellViewModel ShellView;

        public MainViewModel()
        {
            ShellView = IoC.Get<ShellViewModel>();

            ActivateItem(ShellView);
        }
    }
}
