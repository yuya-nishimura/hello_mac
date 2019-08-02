using System;

using AppKit;
using Foundation;

namespace Hello_Mac
{
    public partial class ViewController : NSViewController
    {
        private int numberOfTimesClicked = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
            ClickedLabel.StringValue = "ボタンはクリックされていません";
        }

        partial void ClickedButton(NSObject sender)
        {
            numberOfTimesClicked++;
            ClickedLabel.StringValue = $"{numberOfTimesClicked}回クリックされました";
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
