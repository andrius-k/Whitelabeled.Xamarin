// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Whitelabeled.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel appIdLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel environmentLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (appIdLabel != null) {
                appIdLabel.Dispose ();
                appIdLabel = null;
            }

            if (environmentLabel != null) {
                environmentLabel.Dispose ();
                environmentLabel = null;
            }
        }
    }
}