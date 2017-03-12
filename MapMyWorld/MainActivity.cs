using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace MapMyWorld
{
    [Activity(Label = "MapMyWorld", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation = ScreenOrientation.Landscape)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

