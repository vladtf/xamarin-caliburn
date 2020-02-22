using Caliburn.Micro;
using System;
using Xamarin.Forms;

namespace XCMDEMO.ViewModels
{
    public class BindViewModel : Screen, IChildViewModel
    {
        private int _timer;
        private bool _canTime = true;
        public string Title { get; set; } = "Bind Page";

        public BindViewModel()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
             {
                 Timer++;
                 return CanTime;
             });
        }

        public int Timer
        {
            get { return _timer; }
            set { Set(ref _timer, value); }
        }

        public bool CanTime
        {
            get { return _canTime; }
            set { Set(ref _canTime, value); }
        }

        //called from a 'start' button click
        private void StartTimer()
        {
            //App.Current.MainPage.DisplayAlert("error", "Not Implemnted.", "Ok");

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Timer++;
                return CanTime;
            });
        }

        //called from a 'cancel' button
        private void Cancel()
        {
        }
    }
}