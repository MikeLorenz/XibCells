using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.ObjCRuntime;

namespace XibCells
{
    public class Holiday
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Holiday(int year, int month, int day, string desc)
        {
            Date = new DateTime(year, month, day);
            Description = desc;
        }
    }

    public class DatesSource : UITableViewSource
    {
        List<Holiday> Holidays;

        public DatesSource()
        {
            Holidays = new List<Holiday> {
                new Holiday(2013,  1,  1, "New Year's Day"),
                new Holiday(2013,  2,  2, "Ground Hog's Day"),
                new Holiday(2013,  3, 15, "The Ides of March"),
                new Holiday(2013,  6, 14, "Flag Day"),
                new Holiday(2013,  7,  4, "Independence Day"),
                new Holiday(2013, 10, 31, "Halloween"),
                new Holiday(2013, 12, 25, "Christmas"),
            };
        }

        public override int NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override int RowsInSection(UITableView tableview, int section)
        {
            return Holidays.Count;
        }

        public override float GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 64;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(DatesCell.Key) as DatesCell;
            if (cell == null)
            {
                cell = new DatesCell();
                var views = NSBundle.MainBundle.LoadNib("Dates", cell, null);
                cell = Runtime.GetNSObject(views.ValueAt(0)) as DatesCell;
            }
			
            Holiday h = Holidays[indexPath.Row];
            cell.BindData(h);

            return cell;
        }
    }
}
