using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCMDEMO.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive
    {
        public ShellViewModel(SandBoxViewModel sand, WorkViewModel work)
        {
            Items.Add(sand); Items.Add(work);
            ActivateItem(work);
        }
    }
}
