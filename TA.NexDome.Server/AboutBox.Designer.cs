﻿namespace TA.NexDome.Server
{
    partial class AboutBox
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
            System.Windows.Forms.Label DriverVersionLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.LogoBanner = new System.Windows.Forms.PictureBox();
            this.TigraLogo = new System.Windows.Forms.PictureBox();
            this.OkCommand = new System.Windows.Forms.Button();
            this.DriverVersion = new System.Windows.Forms.Label();
            this.InformationalVersion = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            DriverVersionLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TigraLogo)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DriverVersionLabel
            // 
            DriverVersionLabel.AutoSize = true;
            DriverVersionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DriverVersionLabel.Location = new System.Drawing.Point(8, 640);
            DriverVersionLabel.Name = "DriverVersionLabel";
            DriverVersionLabel.Size = new System.Drawing.Size(111, 21);
            DriverVersionLabel.TabIndex = 5;
            DriverVersionLabel.Text = "Build Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(8, 661);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 21);
            label3.TabIndex = 11;
            label3.Text = "Product Version";
            // 
            // LogoBanner
            // 
            this.LogoBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoBanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBanner.Image = ((System.Drawing.Image)(resources.GetObject("LogoBanner.Image")));
            this.LogoBanner.Location = new System.Drawing.Point(0, 0);
            this.LogoBanner.Name = "LogoBanner";
            this.LogoBanner.Size = new System.Drawing.Size(1002, 254);
            this.LogoBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBanner.TabIndex = 1;
            this.LogoBanner.TabStop = false;
            this.LogoBanner.Tag = "http://www.geminitelescope.com/";
            this.LogoBanner.Click += new System.EventHandler(this.NavigateToWebPage);
            // 
            // TigraLogo
            // 
            this.TigraLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TigraLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TigraLogo.Image = global::TA.NexDome.Server.Properties.Resources.TigraAstronomyLogo;
            this.TigraLogo.Location = new System.Drawing.Point(767, 3);
            this.TigraLogo.Name = "TigraLogo";
            this.TigraLogo.Size = new System.Drawing.Size(200, 200);
            this.TigraLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TigraLogo.TabIndex = 0;
            this.TigraLogo.TabStop = false;
            this.TigraLogo.Tag = "http://tigra-astronomy.com";
            this.TigraLogo.Click += new System.EventHandler(this.NavigateToWebPage);
            // 
            // OkCommand
            // 
            this.OkCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OkCommand.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkCommand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkCommand.Location = new System.Drawing.Point(805, 703);
            this.OkCommand.Name = "OkCommand";
            this.OkCommand.Size = new System.Drawing.Size(185, 29);
            this.OkCommand.TabIndex = 2;
            this.OkCommand.Text = "OK";
            this.OkCommand.UseVisualStyleBackColor = true;
            this.OkCommand.Click += new System.EventHandler(this.OkCommand_Click);
            // 
            // DriverVersion
            // 
            this.DriverVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverVersion.AutoSize = true;
            this.DriverVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverVersion.Location = new System.Drawing.Point(149, 640);
            this.DriverVersion.Name = "DriverVersion";
            this.DriverVersion.Size = new System.Drawing.Size(60, 21);
            this.DriverVersion.TabIndex = 5;
            this.DriverVersion.Text = "(unset)";
            this.DriverVersion.Click += new System.EventHandler(this.DriverVersion_Click);
            // 
            // InformationalVersion
            // 
            this.InformationalVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationalVersion.AutoSize = true;
            this.InformationalVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationalVersion.Location = new System.Drawing.Point(151, 661);
            this.InformationalVersion.Name = "InformationalVersion";
            this.InformationalVersion.Size = new System.Drawing.Size(60, 21);
            this.InformationalVersion.TabIndex = 10;
            this.InformationalVersion.Text = "(unset)";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 260);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(978, 377);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TA.NexDome.Server.Properties.Resources.NexDome;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.TigraLogo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(970, 206);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(758, 195);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "ASCOM Multi-instance Server Professionally produced by";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(752, 79);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tigra Astronomy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(752, 58);
            this.label4.TabIndex = 10;
            this.label4.Text = "We are available for hire to create your ASCOM driver, firmware, or application";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(3, 174);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(752, 21);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://tigra-astronomy.com";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1002, 748);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.InformationalVersion);
            this.Controls.Add(label3);
            this.Controls.Add(this.DriverVersion);
            this.Controls.Add(DriverVersionLabel);
            this.Controls.Add(this.OkCommand);
            this.Controls.Add(this.LogoBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutBox";
            this.Text = "About this software";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TigraLogo)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LogoBanner;
        private System.Windows.Forms.PictureBox TigraLogo;
        private System.Windows.Forms.Button OkCommand;
        private System.Windows.Forms.Label DriverVersion;
        private System.Windows.Forms.Label InformationalVersion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        }
}