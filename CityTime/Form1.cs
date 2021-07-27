using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CityTime.Properties;

namespace CityTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaku_Click(object sender, EventArgs e)
        {
            lblTime.ForeColor = Color.White;
            timerLondon.Stop();
            timerBaku.Start();
            cityText.Text = "Baku";
            titleIcon.Image = Resources.icons8_azerbaijan_64;
            ActiveForm.BackgroundImage = Resources.baku_small;
            lblTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local,
                TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time")).ToString("HH:mm:ss");
        }

        private void btnLondon_Click(object sender, EventArgs e)
        {
            lblTime.ForeColor = Color.Black;
            timerBaku.Stop();
            timerLondon.Start();
            cityText.Text = "London";
            titleIcon.Image = Resources.icons8_united_kingdom_64;
            ActiveForm.BackgroundImage = Resources.london_small;
            lblTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local,
                TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")).ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local,
                TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time")).ToString("HH:mm:ss");
        }

        private void timerBaku_Tick(object sender, EventArgs e)
        {
            lblTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local,
                TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time")).ToString("HH:mm:ss");
        }

        private void timerLondon_Tick(object sender, EventArgs e)
        {
            lblTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local,
                TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")).ToString("HH:mm:ss");
        }
    }
}