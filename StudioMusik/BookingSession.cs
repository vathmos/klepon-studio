using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioMusik
{
    public static class BookingSession
    {
        public static int BookingID { get; set; }
        public static string BandName { get; set; }
        public static string StudioName { get; set; }
        public static string ExtraInstruments { get; set; }
        public static string ExtraTools { get; set; }
        public static DateTime BookingDate { get; set; }
        public static decimal TotalCost { get; set; }
        public static int Duration { get; set; }

        public static void Clear()
        {
            BookingID = 0;
            BandName = null;
            StudioName = null;
            BookingDate = DateTime.MinValue;
            TotalCost = 0;
            ExtraInstruments = null;
            ExtraTools = null;
            Duration = 0;
        }
    }
}
