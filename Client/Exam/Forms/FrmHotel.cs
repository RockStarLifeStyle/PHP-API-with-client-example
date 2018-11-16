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
    public partial class FrmHotel : Form
    {
        CommentObject[] comments = null;
        HotelObject hotel = null;
        public FrmHotel(HotelObject hotel)
        {
            InitializeComponent();
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                SetHotelInfo(hotel);
            });
            this.hotel = hotel;
            Text = hotel.hotelName;
        }

        private void SetHotelInfo(HotelObject hotel)
        {
            this.Invoke(new Action(() =>
            {
                tbHotelName.Text = hotel.hotelName;
                tbCost.Text = hotel.cost.ToString();
                tbStars.Text = hotel.stars.ToString();
                tbCountry.Text = hotel.country;
                tbCity.Text = hotel.city;
                rtbInfo.Text = hotel.info;
                pictureBox1.Image = Image.FromFile(hotel.image);

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                if ((comments = Network.GetComments(hotel.id)) != null)
                {
                    foreach (CommentObject comment in comments)
                    {
                        lbComments.Items.Add($"{comment.user}: {comment.text}");
                    }
                }
            }));
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (tbComment.Text == "")
            {
                MessageBox.Show("Error");
                return;
            }
            Network.SetComment(tbComment.Text, hotel);
            lbComments.Items.Add($"{Text}: {tbComment.Text}");
        }
    }
}
