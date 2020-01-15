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

        private bool masterListAvailable;


        public MainViewModel()
        {

            MasterListAvailable = true;
            //ShellView = IoC.Get<ShellViewModel>();

            //ActivateItem(ShellView);

            IEnumerable<IChildViewModel> children = IoC.Get<IEnumerable<IChildViewModel>>();

            Items.AddRange(children);

            ActivateItem(Items.FirstOrDefault());
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
    }
}
