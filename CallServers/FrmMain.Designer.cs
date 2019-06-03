namespace CallServers
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnEndServices = new DSkin.Controls.DSkinButton();
            this.btnSatrtServices = new DSkin.Controls.DSkinButton();
            this.btnSet = new DSkin.Controls.DSkinButton();
            this.controlHost1 = new DSkin.Controls.ControlHost();
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dSkinLabel1 = new DSkin.Controls.DSkinLabel();
            this.controlHost1.SuspendLayout();
            this.dSkinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnEndServices
            // 
            this.btnEndServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnEndServices.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnEndServices.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnEndServices.ButtonBorderWidth = 1;
            this.btnEndServices.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEndServices.EffectColor = System.Drawing.Color.DimGray;
            this.btnEndServices.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEndServices.ForeColor = System.Drawing.Color.Black;
            this.btnEndServices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEndServices.HoverImage = null;
            this.btnEndServices.Image = global::CallServers.Properties.Resources.red;
            this.btnEndServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndServices.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnEndServices.Location = new System.Drawing.Point(129, 49);
            this.btnEndServices.Name = "btnEndServices";
            this.btnEndServices.NormalImage = null;
            this.btnEndServices.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnEndServices.PressedImage = null;
            this.btnEndServices.Radius = 4;
            this.btnEndServices.ShowButtonBorder = true;
            this.btnEndServices.Size = new System.Drawing.Size(99, 32);
            this.btnEndServices.TabIndex = 0;
            this.btnEndServices.Text = "停止服务";
            this.btnEndServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEndServices.TextPadding = 0;
            // 
            // btnSatrtServices
            // 
            this.btnSatrtServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnSatrtServices.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnSatrtServices.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnSatrtServices.ButtonBorderWidth = 1;
            this.btnSatrtServices.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSatrtServices.EffectColor = System.Drawing.Color.DimGray;
            this.btnSatrtServices.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSatrtServices.ForeColor = System.Drawing.Color.Black;
            this.btnSatrtServices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSatrtServices.HoverImage = null;
            this.btnSatrtServices.Image = global::CallServers.Properties.Resources.green;
            this.btnSatrtServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatrtServices.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnSatrtServices.Location = new System.Drawing.Point(24, 49);
            this.btnSatrtServices.Name = "btnSatrtServices";
            this.btnSatrtServices.NormalImage = null;
            this.btnSatrtServices.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnSatrtServices.PressedImage = null;
            this.btnSatrtServices.Radius = 4;
            this.btnSatrtServices.ShowButtonBorder = true;
            this.btnSatrtServices.Size = new System.Drawing.Size(99, 32);
            this.btnSatrtServices.TabIndex = 0;
            this.btnSatrtServices.Text = "开启服务";
            this.btnSatrtServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSatrtServices.TextPadding = 0;
            this.btnSatrtServices.Click += new System.EventHandler(this.btnSatrtServices_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnSet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.btnSet.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnSet.ButtonBorderWidth = 1;
            this.btnSet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSet.EffectColor = System.Drawing.Color.DimGray;
            this.btnSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.ForeColor = System.Drawing.Color.Black;
            this.btnSet.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSet.HoverImage = null;
            this.btnSet.Image = global::CallServers.Properties.Resources.btn_setting1;
            this.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSet.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnSet.Location = new System.Drawing.Point(234, 49);
            this.btnSet.Name = "btnSet";
            this.btnSet.NormalImage = null;
            this.btnSet.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnSet.PressedImage = null;
            this.btnSet.Radius = 4;
            this.btnSet.ShowButtonBorder = true;
            this.btnSet.Size = new System.Drawing.Size(99, 32);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "设置";
            this.btnSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSet.TextPadding = 0;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // controlHost1
            // 
            this.controlHost1.Controls.Add(this.dSkinPanel1);
            this.controlHost1.Location = new System.Drawing.Point(24, 97);
            this.controlHost1.Name = "controlHost1";
            this.controlHost1.Size = new System.Drawing.Size(515, 262);
            this.controlHost1.TabIndex = 1;
            this.controlHost1.Text = "controlHost1";
            this.controlHost1.TransparencyKey = System.Drawing.Color.Empty;
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Borders.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.dSkinPanel1.Borders.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.dSkinPanel1.Borders.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.dSkinPanel1.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.dSkinPanel1.Controls.Add(this.richTextBox1);
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPanel1.Location = new System.Drawing.Point(0, 0);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(515, 262);
            this.dSkinPanel1.TabIndex = 0;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(509, 256);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // dSkinLabel1
            // 
            this.dSkinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dSkinLabel1.Location = new System.Drawing.Point(404, 372);
            this.dSkinLabel1.Name = "dSkinLabel1";
            this.dSkinLabel1.Size = new System.Drawing.Size(140, 18);
            this.dSkinLabel1.TabIndex = 2;
            this.dSkinLabel1.Text = "北京大学人民医院放疗科";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(221)))));
            this.CaptionOffset = new System.Drawing.Point(5, 3);
            this.ClientSize = new System.Drawing.Size(563, 405);
            this.Controls.Add(this.dSkinLabel1);
            this.Controls.Add(this.controlHost1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnSatrtServices);
            this.Controls.Add(this.btnEndServices);
            this.DoubleClickMaximized = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconRectangle = new System.Drawing.Rectangle(5, 7, 16, 16);
            this.MaximizeBox = false;
            this.MinBox.ImageSize = new System.Drawing.Size(32, 0);
            this.MinBox.Size = new System.Drawing.Size(32, 30);
            this.Name = "FrmMain";
            this.Radius = 4;
            this.Text = "叫号服务端";
            this.controlHost1.ResumeLayout(false);
            this.dSkinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DSkin.Controls.DSkinButton btnEndServices;
        private DSkin.Controls.DSkinButton btnSatrtServices;
        private DSkin.Controls.DSkinButton btnSet;
        private DSkin.Controls.ControlHost controlHost1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinLabel dSkinLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

