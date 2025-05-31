using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioMusik
{
    public partial class StrukPembayaran : Form
    {
        public StrukPembayaran()
        {
            InitializeComponent();
        }
        public void PrintBookingReceipt(RichTextBox rtb)
        {
            rtb.Clear();

            // Pisah StudioName dan harga studio
            string studioName = BookingSession.StudioName;
            string studioPrice = "";

            if (!string.IsNullOrEmpty(studioName) && studioName.Contains("-"))
            {
                var parts = studioName.Split('-');
                studioName = parts[0].Trim();
                studioPrice = parts[parts.Length - 1].Trim();
            }

            rtb.AppendText("======================================\n");
            rtb.AppendText($"ID Booking      : {BookingSession.BookingID}\n");
            rtb.AppendText($"Nama Band       : {BookingSession.BandName}\n");
            rtb.AppendText($"Nama Studio     : {studioName}\n");
            if (!string.IsNullOrEmpty(studioPrice))
                rtb.AppendText($"Harga Studio    : {studioPrice}\n");
            rtb.AppendText($"Tanggal Booking : {BookingSession.BookingDate:dd MMMM yyyy}\n");
            rtb.AppendText($"Durasi          : {BookingSession.Duration}\n");
            rtb.AppendText("======================================\n");

            rtb.AppendText("Alat Musik Tambahan:\n");
            var alatList = BookingSession.ExtraInstruments.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var alat in alatList)
            {
                rtb.AppendText($" - {String.Join("\t", alat.Trim().Split('-'))}\n");
            }

            rtb.AppendText("--------------------------------------\n");

            rtb.AppendText("Aksesoris Tambahan:\n");
            var aksesorisList = BookingSession.ExtraTools.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var aks in aksesorisList)
            {
                rtb.AppendText($" - {String.Join("\t", aks.Trim().Split('-'))}\n");

            }

            rtb.AppendText("======================================\n");
            rtb.AppendText($"Total Biaya   : Rp {BookingSession.TotalCost:N0}\n");
            rtb.AppendText("======================================\n");
        }

        SqlConnection conn = DatabaseHelper.GetConnection();

        private void StrukPembayaran_Load(object sender, EventArgs e)
        {
            PrintBookingReceipt(richTextBox1);
        }
    }
}
