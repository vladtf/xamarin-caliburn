using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XCMDEMO.ViewModels
{
    public class BindViewModel : Screen, IChildViewModel
    {
        public string DisplayName { get; set; } = "Bind Page";
        private CancellationToken ct;
        private CancellationTokenSource cts = new CancellationTokenSource();

        public BindViewModel()
        {
            ct = cts.Token;

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Task.Delay(1000).Wait();
                    Timer++;

                    ct.ThrowIfCancellationRequested();
                }

            }, ct);

            //Thread.Sleep(1001);
            //cts.Cancel();

        }


        private int _timer;

        public int Timer
        {
            get { return _timer; }
            set { Set(ref _timer, value); }
        }



        private bool _canTime = true;

        public bool CanTime
        {
            get { return _canTime; }
            set { Set(ref _canTime, value); }
        }


        public void StartTimer()
        {
            //Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            //{
            //    Timer++;

            //    return CanTime;
            //});
            //cts.Cancel();

        }

        public void Cancel()
        {
            cts.Cancel();
        }

    }
}
