namespace WhatTimeIsIt_VisualStudio
{
    public partial class Form1 : Form
    {
        private TimeZoneService _timeZoneService;
        public Form1()
        {
            InitializeComponent();
            _timeZoneService = new TimeZoneService();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime1.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds1.Text = DateTime.Now.ToString("ss");
            lblDate1.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay1.Text = DateTime.Now.ToString("dddd");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void lblTime2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            var localDate = _timeZoneService.GetCurrentDateByTimeZone("Eastern Standard Time");

            lblTime2.Text = localDate.ToString("HH:mm");
            lblSeconds2.Text = localDate.ToString("ss");
            lblDate2.Text = localDate.ToString("MMM dd yyyy");
            lblDay2.Text = localDate.ToString("dddd");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var localDate = _timeZoneService.GetCurrentDateByTimeZone("China Standard Time");


            lblTime3.Text = localDate.ToString("HH:mm");
            lblSeconds3.Text = localDate.ToString("ss");
            lblDate3.Text = localDate.ToString("MMM dd yyyy");
            lblDay3.Text = localDate.ToString("dddd");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var localDate = _timeZoneService.GetCurrentDateByTimeZone("Tokyo Standard Time");


            lblTime4.Text = localDate.ToString("HH:mm");
            lblSeconds4.Text = localDate.ToString("ss");
            lblDate4.Text = localDate.ToString("MMM dd yyyy");
            lblDay4.Text = localDate.ToString("dddd");
        }
    }
}