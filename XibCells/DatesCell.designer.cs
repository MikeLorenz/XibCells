// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace XibCells
{
	partial class DatesCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel lblDay { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblDescription { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblMonth { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblWeekday { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblWeekday != null) {
				lblWeekday.Dispose ();
				lblWeekday = null;
			}

			if (lblMonth != null) {
				lblMonth.Dispose ();
				lblMonth = null;
			}

			if (lblDay != null) {
				lblDay.Dispose ();
				lblDay = null;
			}

			if (lblDescription != null) {
				lblDescription.Dispose ();
				lblDescription = null;
			}
		}
	}
}
