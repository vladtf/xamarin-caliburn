using Xamarin.Forms;

namespace XCMDEMO.TriggersAction
{
    public class ExpandButtonTriggerAction : TriggerAction<Button>
    {
        protected async override void Invoke(Button button)
        {
            var initColor = button.BackgroundColor;

            button.BackgroundColor = Color.Red;
            await button.ScaleTo(0.5, 50, Easing.CubicOut);
            await button.ScaleTo(1, 50, Easing.CubicIn);

            button.BackgroundColor = initColor;
        }
    }

}
