﻿namespace A2_Courswork
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThemedParties = new System.Windows.Forms.Button();
            this.btnCatering = new System.Windows.Forms.Button();
            this.btnWeddings = new System.Windows.Forms.Button();
            this.tS = new System.Windows.Forms.ToolStrip();
            this.tSB = new System.Windows.Forms.ToolStripDropDownButton();
            this.tSBMM = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBMM1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBTP = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBC = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBW = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBTPP = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBTPP1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBTPP2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBAMM = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBAMM1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBAMM2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBBP = new System.Windows.Forms.ToolStripMenuItem();
            this.tSBVR = new System.Windows.Forms.ToolStripMenuItem();
            this.tS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(47, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Events Unlimited";
            // 
            // btnThemedParties
            // 
            this.btnThemedParties.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemedParties.Location = new System.Drawing.Point(12, 101);
            this.btnThemedParties.Name = "btnThemedParties";
            this.btnThemedParties.Size = new System.Drawing.Size(440, 100);
            this.btnThemedParties.TabIndex = 2;
            this.btnThemedParties.Text = "Themed Parties";
            this.btnThemedParties.UseVisualStyleBackColor = true;
            this.btnThemedParties.Click += new System.EventHandler(this.btnThemedParties_Click);
            // 
            // btnCatering
            // 
            this.btnCatering.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatering.Location = new System.Drawing.Point(12, 207);
            this.btnCatering.Name = "btnCatering";
            this.btnCatering.Size = new System.Drawing.Size(440, 100);
            this.btnCatering.TabIndex = 3;
            this.btnCatering.Text = "Catering";
            this.btnCatering.UseVisualStyleBackColor = true;
            // 
            // btnWeddings
            // 
            this.btnWeddings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeddings.Location = new System.Drawing.Point(12, 313);
            this.btnWeddings.Name = "btnWeddings";
            this.btnWeddings.Size = new System.Drawing.Size(440, 100);
            this.btnWeddings.TabIndex = 4;
            this.btnWeddings.Text = "Weddings";
            this.btnWeddings.UseVisualStyleBackColor = true;
            // 
            // tS
            // 
            this.tS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB});
            this.tS.Location = new System.Drawing.Point(0, 0);
            this.tS.Name = "tS";
            this.tS.Size = new System.Drawing.Size(462, 27);
            this.tS.TabIndex = 5;
            this.tS.Text = "toolStrip1";
            // 
            // tSB
            // 
            this.tSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBMM,
            this.tSBTPP,
            this.tSBAMM1});
            this.tSB.Image = ((System.Drawing.Image)(resources.GetObject("tSB.Image")));
            this.tSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB.Name = "tSB";
            this.tSB.Size = new System.Drawing.Size(34, 24);
            this.tSB.Text = "toolStripDropDownButton1";
            // 
            // tSBMM
            // 
            this.tSBMM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBMM1,
            this.toolStripMenuItem1,
            this.tSBTP,
            this.tSBC,
            this.tSBW});
            this.tSBMM.Name = "tSBMM";
            this.tSBMM.Size = new System.Drawing.Size(227, 26);
            this.tSBMM.Text = "Main Menu";
            // 
            // tSBMM1
            // 
            this.tSBMM1.Name = "tSBMM1";
            this.tSBMM1.Size = new System.Drawing.Size(186, 26);
            this.tSBMM1.Text = "Main Menu";
            this.tSBMM1.Click += new System.EventHandler(this.tSBMM1_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // tSBTP
            // 
            this.tSBTP.Name = "tSBTP";
            this.tSBTP.Size = new System.Drawing.Size(186, 26);
            this.tSBTP.Text = "Themed Parties";
            this.tSBTP.Click += new System.EventHandler(this.tSBTP_Click_1);
            // 
            // tSBC
            // 
            this.tSBC.Name = "tSBC";
            this.tSBC.Size = new System.Drawing.Size(186, 26);
            this.tSBC.Text = "Catering";
            // 
            // tSBW
            // 
            this.tSBW.Name = "tSBW";
            this.tSBW.Size = new System.Drawing.Size(186, 26);
            this.tSBW.Text = "Weddings";
            // 
            // tSBTPP
            // 
            this.tSBTPP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBTPP1,
            this.toolStripMenuItem2,
            this.tSBTPP2,
            this.tSBAMM});
            this.tSBTPP.Name = "tSBTPP";
            this.tSBTPP.Size = new System.Drawing.Size(227, 26);
            this.tSBTPP.Text = "Themed Parties";
            // 
            // tSBTPP1
            // 
            this.tSBTPP1.Name = "tSBTPP1";
            this.tSBTPP1.Size = new System.Drawing.Size(227, 26);
            this.tSBTPP1.Text = "Themed Parties";
            this.tSBTPP1.Click += new System.EventHandler(this.tSBTPP1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 6);
            // 
            // tSBTPP2
            // 
            this.tSBTPP2.Name = "tSBTPP2";
            this.tSBTPP2.Size = new System.Drawing.Size(227, 26);
            this.tSBTPP2.Text = "Themed Parties";
            // 
            // tSBAMM
            // 
            this.tSBAMM.Name = "tSBAMM";
            this.tSBAMM.Size = new System.Drawing.Size(227, 26);
            this.tSBAMM.Text = "Adult Murder Mystery";
            this.tSBAMM.Click += new System.EventHandler(this.tSBAMM_Click);
            // 
            // tSBAMM1
            // 
            this.tSBAMM1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBAMM2,
            this.toolStripMenuItem3,
            this.tSBBP,
            this.tSBVR});
            this.tSBAMM1.Name = "tSBAMM1";
            this.tSBAMM1.Size = new System.Drawing.Size(227, 26);
            this.tSBAMM1.Text = "Adult Murder Mystery";
            // 
            // tSBAMM2
            // 
            this.tSBAMM2.Name = "tSBAMM2";
            this.tSBAMM2.Size = new System.Drawing.Size(227, 26);
            this.tSBAMM2.Text = "Adult Murder Mystery";
            this.tSBAMM2.Click += new System.EventHandler(this.tSBAMM2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 6);
            // 
            // tSBBP
            // 
            this.tSBBP.Name = "tSBBP";
            this.tSBBP.Size = new System.Drawing.Size(227, 26);
            this.tSBBP.Text = "Book Party";
            // 
            // tSBVR
            // 
            this.tSBVR.Name = "tSBVR";
            this.tSBVR.Size = new System.Drawing.Size(227, 26);
            this.tSBVR.Text = "View Records";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 420);
            this.Controls.Add(this.tS);
            this.Controls.Add(this.btnWeddings);
            this.Controls.Add(this.btnCatering);
            this.Controls.Add(this.btnThemedParties);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tS.ResumeLayout(false);
            this.tS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThemedParties;
        private System.Windows.Forms.Button btnCatering;
        private System.Windows.Forms.Button btnWeddings;
        private System.Windows.Forms.ToolStrip tS;
        private System.Windows.Forms.ToolStripDropDownButton tSB;
        private System.Windows.Forms.ToolStripMenuItem tSBMM;
        private System.Windows.Forms.ToolStripMenuItem tSBMM1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tSBTP;
        private System.Windows.Forms.ToolStripMenuItem tSBC;
        private System.Windows.Forms.ToolStripMenuItem tSBW;
        private System.Windows.Forms.ToolStripMenuItem tSBTPP;
        private System.Windows.Forms.ToolStripMenuItem tSBTPP1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tSBTPP2;
        private System.Windows.Forms.ToolStripMenuItem tSBAMM;
        private System.Windows.Forms.ToolStripMenuItem tSBAMM1;
        private System.Windows.Forms.ToolStripMenuItem tSBAMM2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tSBBP;
        private System.Windows.Forms.ToolStripMenuItem tSBVR;
    }
}

