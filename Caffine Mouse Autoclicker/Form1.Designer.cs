namespace Caffine_Mouse_Autoclicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CafMousePic = new System.Windows.Forms.PictureBox();
            this.lblInterval = new System.Windows.Forms.GroupBox();
            this.numMilSec = new System.Windows.Forms.NumericUpDown();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHotKey = new System.Windows.Forms.GroupBox();
            this.comboHotKeyStop = new System.Windows.Forms.ComboBox();
            this.comboHotKeyStart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboAction = new System.Windows.Forms.ComboBox();
            this.comboMouse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegisterHotkeys = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CafMousePic)).BeginInit();
            this.lblInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMilSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.lblHotKey.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CafMousePic
            // 
            this.CafMousePic.Image = ((System.Drawing.Image)(resources.GetObject("CafMousePic.Image")));
            this.CafMousePic.InitialImage = null;
            this.CafMousePic.Location = new System.Drawing.Point(22, 12);
            this.CafMousePic.Name = "CafMousePic";
            this.CafMousePic.Size = new System.Drawing.Size(287, 237);
            this.CafMousePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CafMousePic.TabIndex = 0;
            this.CafMousePic.TabStop = false;
            // 
            // lblInterval
            // 
            this.lblInterval.Controls.Add(this.numMilSec);
            this.lblInterval.Controls.Add(this.numSec);
            this.lblInterval.Controls.Add(this.numMin);
            this.lblInterval.Controls.Add(this.numHours);
            this.lblInterval.Controls.Add(this.label8);
            this.lblInterval.Controls.Add(this.label7);
            this.lblInterval.Controls.Add(this.label6);
            this.lblInterval.Controls.Add(this.label5);
            this.lblInterval.Location = new System.Drawing.Point(315, 61);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(411, 171);
            this.lblInterval.TabIndex = 1;
            this.lblInterval.TabStop = false;
            this.lblInterval.Text = "Click Interval";
            // 
            // numMilSec
            // 
            this.numMilSec.Location = new System.Drawing.Point(305, 59);
            this.numMilSec.Name = "numMilSec";
            this.numMilSec.Size = new System.Drawing.Size(69, 26);
            this.numMilSec.TabIndex = 7;
            // 
            // numSec
            // 
            this.numSec.Location = new System.Drawing.Point(218, 58);
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(68, 26);
            this.numSec.TabIndex = 6;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(119, 59);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(65, 26);
            this.numMin.TabIndex = 5;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(27, 59);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(57, 26);
            this.numHours.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "MiliSeconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Minutes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hours";
            // 
            // lblHotKey
            // 
            this.lblHotKey.Controls.Add(this.comboHotKeyStop);
            this.lblHotKey.Controls.Add(this.comboHotKeyStart);
            this.lblHotKey.Controls.Add(this.label2);
            this.lblHotKey.Controls.Add(this.label1);
            this.lblHotKey.Location = new System.Drawing.Point(12, 255);
            this.lblHotKey.Name = "lblHotKey";
            this.lblHotKey.Size = new System.Drawing.Size(336, 127);
            this.lblHotKey.TabIndex = 2;
            this.lblHotKey.TabStop = false;
            this.lblHotKey.Text = "Hot key";
            this.lblHotKey.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboHotKeyStop
            // 
            this.comboHotKeyStop.FormattingEnabled = true;
            this.comboHotKeyStop.Location = new System.Drawing.Point(176, 75);
            this.comboHotKeyStop.Name = "comboHotKeyStop";
            this.comboHotKeyStop.Size = new System.Drawing.Size(121, 28);
            this.comboHotKeyStop.TabIndex = 5;
            // 
            // comboHotKeyStart
            // 
            this.comboHotKeyStart.FormattingEnabled = true;
            this.comboHotKeyStart.Location = new System.Drawing.Point(176, 35);
            this.comboHotKeyStart.Name = "comboHotKeyStart";
            this.comboHotKeyStart.Size = new System.Drawing.Size(121, 28);
            this.comboHotKeyStart.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stop: CTRL +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start: CTRL +";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboAction);
            this.groupBox3.Controls.Add(this.comboMouse);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(363, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mouse Action";
            // 
            // comboAction
            // 
            this.comboAction.FormattingEnabled = true;
            this.comboAction.Location = new System.Drawing.Point(147, 74);
            this.comboAction.Name = "comboAction";
            this.comboAction.Size = new System.Drawing.Size(121, 28);
            this.comboAction.TabIndex = 5;
            // 
            // comboMouse
            // 
            this.comboMouse.FormattingEnabled = true;
            this.comboMouse.Location = new System.Drawing.Point(147, 35);
            this.comboMouse.Name = "comboMouse";
            this.comboMouse.Size = new System.Drawing.Size(121, 28);
            this.comboMouse.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mouse";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 412);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 35);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(151, 412);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 35);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(604, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit&";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegisterHotkeys
            // 
            this.btnRegisterHotkeys.Location = new System.Drawing.Point(315, 413);
            this.btnRegisterHotkeys.Name = "btnRegisterHotkeys";
            this.btnRegisterHotkeys.Size = new System.Drawing.Size(204, 35);
            this.btnRegisterHotkeys.TabIndex = 7;
            this.btnRegisterHotkeys.Text = "Register Hotkey";
            this.btnRegisterHotkeys.UseVisualStyleBackColor = true;
            this.btnRegisterHotkeys.Click += new System.EventHandler(this.btnRegisterHotkeys_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 471);
            this.Controls.Add(this.btnRegisterHotkeys);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblHotKey);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.CafMousePic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Caffeine Mouse Autoclicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CafMousePic)).EndInit();
            this.lblInterval.ResumeLayout(false);
            this.lblInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMilSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.lblHotKey.ResumeLayout(false);
            this.lblHotKey.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CafMousePic;
        private System.Windows.Forms.GroupBox lblInterval;
        private System.Windows.Forms.GroupBox lblHotKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.NumericUpDown numMilSec;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.ComboBox comboHotKeyStop;
        private System.Windows.Forms.ComboBox comboHotKeyStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboAction;
        private System.Windows.Forms.ComboBox comboMouse;
        private System.Windows.Forms.Button btnRegisterHotkeys;
    }
}

