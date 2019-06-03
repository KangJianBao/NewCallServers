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
    public partial class FrmMain : DSkinForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSatrtServices_Click(object sender, EventArgs e)
        {
            FrmVideoPlayer frmVideoPlayer = new FrmVideoPlayer();
            frmVideoPlayer.Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            FrmSet frmSet = new FrmSet();
            frmSet.ShowDialog();
        }
    }
}
