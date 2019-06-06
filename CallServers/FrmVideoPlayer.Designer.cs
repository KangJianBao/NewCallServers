namespace CallServers
{
    partial class FrmVideoPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVideoPlayer));
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutMainTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.LayoutDateTime = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.LayoutContent = new System.Windows.Forms.TableLayoutPanel();
            this.panelContentLeft = new System.Windows.Forms.Panel();
            this.LayoutContentLeft = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentPatientPanel = new System.Windows.Forms.Panel();
            this.CurrentPatientLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentPatient = new System.Windows.Forms.Label();
            this.NextPatientPanel = new System.Windows.Forms.Panel();
            this.NextPatientLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNextPatient = new System.Windows.Forms.Label();
            this.panelContentRight = new System.Windows.Forms.Panel();
            this.axPlayer1 = new AxAPlayer3Lib.AxPlayer();
            this.LayoutBottom = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.Noticetimer = new System.Windows.Forms.Timer(this.components);
            this.LayoutMain.SuspendLayout();
            this.LayoutMainTop.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            this.LayoutDateTime.SuspendLayout();
            this.LayoutContent.SuspendLayout();
            this.panelContentLeft.SuspendLayout();
            this.LayoutContentLeft.SuspendLayout();
            this.CurrentPatientPanel.SuspendLayout();
            this.CurrentPatientLayout.SuspendLayout();
            this.NextPatientPanel.SuspendLayout();
            this.NextPatientLayout.SuspendLayout();
            this.panelContentRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).BeginInit();
            this.LayoutBottom.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            this.LayoutMain.ColumnCount = 1;
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.Controls.Add(this.LayoutMainTop, 0, 0);
            this.LayoutMain.Controls.Add(this.LayoutContent, 0, 1);
            this.LayoutMain.Controls.Add(this.LayoutBottom, 0, 2);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(0, 0);
            this.LayoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.RowCount = 3;
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutMain.Size = new System.Drawing.Size(1655, 839);
            this.LayoutMain.TabIndex = 0;
            // 
            // LayoutMainTop
            // 
            this.LayoutMainTop.ColumnCount = 3;
            this.LayoutMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutMainTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutMainTop.Controls.Add(this.panelLogo, 0, 0);
            this.LayoutMainTop.Controls.Add(this.panelTitle, 1, 0);
            this.LayoutMainTop.Controls.Add(this.panelDateTime, 2, 0);
            this.LayoutMainTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMainTop.Location = new System.Drawing.Point(0, 0);
            this.LayoutMainTop.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutMainTop.Name = "LayoutMainTop";
            this.LayoutMainTop.RowCount = 1;
            this.LayoutMainTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMainTop.Size = new System.Drawing.Size(1655, 134);
            this.LayoutMainTop.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(413, 134);
            this.panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::CallServers.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.picLogo.Size = new System.Drawing.Size(413, 134);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.BackgroundImage = global::CallServers.Properties.Resources.title;
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(413, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(827, 134);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(50, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(729, 125);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "放疗科";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDateTime
            // 
            this.panelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.panelDateTime.Controls.Add(this.LayoutDateTime);
            this.panelDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDateTime.Location = new System.Drawing.Point(1240, 0);
            this.panelDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(415, 134);
            this.panelDateTime.TabIndex = 2;
            // 
            // LayoutDateTime
            // 
            this.LayoutDateTime.ColumnCount = 1;
            this.LayoutDateTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutDateTime.Controls.Add(this.lblDate, 0, 0);
            this.LayoutDateTime.Controls.Add(this.lblTime, 0, 2);
            this.LayoutDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutDateTime.Location = new System.Drawing.Point(0, 0);
            this.LayoutDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutDateTime.Name = "LayoutDateTime";
            this.LayoutDateTime.RowCount = 3;
            this.LayoutDateTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutDateTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LayoutDateTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutDateTime.Size = new System.Drawing.Size(415, 134);
            this.LayoutDateTime.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(409, 62);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "2019-06-02";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(3, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(409, 62);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "06:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LayoutContent
            // 
            this.LayoutContent.ColumnCount = 3;
            this.LayoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.LayoutContent.Controls.Add(this.panelContentLeft, 0, 1);
            this.LayoutContent.Controls.Add(this.panelContentRight, 2, 1);
            this.LayoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutContent.Location = new System.Drawing.Point(0, 134);
            this.LayoutContent.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutContent.Name = "LayoutContent";
            this.LayoutContent.RowCount = 2;
            this.LayoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutContent.Size = new System.Drawing.Size(1655, 620);
            this.LayoutContent.TabIndex = 1;
            // 
            // panelContentLeft
            // 
            this.panelContentLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(182)))));
            this.panelContentLeft.Controls.Add(this.LayoutContentLeft);
            this.panelContentLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentLeft.Location = new System.Drawing.Point(0, 20);
            this.panelContentLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelContentLeft.Name = "panelContentLeft";
            this.panelContentLeft.Size = new System.Drawing.Size(408, 600);
            this.panelContentLeft.TabIndex = 0;
            // 
            // LayoutContentLeft
            // 
            this.LayoutContentLeft.ColumnCount = 1;
            this.LayoutContentLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutContentLeft.Controls.Add(this.CurrentPatientPanel, 0, 1);
            this.LayoutContentLeft.Controls.Add(this.NextPatientPanel, 0, 2);
            this.LayoutContentLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutContentLeft.Location = new System.Drawing.Point(0, 0);
            this.LayoutContentLeft.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutContentLeft.Name = "LayoutContentLeft";
            this.LayoutContentLeft.RowCount = 5;
            this.LayoutContentLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutContentLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutContentLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutContentLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutContentLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LayoutContentLeft.Size = new System.Drawing.Size(408, 600);
            this.LayoutContentLeft.TabIndex = 0;
            // 
            // CurrentPatientPanel
            // 
            this.CurrentPatientPanel.Controls.Add(this.CurrentPatientLayout);
            this.CurrentPatientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentPatientPanel.Location = new System.Drawing.Point(0, 60);
            this.CurrentPatientPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentPatientPanel.Name = "CurrentPatientPanel";
            this.CurrentPatientPanel.Size = new System.Drawing.Size(408, 120);
            this.CurrentPatientPanel.TabIndex = 0;
            // 
            // CurrentPatientLayout
            // 
            this.CurrentPatientLayout.ColumnCount = 2;
            this.CurrentPatientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentPatientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentPatientLayout.Controls.Add(this.label2, 0, 0);
            this.CurrentPatientLayout.Controls.Add(this.lblCurrentPatient, 0, 1);
            this.CurrentPatientLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentPatientLayout.Location = new System.Drawing.Point(0, 0);
            this.CurrentPatientLayout.Name = "CurrentPatientLayout";
            this.CurrentPatientLayout.RowCount = 2;
            this.CurrentPatientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentPatientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CurrentPatientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CurrentPatientLayout.Size = new System.Drawing.Size(408, 120);
            this.CurrentPatientLayout.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.CurrentPatientLayout.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "正在治疗：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentPatient
            // 
            this.lblCurrentPatient.AutoSize = true;
            this.CurrentPatientLayout.SetColumnSpan(this.lblCurrentPatient, 2);
            this.lblCurrentPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentPatient.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentPatient.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPatient.Location = new System.Drawing.Point(3, 60);
            this.lblCurrentPatient.Name = "lblCurrentPatient";
            this.lblCurrentPatient.Size = new System.Drawing.Size(402, 60);
            this.lblCurrentPatient.TabIndex = 0;
            this.lblCurrentPatient.Text = "李四";
            this.lblCurrentPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NextPatientPanel
            // 
            this.NextPatientPanel.Controls.Add(this.NextPatientLayout);
            this.NextPatientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextPatientPanel.Location = new System.Drawing.Point(0, 180);
            this.NextPatientPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NextPatientPanel.Name = "NextPatientPanel";
            this.NextPatientPanel.Size = new System.Drawing.Size(408, 120);
            this.NextPatientPanel.TabIndex = 0;
            // 
            // NextPatientLayout
            // 
            this.NextPatientLayout.ColumnCount = 2;
            this.NextPatientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NextPatientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NextPatientLayout.Controls.Add(this.label3, 0, 0);
            this.NextPatientLayout.Controls.Add(this.lblNextPatient, 0, 1);
            this.NextPatientLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextPatientLayout.Location = new System.Drawing.Point(0, 0);
            this.NextPatientLayout.Name = "NextPatientLayout";
            this.NextPatientLayout.RowCount = 2;
            this.NextPatientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NextPatientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NextPatientLayout.Size = new System.Drawing.Size(408, 120);
            this.NextPatientLayout.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.NextPatientLayout.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "准备治疗：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNextPatient
            // 
            this.lblNextPatient.AutoSize = true;
            this.NextPatientLayout.SetColumnSpan(this.lblNextPatient, 2);
            this.lblNextPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNextPatient.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNextPatient.ForeColor = System.Drawing.Color.White;
            this.lblNextPatient.Location = new System.Drawing.Point(3, 60);
            this.lblNextPatient.Name = "lblNextPatient";
            this.lblNextPatient.Size = new System.Drawing.Size(402, 60);
            this.lblNextPatient.TabIndex = 0;
            this.lblNextPatient.Text = "张三";
            this.lblNextPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelContentRight
            // 
            this.panelContentRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContentRight.Controls.Add(this.axPlayer1);
            this.panelContentRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentRight.Location = new System.Drawing.Point(428, 20);
            this.panelContentRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelContentRight.Name = "panelContentRight";
            this.panelContentRight.Size = new System.Drawing.Size(1227, 600);
            this.panelContentRight.TabIndex = 1;
            // 
            // axPlayer1
            // 
            this.axPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPlayer1.Enabled = true;
            this.axPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer1.OcxState")));
            this.axPlayer1.Size = new System.Drawing.Size(1227, 600);
            this.axPlayer1.TabIndex = 0;
            // 
            // LayoutBottom
            // 
            this.LayoutBottom.ColumnCount = 1;
            this.LayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutBottom.Controls.Add(this.panelBottom, 0, 0);
            this.LayoutBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutBottom.Location = new System.Drawing.Point(0, 754);
            this.LayoutBottom.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutBottom.Name = "LayoutBottom";
            this.LayoutBottom.RowCount = 1;
            this.LayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutBottom.Size = new System.Drawing.Size(1655, 85);
            this.LayoutBottom.TabIndex = 2;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblNotice);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 0);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1655, 85);
            this.panelBottom.TabIndex = 0;
            // 
            // lblNotice
            // 
            this.lblNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNotice.Location = new System.Drawing.Point(1026, 19);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(624, 70);
            this.lblNotice.TabIndex = 0;
            this.lblNotice.Text = "北京大学人民医院放疗科";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Enabled = true;
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTimer_Tick);
            // 
            // Noticetimer
            // 
            this.Noticetimer.Enabled = true;
            this.Noticetimer.Tick += new System.EventHandler(this.Noticetimer_Tick);
            // 
            // FrmVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1655, 839);
            this.Controls.Add(this.LayoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVideoPlayer";
            this.Text = "FrmVideoPlayer";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LayoutMain.ResumeLayout(false);
            this.LayoutMainTop.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelDateTime.ResumeLayout(false);
            this.LayoutDateTime.ResumeLayout(false);
            this.LayoutContent.ResumeLayout(false);
            this.panelContentLeft.ResumeLayout(false);
            this.LayoutContentLeft.ResumeLayout(false);
            this.CurrentPatientPanel.ResumeLayout(false);
            this.CurrentPatientLayout.ResumeLayout(false);
            this.CurrentPatientLayout.PerformLayout();
            this.NextPatientPanel.ResumeLayout(false);
            this.NextPatientLayout.ResumeLayout(false);
            this.NextPatientLayout.PerformLayout();
            this.panelContentRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).EndInit();
            this.LayoutBottom.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        private System.Windows.Forms.TableLayoutPanel LayoutMainTop;
        private System.Windows.Forms.TableLayoutPanel LayoutContent;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Panel panelContentLeft;
        private System.Windows.Forms.Panel panelContentRight;
        private System.Windows.Forms.TableLayoutPanel LayoutBottom;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel LayoutDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private AxAPlayer3Lib.AxPlayer axPlayer1;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.TableLayoutPanel LayoutContentLeft;
        private System.Windows.Forms.Panel CurrentPatientPanel;
        private System.Windows.Forms.Panel NextPatientPanel;
        private System.Windows.Forms.TableLayoutPanel CurrentPatientLayout;
        private System.Windows.Forms.TableLayoutPanel NextPatientLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNextPatient;
        private System.Windows.Forms.Timer DateTimeTimer;
        private System.Windows.Forms.Timer Noticetimer;
    }
}