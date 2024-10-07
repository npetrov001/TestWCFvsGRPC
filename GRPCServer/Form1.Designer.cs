namespace GRPCServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStartServer = new Button();
            btnStopServer = new Button();
            label1 = new Label();
            txtURL = new TextBox();
            lblArchitecture = new Label();
            label2 = new Label();
            lblReqPerSec = new Label();
            lblReqPerSec10 = new Label();
            label5 = new Label();
            lblTime = new Label();
            timerRefresh = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnStartServer
            // 
            btnStartServer.Location = new Point(17, 63);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(150, 32);
            btnStartServer.TabIndex = 0;
            btnStartServer.Text = "Start Server";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnStopServer
            // 
            btnStopServer.Enabled = false;
            btnStopServer.Location = new Point(173, 63);
            btnStopServer.Name = "btnStopServer";
            btnStopServer.Size = new Size(150, 32);
            btnStopServer.TabIndex = 1;
            btnStopServer.Text = "Stop Server";
            btnStopServer.UseVisualStyleBackColor = true;
            btnStopServer.Click += btnStopServer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(32, 14);
            label1.TabIndex = 2;
            label1.Text = "URL:";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(50, 33);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(360, 22);
            txtURL.TabIndex = 3;
            txtURL.Text = "http://localhost:5002";
            // 
            // lblArchitecture
            // 
            lblArchitecture.AutoSize = true;
            lblArchitecture.Location = new Point(14, 9);
            lblArchitecture.Name = "lblArchitecture";
            lblArchitecture.Size = new Size(83, 14);
            lblArchitecture.TabIndex = 4;
            lblArchitecture.Text = "Architecture: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 104);
            label2.Name = "label2";
            label2.Size = new Size(146, 14);
            label2.TabIndex = 5;
            label2.Text = "Requests / sec (last sec):";
            // 
            // lblReqPerSec
            // 
            lblReqPerSec.AutoSize = true;
            lblReqPerSec.Location = new Point(189, 104);
            lblReqPerSec.Name = "lblReqPerSec";
            lblReqPerSec.Size = new Size(47, 14);
            lblReqPerSec.TabIndex = 6;
            lblReqPerSec.Text = "#,###";
            // 
            // lblReqPerSec10
            // 
            lblReqPerSec10.AutoSize = true;
            lblReqPerSec10.Location = new Point(189, 127);
            lblReqPerSec10.Name = "lblReqPerSec10";
            lblReqPerSec10.Size = new Size(47, 14);
            lblReqPerSec10.TabIndex = 8;
            lblReqPerSec10.Text = "#,###";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 127);
            label5.Name = "label5";
            label5.Size = new Size(165, 14);
            label5.TabIndex = 7;
            label5.Text = "Requests / sec (10-sec avg):";
            // 
            // lblTime
            // 
            lblTime.Location = new Point(299, 127);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(111, 14);
            lblTime.TabIndex = 9;
            lblTime.Text = "##:##:##.###";
            lblTime.TextAlign = ContentAlignment.TopRight;
            // 
            // timerRefresh
            // 
            timerRefresh.Interval = 1000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 158);
            Controls.Add(lblTime);
            Controls.Add(lblReqPerSec10);
            Controls.Add(label5);
            Controls.Add(lblReqPerSec);
            Controls.Add(label2);
            Controls.Add(lblArchitecture);
            Controls.Add(txtURL);
            Controls.Add(label1);
            Controls.Add(btnStopServer);
            Controls.Add(btnStartServer);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GRPC Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartServer;
        private Button btnStopServer;
        private Label label1;
        private TextBox txtURL;
        private Label lblArchitecture;
        private Label label2;
        private Label lblReqPerSec;
        private Label lblReqPerSec10;
        private Label label5;
        private Label lblTime;
        private System.Windows.Forms.Timer timerRefresh;
    }
}
