using CallServersCommon;
using CallServersModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CallServers
{
    public partial class FrmVideoPlayer : Form
    {
        private ConfigInfo.SpeechInfo objSpeechInfo = new ConfigInfo.SpeechInfo();
        private ConfigInfo.APlayerInfo objAPlayerInfo = new ConfigInfo.APlayerInfo();
        private ConfigInfo.CurrentPatientViewInfo objCurrentPatientViewInfo = new ConfigInfo.CurrentPatientViewInfo();
        private ConfigInfo.NextPatientViewInfo objNextPatientViewInfo = new ConfigInfo.NextPatientViewInfo();
        private ConfigInfo.TitleViewInfo objTitleViewInfo = new ConfigInfo.TitleViewInfo();

        public FrmVideoPlayer()
        {
            InitializeComponent();
            InitConfig();
            axPlayer1.SetConfig(37, Application.StartupPath + "\\" +objAPlayerInfo.Logo );
            lblNotice.Left = this.Width;
        }
        private void InitConfig()
        {
            string path = Application.StartupPath + "\\config.ini";
            IniHelper iniHelper = new IniHelper(path);
            //初始化语音
            objSpeechInfo.SelectVoice = iniHelper.IniReadValue("Speech", "SelectVoice");
            objSpeechInfo.Value = iniHelper.IniReadValue("Speech", "Value");
            objSpeechInfo.Rate = iniHelper.IniReadValue("Speech", "Rate");
            //初始化视频
            objAPlayerInfo.FilePath = iniHelper.IniReadValue("APlayer", "FilePath");
            objAPlayerInfo.Logo = iniHelper.IniReadValue("APlayer", "Logo");
            //objConfigInfo.APlayerFilePath = iniHelper.IniReadValue("APlayer", "FilePath");
            //MessageBox.Show(objConfigInfo.ServerIP + "-" + objConfigInfo.ServerPort + "-" + objConfigInfo.SelectVoice);
        }
        /// <summary>
        /// 初始化日期时间
        /// </summary>
        void InitDateTime()
        {
            string hour = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            string year = DateTime.Now.Year.ToString();
            string mouth = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();

            lblTime.Text = hour + ":" + minute + ":" + second;
            lblDate.Text = year + "-" + mouth + "-" + day;
        }

        /// <summary>
        /// 实时刷新日期时间数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            string hour = DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString();
            string year = DateTime.Now.Year.ToString();
            string mouth = DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();

            //string a = 条件？true:false;
            lblTime.Text = hour + ":" + minute + ":" + second;
            lblDate.Text = year + "-" + mouth + "-" + day;
        }

        /// <summary>
        /// 滚动公告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Noticetimer_Tick(object sender, EventArgs e)
        {
            lblNotice.Left -= 5;
            if (lblNotice.Right < 0)
            {
                lblNotice.Left = this.Width;
            }
        }
            
        /// <summary>
        /// 扩展屏显示
        /// </summary>
        private void ShowExpansionScreen()
        {
            this.Left = Screen.PrimaryScreen.Bounds.Width;
            this.Top = 0;
        }
    }
}
