using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace PuppyCare.iOS
{
    public partial class HomePage : UIViewController
    {
        public HomePage (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			var tittle = new UILabel(new CGRect(0, 20, this.View.Frame.Width, 20))
			{
				Text = "Puppy",
				TextColor = UIColor.Black
			};

			this.View.AddSubview(tittle);
		}
    }
}