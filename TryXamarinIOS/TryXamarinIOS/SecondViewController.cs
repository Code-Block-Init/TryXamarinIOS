using System;

using UIKit;

namespace TryXamarinIOS
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void TestButton2_TouchUpInside(UIButton sender)
        {
            // Create a new Alert Controller
            UIAlertController actionSheetAlert = UIAlertController.Create("Action Sheet", "Select an item from below", UIAlertControllerStyle.ActionSheet);

            // Add Actions
            actionSheetAlert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item One pressed.")));

            actionSheetAlert.AddAction(UIAlertAction.Create("custom button 1", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item Two pressed.")));

            actionSheetAlert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Cancel button pressed.")));

            // Required for iPad - You must specify a source for the Action Sheet since it is
            // displayed as a popover
            UIPopoverPresentationController presentationPopover = actionSheetAlert.PopoverPresentationController;
            if (presentationPopover != null)
            {
                presentationPopover.SourceView = this.View;
                presentationPopover.PermittedArrowDirections = UIPopoverArrowDirection.Up;
            }

            // Display the alert
            this.PresentViewController(actionSheetAlert, true, null);
        }
    }
}

