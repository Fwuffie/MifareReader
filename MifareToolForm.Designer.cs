
namespace MifareReader
{
	partial class MifareToolForm
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
			this.cmdConnectScanner = new System.Windows.Forms.Button();
			this.cmbScanners = new System.Windows.Forms.ComboBox();
			this.lblCardPresence = new System.Windows.Forms.Label();
			this.lblCardInfo = new System.Windows.Forms.Label();
			this.cmbSector = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKeyALoad = new System.Windows.Forms.TextBox();
			this.txtKeyBLoad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdLoadCard = new System.Windows.Forms.Button();
			this.txtBlk0 = new System.Windows.Forms.TextBox();
			this.txtBlk1 = new System.Windows.Forms.TextBox();
			this.txtBlk2 = new System.Windows.Forms.TextBox();
			this.txtKeyA = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtKeyB = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.grpLoadSector = new System.Windows.Forms.GroupBox();
			this.lblSectorNum = new System.Windows.Forms.Label();
			this.grpLoadSector.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdConnectScanner
			// 
			this.cmdConnectScanner.Location = new System.Drawing.Point(374, 13);
			this.cmdConnectScanner.Name = "cmdConnectScanner";
			this.cmdConnectScanner.Size = new System.Drawing.Size(192, 23);
			this.cmdConnectScanner.TabIndex = 0;
			this.cmdConnectScanner.Text = "Connect";
			this.cmdConnectScanner.UseVisualStyleBackColor = true;
			this.cmdConnectScanner.Click += new System.EventHandler(this.cmdConnectScanner_Click);
			// 
			// cmbScanners
			// 
			this.cmbScanners.FormattingEnabled = true;
			this.cmbScanners.Location = new System.Drawing.Point(12, 13);
			this.cmbScanners.Name = "cmbScanners";
			this.cmbScanners.Size = new System.Drawing.Size(356, 21);
			this.cmbScanners.TabIndex = 1;
			this.cmbScanners.Text = "Select A Scanner...";
			// 
			// lblCardPresence
			// 
			this.lblCardPresence.AutoSize = true;
			this.lblCardPresence.Location = new System.Drawing.Point(410, 39);
			this.lblCardPresence.Name = "lblCardPresence";
			this.lblCardPresence.Size = new System.Drawing.Size(116, 13);
			this.lblCardPresence.TabIndex = 2;
			this.lblCardPresence.Text = "Scanner Disconnected";
			// 
			// lblCardInfo
			// 
			this.lblCardInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblCardInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCardInfo.Location = new System.Drawing.Point(374, 61);
			this.lblCardInfo.Name = "lblCardInfo";
			this.lblCardInfo.Size = new System.Drawing.Size(192, 83);
			this.lblCardInfo.TabIndex = 3;
			this.lblCardInfo.Text = "Card Info:";
			// 
			// cmbSector
			// 
			this.cmbSector.FormattingEnabled = true;
			this.cmbSector.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
			this.cmbSector.Location = new System.Drawing.Point(80, 19);
			this.cmbSector.Name = "cmbSector";
			this.cmbSector.Size = new System.Drawing.Size(67, 21);
			this.cmbSector.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Load Sector:";
			// 
			// txtKeyALoad
			// 
			this.txtKeyALoad.Location = new System.Drawing.Point(47, 46);
			this.txtKeyALoad.Name = "txtKeyALoad";
			this.txtKeyALoad.Size = new System.Drawing.Size(100, 20);
			this.txtKeyALoad.TabIndex = 6;
			this.txtKeyALoad.Text = "FFFFFFFFFFFF";
			this.txtKeyALoad.Leave += new System.EventHandler(this.ValidateKey);
			// 
			// txtKeyBLoad
			// 
			this.txtKeyBLoad.Location = new System.Drawing.Point(47, 72);
			this.txtKeyBLoad.Name = "txtKeyBLoad";
			this.txtKeyBLoad.Size = new System.Drawing.Size(100, 20);
			this.txtKeyBLoad.TabIndex = 7;
			this.txtKeyBLoad.Text = "FFFFFFFFFFFF";
			this.txtKeyBLoad.Leave += new System.EventHandler(this.ValidateKey);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Key A";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Key B";
			// 
			// cmdLoadCard
			// 
			this.cmdLoadCard.Location = new System.Drawing.Point(47, 98);
			this.cmdLoadCard.Name = "cmdLoadCard";
			this.cmdLoadCard.Size = new System.Drawing.Size(75, 23);
			this.cmdLoadCard.TabIndex = 10;
			this.cmdLoadCard.Text = "Load";
			this.cmdLoadCard.UseVisualStyleBackColor = false;
			this.cmdLoadCard.Click += new System.EventHandler(this.loadSector);
			// 
			// txtBlk0
			// 
			this.txtBlk0.Location = new System.Drawing.Point(128, 355);
			this.txtBlk0.Name = "txtBlk0";
			this.txtBlk0.Size = new System.Drawing.Size(284, 20);
			this.txtBlk0.TabIndex = 11;
			// 
			// txtBlk1
			// 
			this.txtBlk1.Location = new System.Drawing.Point(128, 381);
			this.txtBlk1.Name = "txtBlk1";
			this.txtBlk1.Size = new System.Drawing.Size(284, 20);
			this.txtBlk1.TabIndex = 12;
			// 
			// txtBlk2
			// 
			this.txtBlk2.Location = new System.Drawing.Point(128, 407);
			this.txtBlk2.Name = "txtBlk2";
			this.txtBlk2.Size = new System.Drawing.Size(284, 20);
			this.txtBlk2.TabIndex = 13;
			// 
			// txtKeyA
			// 
			this.txtKeyA.Location = new System.Drawing.Point(128, 433);
			this.txtKeyA.Name = "txtKeyA";
			this.txtKeyA.Size = new System.Drawing.Size(97, 20);
			this.txtKeyA.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(79, 358);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Block 0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(79, 384);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Block 1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(79, 410);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Block 2";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(87, 436);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Key A";
			// 
			// txtKeyB
			// 
			this.txtKeyB.Location = new System.Drawing.Point(315, 433);
			this.txtKeyB.Name = "txtKeyB";
			this.txtKeyB.Size = new System.Drawing.Size(97, 20);
			this.txtKeyB.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(274, 436);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Key B";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(315, 459);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(97, 23);
			this.button2.TabIndex = 22;
			this.button2.Text = "Write To Card";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.writeSector);
			// 
			// grpLoadSector
			// 
			this.grpLoadSector.Controls.Add(this.cmbSector);
			this.grpLoadSector.Controls.Add(this.label1);
			this.grpLoadSector.Controls.Add(this.txtKeyALoad);
			this.grpLoadSector.Controls.Add(this.txtKeyBLoad);
			this.grpLoadSector.Controls.Add(this.label2);
			this.grpLoadSector.Controls.Add(this.label3);
			this.grpLoadSector.Controls.Add(this.cmdLoadCard);
			this.grpLoadSector.Location = new System.Drawing.Point(392, 147);
			this.grpLoadSector.Name = "grpLoadSector";
			this.grpLoadSector.Size = new System.Drawing.Size(165, 134);
			this.grpLoadSector.TabIndex = 23;
			this.grpLoadSector.TabStop = false;
			this.grpLoadSector.Text = "Load Sector From Card";
			// 
			// lblSectorNum
			// 
			this.lblSectorNum.AutoSize = true;
			this.lblSectorNum.Location = new System.Drawing.Point(239, 339);
			this.lblSectorNum.Name = "lblSectorNum";
			this.lblSectorNum.Size = new System.Drawing.Size(47, 13);
			this.lblSectorNum.TabIndex = 24;
			this.lblSectorNum.Text = "Sector 0";
			// 
			// MifareToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 586);
			this.Controls.Add(this.lblSectorNum);
			this.Controls.Add(this.grpLoadSector);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtKeyB);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtKeyA);
			this.Controls.Add(this.txtBlk2);
			this.Controls.Add(this.txtBlk1);
			this.Controls.Add(this.txtBlk0);
			this.Controls.Add(this.lblCardInfo);
			this.Controls.Add(this.lblCardPresence);
			this.Controls.Add(this.cmbScanners);
			this.Controls.Add(this.cmdConnectScanner);
			this.Name = "MifareToolForm";
			this.Text = "Mifare Tool";
			this.grpLoadSector.ResumeLayout(false);
			this.grpLoadSector.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdConnectScanner;
		private System.Windows.Forms.ComboBox cmbScanners;
		private System.Windows.Forms.Label lblCardPresence;
		private System.Windows.Forms.Label lblCardInfo;
		private System.Windows.Forms.ComboBox cmbSector;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKeyALoad;
		private System.Windows.Forms.TextBox txtKeyBLoad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdLoadCard;
		private System.Windows.Forms.TextBox txtBlk0;
		private System.Windows.Forms.TextBox txtBlk1;
		private System.Windows.Forms.TextBox txtBlk2;
		private System.Windows.Forms.TextBox txtKeyA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtKeyB;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox grpLoadSector;
		private System.Windows.Forms.Label lblSectorNum;
	}
}

