﻿namespace CodeJamA2018
{
    partial class UserPage
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
            this.lblNom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblXp = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblAnciennete = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.panHeaderBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panGainsXP = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panHeader.SuspendLayout();
            this.panHeaderBody.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNom.Location = new System.Drawing.Point(10, 10);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(39, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "lblNom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CodeJamA2018.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblXp.Location = new System.Drawing.Point(10, 23);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(30, 13);
            this.lblXp.TabIndex = 4;
            this.lblXp.Text = "lblXp";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLevel.Location = new System.Drawing.Point(10, 36);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(43, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "lblLevel";
            // 
            // lblAnciennete
            // 
            this.lblAnciennete.AutoSize = true;
            this.lblAnciennete.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAnciennete.Location = new System.Drawing.Point(10, 49);
            this.lblAnciennete.Name = "lblAnciennete";
            this.lblAnciennete.Size = new System.Drawing.Size(71, 13);
            this.lblAnciennete.TabIndex = 6;
            this.lblAnciennete.Text = "lblAnciennete";
            // 
            // panHeader
            // 
            this.panHeader.Controls.Add(this.panHeaderBody);
            this.panHeader.Controls.Add(this.pictureBox1);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panHeader.Size = new System.Drawing.Size(800, 133);
            this.panHeader.TabIndex = 7;
            // 
            // panHeaderBody
            // 
            this.panHeaderBody.Controls.Add(this.lblAnciennete);
            this.panHeaderBody.Controls.Add(this.lblLevel);
            this.panHeaderBody.Controls.Add(this.lblXp);
            this.panHeaderBody.Controls.Add(this.lblNom);
            this.panHeaderBody.Dock = System.Windows.Forms.DockStyle.Left;
            this.panHeaderBody.Location = new System.Drawing.Point(122, 0);
            this.panHeaderBody.Name = "panHeaderBody";
            this.panHeaderBody.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.panHeaderBody.Size = new System.Drawing.Size(200, 133);
            this.panHeaderBody.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 114);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "NomBadge";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CodeJamA2018.Properties.Resources.user;
            this.pictureBox6.Location = new System.Drawing.Point(128, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(84, 76);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "NomBadge";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CodeJamA2018.Properties.Resources.user;
            this.pictureBox5.Location = new System.Drawing.Point(244, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "NomBadge";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CodeJamA2018.Properties.Resources.user;
            this.pictureBox4.Location = new System.Drawing.Point(476, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "NomBadge";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CodeJamA2018.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(360, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NomBadge";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CodeJamA2018.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panGainsXP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 9;
            // 
            // panGainsXP
            // 
            this.panGainsXP.Dock = System.Windows.Forms.DockStyle.Left;
            this.panGainsXP.Location = new System.Drawing.Point(0, 0);
            this.panGainsXP.Name = "panGainsXP";
            this.panGainsXP.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panGainsXP.Size = new System.Drawing.Size(200, 100);
            this.panGainsXP.TabIndex = 0;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panHeader);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPage_FormClosed);
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeaderBody.ResumeLayout(false);
            this.panHeaderBody.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblAnciennete;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panHeaderBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panGainsXP;
    }
}