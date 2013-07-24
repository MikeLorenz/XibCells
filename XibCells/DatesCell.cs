using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XibCells
{
    [Register("DatesCell")]
    public partial class DatesCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("DatesCell");

        public DatesCell(IntPtr handle) : base(handle) {}

        public DatesCell() : base (UITableViewCellStyle.Value1, Key) {}

        public void BindData(Holiday h)
        {
            lblWeekday.Text = h.Date.ToString("ddd");
            lblMonth.Text = h.Date.ToString("MMM");
            lblDay.Text = h.Date.Day.ToString();
            lblDescription.Text = h.Description;
        }
    }
}
