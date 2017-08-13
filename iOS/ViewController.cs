using System;

using UIKit;
using Foundation;

namespace Whitelabeled.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            appIdLabel.Text = NSBundle.MainBundle.BundleIdentifier;
            environmentLabel.Text = MyService.GetEnvironment();
        }
    }
}
