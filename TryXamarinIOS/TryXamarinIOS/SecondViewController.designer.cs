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
    [Register ("SecondViewController")]
    partial class SecondViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TestButton2 { get; set; }

        [Action ("TestButton2_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TestButton2_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (TestButton2 != null) {
                TestButton2.Dispose ();
                TestButton2 = null;
            }
        }
    }
}