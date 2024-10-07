namespace WCFServer
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
            this.components = new System.ComponentModel.Container();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReqPerSec = new System.Windows.Forms.Label();
            this.lblReqPerSec10 = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(17, 63);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(150, 32);
            this.btnStartServer.TabIndex = 3;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(50, 33);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(370, 22);
            this.txtURL.TabIndex = 2;
            this.txtURL.Text = "http://localhost:5001";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Location = new System.Drawing.Point(175, 63);
            this.btnStopServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(150, 32);
            this.btnStopServer.TabIndex = 4;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Location = new System.Drawing.Point(14, 9);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(75, 14);
            this.lblArchitecture.TabIndex = 0;
            this.lblArchitecture.Text = "Architecture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Requests / sec (last sec):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Requests / sec (10-sec avg):";
            // 
            // lblReqPerSec
            // 
            this.lblReqPerSec.AutoSize = true;
            this.lblReqPerSec.Location = new System.Drawing.Point(192, 104);
            this.lblReqPerSec.Name = "lblReqPerSec";
            this.lblReqPerSec.Size = new System.Drawing.Size(47, 14);
            this.lblReqPerSec.TabIndex = 6;
            this.lblReqPerSec.Text = "#,###";
            // 
            // lblReqPerSec10
            // 
            this.lblReqPerSec10.AutoSize = true;
            this.lblReqPerSec10.Location = new System.Drawing.Point(192, 127);
            this.lblReqPerSec10.Name = "lblReqPerSec10";
            this.lblReqPerSec10.Size = new System.Drawing.Size(47, 14);
            this.lblReqPerSec10.TabIndex = 8;
            this.lblReqPerSec10.Text = "#,###";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(317, 127);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(105, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "##:##:##.###";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 157);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblReqPerSec10);
            this.Controls.Add(this.lblReqPerSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArchitecture);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartServer);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WCF Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReqPerSec;
        private System.Windows.Forms.Label lblReqPerSec10;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label lblTime;
    }
}

