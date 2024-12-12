using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace mypersianCalander
{
    public class myPersianCalander
    {
        PersianCalendar pc;
        public myPersianCalander()
        {
            pc = new PersianCalendar();
        }
        public int day() { return pc.GetDayOfMonth(DateTime.Now); }
        public int month() { return pc.GetMonth(DateTime.Now); }
        public int year() { return pc.GetYear(DateTime.Now); }
        public string date() { return year().ToString() + "/" + month().ToString() + "/" + day().ToString(); }
        public int getYear(string strDate) { return int.Parse(strDate.Substring(0, 4)); }
        public int getMonth(string strDate) { return int.Parse(strDate.Substring(5, 2)); }
        public int getDay(string strDate) { return int.Parse(strDate.Substring(8, 2)); }
    }
}
