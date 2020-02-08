using Xamarin.Forms;

namespace XCMDEMO.TriggersAction
{
    public class BindViewTriggerAction : TriggerAction<Button>
    {
        protected async override void Invoke(Button button)
        {
            var initButton = button.BackgroundColor;

            button.BackgroundColor = Color.Red;
            await button.ScaleTo(0.5, 50, Easing.CubicOut);

            await button.FadeTo(0, 1000, Easing.SinIn);

            await button.FadeTo(1, 1000, Easing.SinIn);

            var animation = new Animation(callback: d => button.RotationX = d,
                                  start: button.RotationX,
                                  end: button.RotationX + 720,
                                  easing: Easing.SpringOut);
            animation.Commit(button, "Circle", length: 800);

            await button.ScaleTo(1, 50, Easing.CubicIn);

            button.BackgroundColor = initButton;
        }
    }
}