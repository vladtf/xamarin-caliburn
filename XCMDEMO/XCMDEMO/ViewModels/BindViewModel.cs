using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XCMDEMO.ViewModels
{
    public class BindViewModel : Screen, IChildViewModel
    {
        public string DisplayName { get; set; } = "Bind Page";

        public BindViewModel()
        {


            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Task.Delay(1000).Wait();
                    Timer++;
                }
            });
        }


        private int _timer;

        public int Timer
        {
            get { return _timer; }
            set { Set(ref _timer, value); }
        }



    }
}
