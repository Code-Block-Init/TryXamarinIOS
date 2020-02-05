// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TryXamarinIOS
{
    [Register ("FirstViewController")]
    partial class FirstViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TestButton1 { get; set; }

        [Action ("TestButton1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TestButton1_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (TestButton1 != null) {
                TestButton1.Dispose ();
                TestButton1 = null;
            }
        }
    }
}