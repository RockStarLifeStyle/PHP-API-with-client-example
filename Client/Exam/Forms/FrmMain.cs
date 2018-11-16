using Exam.Core;
using Exam.Core.JsonObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam.Forms
{
    public partial class FrmMain : Form
    {
        HotelObject[] hotels = null;
        public FrmMain(string uname)
        {
            InitializeComponent();
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                GetHotels();
            });
            Text = uname;
        }

        private void GetHotels()
        {
            Network.GetHotels();
            this.Invoke(new Action(()=> 
            {
                if ((hotels = Network.GetHotels()) != null)
                {
                    foreach (HotelObject item in hotels)
                    {
                        lbHotels.Items.Add(item.hotelName);
                    }
                }
                else
                {
                    MessageBox.Show("You не авторизован");
                }
            }));
        }

        private void lbHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHotels.SelectedItems.Count > 0)
            {
                string name = lbHotels.SelectedItems[0].ToString();
                FrmHotel frmHotel = new FrmHotel(hotels.Where(h => h.hotelName == name).First());
                frmHotel.Show();
                this.Hide();
            }
        }
    }
}
