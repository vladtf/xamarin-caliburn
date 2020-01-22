using System.Threading.Tasks;
using Xamarin.Forms;
using XCMDEMO.Views;

namespace XCMDEMO
{
    public class SplashPage : ContentPage
    {
        private Image splashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "dog_splash.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
               AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#429de3");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            base.OnAppearing();

            MainView main = null;
            var task = Task.Run(() => main = new MainView());

            await splashImage.ScaleTo(1);

            //Task.Run(async () =>
            //{
            //    await splashImage.ScaleTo(1, 2000); //Time-consuming processes such as initialization
            //    await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            //    await splashImage.ScaleTo(0, 1200, Easing.Linear);
            //});

            await Task.Run(()=>task.Wait());
            Application.Current.MainPage = main; //After loading  MainPage it gets Navigated to our new Page

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;

            await DisplayAlert("Elapsed time till starting", elapsedMs.ToString(), "Ok");
        }
    }
}