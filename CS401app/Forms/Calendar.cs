using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherApp.Forms
{
    public partial class Calendar : Form
    {
        //month and year value
        int month, year;

        //statict variables for month and year to pass to EventForm
        public static int static_month, static_year;



        public Calendar()
        {
            InitializeComponent();
        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
            //clear calender
            dayContainer.Controls.Clear();

            //increment to next month/year
            if (month + 1 > 12)
            {
                month = 1;
                year++;
            }
            else month++;

            displayDaysInfo();
        }

        private void PreviousBTN_Click(object sender, EventArgs e)
        {
            //clear calender
            dayContainer.Controls.Clear();

            //decrement to next month/year
            if (month - 1 < 1)
            {
                month = 12;
                year--;
            }
            else month--;

            displayDaysInfo();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;

            //set month and year
            month = now.Month;
            year = now.Year;

            displayDaysInfo();
        }

        private void displayDaysInfo() //get and display days info
        {
            //declare static variables for EventForm
            static_month = month;
            static_year = year;

            //show month and year 
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearLBL.Text = monthName + " " + year;

            //first day of month
            DateTime startofmonth = new DateTime(year, month, 1);

            //get number of days in month
            int days = DateTime.DaysInMonth(year, month);

            //start of month to int
            int dayofweek = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;

            //make a blank usercontrol
            for (int i = 1; i < dayofweek; i++)
            {
                CalendarControls.UserControlBlank ucblank = new CalendarControls.UserControlBlank();
                dayContainer.Controls.Add(ucblank);
            }

            //user control for days
            for (int i = 1; i <= days; i++)
            {
                CalendarControls.UserControlDay ucdays = new CalendarControls.UserControlDay();
                ucdays.days(i);
                dayContainer.Controls.Add(ucdays);

            }
        }
    }
}
