using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSkin;
using DSkin.Forms;


namespace CallServers
{
    public partial class FrmVideoPlayer : Form
    {
        public FrmVideoPlayer()
        {
            InitializeComponent();
            InitDateTime();//初始化日期时间显示
            lblScrollPlay.Left = this.Width;//将滚动公告位置设置到最右边
            axPlayer1.SetCustomLogo(-1);//设置播放器的Logo
            axPlayer1.SetConfig(37, Application.StartupPath + @"\APlayerLogo.bmp");
        }

        void InitDateTime()
        {
            string hour = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            string year = DateTime.Now.Year.ToString();
            string mouth = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();

            lblDate.Text = year + "-" + mouth + "-" + day;
            lblTime.Text = hour + ":" + minute + ":" + second;

        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            InitDateTime();
        }

        private void spTimer_Tick(object sender, EventArgs e)
        {
            lblScrollPlay.Left -= 5;
            if (lblScrollPlay.Right < 0)
            {
                lblScrollPlay.Left = this.Width;
            }
        }
    }
}
