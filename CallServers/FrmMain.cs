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
using CallServersCommon;
using CallServersModel;


namespace CallServers
{
    public partial class FrmMain : DSkinForm
    {
        private ConfigInfo.ServerInfo objServerInfo = new ConfigInfo.ServerInfo();
       
        public FrmMain()
        {
            InitializeComponent();
            InitConfig();
        }
        private void InitConfig()
        {
            string path = Application.StartupPath + "\\config.ini";
            IniHelper iniHelper = new IniHelper(path);
            //初始化服务器配置
            objServerInfo.ServerIP = iniHelper.IniReadValue("Server", "ServerIp");
            objServerInfo.ServerPort = iniHelper.IniReadValue("Server", "ServerPort");

            
        }
        private void btnSatrtServices_Click(object sender, EventArgs e)
        {
            FrmVideoPlayer videoPlayer = new FrmVideoPlayer();
            videoPlayer.Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            FrmSet frmSet = new FrmSet();
            frmSet.ShowDialog();
        }
    }
}
