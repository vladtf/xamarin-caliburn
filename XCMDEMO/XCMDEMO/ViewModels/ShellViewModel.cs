using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;

namespace XCMDEMO.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive
    {
        public ShellViewModel(IEnumerable<IChildViewModel> children)
        {
            //SandBoxViewModel sand = (SandBoxViewModel)IoC.GetInstance(typeof(SandBoxViewModel), null);
            //WorkViewModel work = (WorkViewModel)IoC.GetInstance(typeof(WorkViewModel), null);

            //Items.Add(sand);
            //Items.Add(work);

            Items.AddRange(children);
            ActiveItem = Items.FirstOrDefault();
        }
    }
}