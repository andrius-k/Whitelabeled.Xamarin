using Android.App;
using Android.Widget;
using Android.OS;

namespace Whitelabeled.Droid
{
    [Activity(Label = "Whitelabeled", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            FindViewById<TextView>(Resource.Id.appIdTextView).Text = PackageName;
            FindViewById<TextView>(Resource.Id.environmentTextView).Text = MyService.GetEnvironment();
        }
    }
}

