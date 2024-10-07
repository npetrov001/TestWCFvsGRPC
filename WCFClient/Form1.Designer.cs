namespace WCFClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessageSize = new System.Windows.Forms.TextBox();
            this.btnStressStart = new System.Windows.Forms.Button();
            this.btnStressStop = new System.Windows.Forms.Button();
            this.txtStressTest = new System.Windows.Forms.TextBox();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.txtMaxMessages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridStats = new System.Windows.Forms.DataGridView();
            this.rdoThreads = new System.Windows.Forms.RadioButton();
            this.rdoTasks = new System.Windows.Forms.RadioButton();
            this.colThread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReqPerSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvgMs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridStats)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(49, 30);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(311, 22);
            this.txtURL.TabIndex = 2;
            this.txtURL.Text = "http://localhost:5001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 60);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(348, 32);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test Ping (Complete Connect && Test)";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(12, 98);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(348, 98);
            this.txtOut.TabIndex = 4;
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Location = new System.Drawing.Point(8, 7);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(75, 14);
            this.lblArchitecture.TabIndex = 0;
            this.lblArchitecture.Text = "Architecture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base Message Size (bytes):";
            // 
            // txtMessageSize
            // 
            this.txtMessageSize.Location = new System.Drawing.Point(231, 206);
            this.txtMessageSize.Name = "txtMessageSize";
            this.txtMessageSize.Size = new System.Drawing.Size(98, 22);
            this.txtMessageSize.TabIndex = 6;
            this.txtMessageSize.Text = "1,000";
            // 
            // btnStressStart
            // 
            this.btnStressStart.Enabled = false;
            this.btnStressStart.Location = new System.Drawing.Point(12, 327);
            this.btnStressStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStressStart.Name = "btnStressStart";
            this.btnStressStart.Size = new System.Drawing.Size(170, 32);
            this.btnStressStart.TabIndex = 9;
            this.btnStressStart.Text = "Start Stress Test";
            this.btnStressStart.UseVisualStyleBackColor = true;
            this.btnStressStart.Click += new System.EventHandler(this.btnStressStart_Click);
            // 
            // btnStressStop
            // 
            this.btnStressStop.Enabled = false;
            this.btnStressStop.Location = new System.Drawing.Point(190, 327);
            this.btnStressStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStressStop.Name = "btnStressStop";
            this.btnStressStop.Size = new System.Drawing.Size(170, 32);
            this.btnStressStop.TabIndex = 10;
            this.btnStressStop.Text = "Stop Stress Test";
            this.btnStressStop.UseVisualStyleBackColor = true;
            this.btnStressStop.Click += new System.EventHandler(this.btnStressStop_Click);
            // 
            // txtStressTest
            // 
            this.txtStressTest.Location = new System.Drawing.Point(11, 383);
            this.txtStressTest.Multiline = true;
            this.txtStressTest.Name = "txtStressTest";
            this.txtStressTest.Size = new System.Drawing.Size(348, 156);
            this.txtStressTest.TabIndex = 11;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // txtMaxMessages
            // 
            this.txtMaxMessages.Location = new System.Drawing.Point(231, 256);
            this.txtMaxMessages.Name = "txtMaxMessages";
            this.txtMaxMessages.Size = new System.Drawing.Size(98, 22);
            this.txtMaxMessages.TabIndex = 8;
            this.txtMaxMessages.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Messages per Thread (0 - unlimited):";
            // 
            // txtThreads
            // 
            this.txtThreads.Location = new System.Drawing.Point(231, 231);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(98, 22);
            this.txtThreads.TabIndex = 13;
            this.txtThreads.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "# of Threads / Tasks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Summary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Thread Stats:";
            // 
            // gridStats
            // 
            this.gridStats.AllowUserToAddRows = false;
            this.gridStats.AllowUserToDeleteRows = false;
            this.gridStats.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridStats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStats.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridStats.ColumnHeadersHeight = 22;
            this.gridStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThread,
            this.colSuccess,
            this.colErrors,
            this.colReqPerSec,
            this.colAvgMs});
            this.gridStats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.gridStats.Location = new System.Drawing.Point(372, 30);
            this.gridStats.MultiSelect = false;
            this.gridStats.Name = "gridStats";
            this.gridStats.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 1);
            this.gridStats.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStats.Size = new System.Drawing.Size(392, 509);
            this.gridStats.TabIndex = 16;
            // 
            // rdoThreads
            // 
            this.rdoThreads.AutoSize = true;
            this.rdoThreads.Checked = true;
            this.rdoThreads.Location = new System.Drawing.Point(12, 292);
            this.rdoThreads.Name = "rdoThreads";
            this.rdoThreads.Size = new System.Drawing.Size(93, 18);
            this.rdoThreads.TabIndex = 17;
            this.rdoThreads.TabStop = true;
            this.rdoThreads.Text = "Use Threads";
            this.rdoThreads.UseVisualStyleBackColor = true;
            // 
            // rdoTasks
            // 
            this.rdoTasks.AutoSize = true;
            this.rdoTasks.Location = new System.Drawing.Point(122, 292);
            this.rdoTasks.Name = "rdoTasks";
            this.rdoTasks.Size = new System.Drawing.Size(79, 18);
            this.rdoTasks.TabIndex = 18;
            this.rdoTasks.Text = "Use Tasks";
            this.rdoTasks.UseVisualStyleBackColor = true;
            // 
            // colThread
            // 
            this.colThread.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colThread.DataPropertyName = "ThreadNum";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colThread.DefaultCellStyle = dataGridViewCellStyle2;
            this.colThread.FillWeight = 80F;
            this.colThread.HeaderText = "Thread";
            this.colThread.Name = "colThread";
            this.colThread.ReadOnly = true;
            this.colThread.Width = 70;
            // 
            // colSuccess
            // 
            this.colSuccess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSuccess.DataPropertyName = "Success";
            this.colSuccess.FillWeight = 80F;
            this.colSuccess.HeaderText = "Success";
            this.colSuccess.Name = "colSuccess";
            this.colSuccess.ReadOnly = true;
            // 
            // colErrors
            // 
            this.colErrors.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colErrors.DataPropertyName = "Errors";
            this.colErrors.FillWeight = 80F;
            this.colErrors.HeaderText = "Errors";
            this.colErrors.Name = "colErrors";
            this.colErrors.ReadOnly = true;
            // 
            // colReqPerSec
            // 
            this.colReqPerSec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReqPerSec.DataPropertyName = "ReqPerSec";
            this.colReqPerSec.FillWeight = 80F;
            this.colReqPerSec.HeaderText = "Req/sec";
            this.colReqPerSec.Name = "colReqPerSec";
            this.colReqPerSec.ReadOnly = true;
            // 
            // colAvgMs
            // 
            this.colAvgMs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAvgMs.DataPropertyName = "AvgMs";
            this.colAvgMs.FillWeight = 80F;
            this.colAvgMs.HeaderText = "Avg ms";
            this.colAvgMs.Name = "colAvgMs";
            this.colAvgMs.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 547);
            this.Controls.Add(this.rdoTasks);
            this.Controls.Add(this.rdoThreads);
            this.Controls.Add(this.gridStats);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThreads);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStressTest);
            this.Controls.Add(this.btnStressStop);
            this.Controls.Add(this.btnStressStart);
            this.Controls.Add(this.txtMessageSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArchitecture);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WCF Client - Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessageSize;
        private System.Windows.Forms.Button btnStressStart;
        private System.Windows.Forms.Button btnStressStop;
        private System.Windows.Forms.TextBox txtStressTest;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TextBox txtMaxMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridStats;
        private System.Windows.Forms.RadioButton rdoThreads;
        private System.Windows.Forms.RadioButton rdoTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThread;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReqPerSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvgMs;
    }
}

