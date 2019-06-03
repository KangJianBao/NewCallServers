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
            this.panelTop = new System.Windows.Forms.Panel();
            this.TopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopRoom = new System.Windows.Forms.Panel();
            this.panelTopRoomBg = new System.Windows.Forms.Panel();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.panelTopLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTopDateTime = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pancelBottom = new System.Windows.Forms.Panel();
            this.lblScrollPlay = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContentRight = new System.Windows.Forms.Panel();
            this.axPlayer1 = new AxAPlayer3Lib.AxPlayer();
            this.panelContentLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.spTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.TopTableLayout.SuspendLayout();
            this.panelTopRoom.SuspendLayout();
            this.panelTopRoomBg.SuspendLayout();
            this.panelTopLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopDateTime.SuspendLayout();
            this.pancelBottom.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelContentRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).BeginInit();
            this.panelContentLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.TopTableLayout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1354, 140);
            this.panelTop.TabIndex = 0;
            // 
            // TopTableLayout
            // 
            this.TopTableLayout.ColumnCount = 3;
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTableLayout.Controls.Add(this.panelTopRoom, 1, 0);
            this.TopTableLayout.Controls.Add(this.panelTopLogo, 0, 0);
            this.TopTableLayout.Controls.Add(this.panelTopDateTime, 2, 0);
            this.TopTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTableLayout.Location = new System.Drawing.Point(0, 0);
            this.TopTableLayout.Name = "TopTableLayout";
            this.TopTableLayout.RowCount = 1;
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayout.Size = new System.Drawing.Size(1354, 140);
            this.TopTableLayout.TabIndex = 0;
            // 
            // panelTopRoom
            // 
            this.panelTopRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTopRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTopRoom.Controls.Add(this.panelTopRoomBg);
            this.panelTopRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRoom.Location = new System.Drawing.Point(338, 0);
            this.panelTopRoom.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopRoom.Name = "panelTopRoom";
            this.panelTopRoom.Size = new System.Drawing.Size(677, 140);
            this.panelTopRoom.TabIndex = 1;
            // 
            // panelTopRoomBg
            // 
            this.panelTopRoomBg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopRoomBg.BackgroundImage = global::CallServers.Properties.Resources.title;
            this.panelTopRoomBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTopRoomBg.Controls.Add(this.lblRoomName);
            this.panelTopRoomBg.Location = new System.Drawing.Point(0, 0);
            this.panelTopRoomBg.Name = "panelTopRoomBg";
            this.panelTopRoomBg.Size = new System.Drawing.Size(671, 120);
            this.panelTopRoomBg.TabIndex = 0;
            // 
            // lblRoomName
            // 
            this.lblRoomName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomName.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRoomName.ForeColor = System.Drawing.Color.White;
            this.lblRoomName.Location = new System.Drawing.Point(41, 0);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(590, 120);
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "放 疗 科";
            this.lblRoomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTopLogo
            // 
            this.panelTopLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTopLogo.Controls.Add(this.pictureBox1);
            this.panelTopLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLogo.Location = new System.Drawing.Point(0, 0);
            this.panelTopLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopLogo.Name = "panelTopLogo";
            this.panelTopLogo.Size = new System.Drawing.Size(338, 140);
            this.panelTopLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CallServers.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(36, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTopDateTime
            // 
            this.panelTopDateTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTopDateTime.Controls.Add(this.lblTime);
            this.panelTopDateTime.Controls.Add(this.lblDate);
            this.panelTopDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopDateTime.Location = new System.Drawing.Point(1015, 0);
            this.panelTopDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.panelTopDateTime.Name = "panelTopDateTime";
            this.panelTopDateTime.Size = new System.Drawing.Size(339, 140);
            this.panelTopDateTime.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(3, 65);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(333, 64);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "时间";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.Location = new System.Drawing.Point(3, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(333, 60);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "时间";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pancelBottom
            // 
            this.pancelBottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pancelBottom.Controls.Add(this.lblScrollPlay);
            this.pancelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pancelBottom.Location = new System.Drawing.Point(0, 463);
            this.pancelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pancelBottom.Name = "pancelBottom";
            this.pancelBottom.Size = new System.Drawing.Size(1354, 60);
            this.pancelBottom.TabIndex = 1;
            // 
            // lblScrollPlay
            // 
            this.lblScrollPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScrollPlay.AutoSize = true;
            this.lblScrollPlay.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScrollPlay.Location = new System.Drawing.Point(611, 15);
            this.lblScrollPlay.Name = "lblScrollPlay";
            this.lblScrollPlay.Size = new System.Drawing.Size(309, 27);
            this.lblScrollPlay.TabIndex = 0;
            this.lblScrollPlay.Text = "北京大学人民医院放疗科";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContent.Controls.Add(this.panelContentRight);
            this.panelContent.Controls.Add(this.panelContentLeft);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 140);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1354, 323);
            this.panelContent.TabIndex = 2;
            // 
            // panelContentRight
            // 
            this.panelContentRight.Controls.Add(this.axPlayer1);
            this.panelContentRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentRight.Location = new System.Drawing.Point(500, 0);
            this.panelContentRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelContentRight.Name = "panelContentRight";
            this.panelContentRight.Size = new System.Drawing.Size(854, 323);
            this.panelContentRight.TabIndex = 1;
            // 
            // axPlayer1
            // 
            this.axPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPlayer1.Enabled = true;
            this.axPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer1.OcxState")));
            this.axPlayer1.Size = new System.Drawing.Size(854, 323);
            this.axPlayer1.TabIndex = 0;
            // 
            // panelContentLeft
            // 
            this.panelContentLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContentLeft.Controls.Add(this.panel1);
            this.panelContentLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContentLeft.Location = new System.Drawing.Point(0, 0);
            this.panelContentLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelContentLeft.Name = "panelContentLeft";
            this.panelContentLeft.Size = new System.Drawing.Size(500, 323);
            this.panelContentLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 323);
            this.panel1.TabIndex = 0;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // spTimer
            // 
            this.spTimer.Enabled = true;
            this.spTimer.Tick += new System.EventHandler(this.spTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前患者：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "准备患者：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "等待人数：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(243, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "张三";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(243, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "李四";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(243, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1354, 523);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.pancelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVideoPlayer";
            this.Text = "FrmVideoPlayer";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.TopTableLayout.ResumeLayout(false);
            this.panelTopRoom.ResumeLayout(false);
            this.panelTopRoomBg.ResumeLayout(false);
            this.panelTopLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopDateTime.ResumeLayout(false);
            this.pancelBottom.ResumeLayout(false);
            this.pancelBottom.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContentRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).EndInit();
            this.panelContentLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel pancelBottom;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel TopTableLayout;
        private System.Windows.Forms.Panel panelTopLogo;
        private System.Windows.Forms.Panel panelTopRoom;
        private System.Windows.Forms.Panel panelTopDateTime;
        private System.Windows.Forms.Panel panelTopRoomBg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Panel panelContentLeft;
        private System.Windows.Forms.Panel panelContentRight;
        private AxAPlayer3Lib.AxPlayer axPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScrollPlay;
        private System.Windows.Forms.Timer spTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}