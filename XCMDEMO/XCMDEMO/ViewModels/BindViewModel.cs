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

        public BindViewModel()
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            try
            {
                //this runs your asynchronous method
                //you must check periodically to see 
                //if cancellation has been requested
                Task.Run(() =>
                {
                    while (true)
                    {
                        Timer++;

                        Thread.Sleep(1000);
                        //check to see if operation is cancelled
                        //and throw exception if it is
                        token.ThrowIfCancellationRequested();
                    }
                }, token);
            }
            catch (OperationCanceledException)
            {
                CanTime = false;
            }
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


        private CancellationTokenSource cts;
        //called from a 'start' button click
        private async void StartTimer()
        {


        }
        //called from a 'cancel' button
        private void Cancel()
        {
            cts.Cancel();
        }
    }
}
