using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSkin.Forms;

namespace CallServers
{
    public partial class FrmSet : DSkinForm
    {
        public FrmSet()
        {
            InitializeComponent();
            lblCurrentRateValue.Text = RateTrackBar.Value.ToString();
            lblCurrentVoiceValue.Text = VoiceTrackBar.Value.ToString();
        }

       

        private void VoiceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lblCurrentVoiceValue.Text = VoiceTrackBar.Value.ToString();
        }

        private void RateTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lblCurrentRateValue.Text = RateTrackBar.Value.ToString();
        }

       
    }
}
