namespace GRPCClient
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            txtURL = new TextBox();
            btnTest = new Button();
            txtOut = new TextBox();
            btnStressStart = new Button();
            txtStressTest = new TextBox();
            btnStressStop = new Button();
            timerRefresh = new System.Windows.Forms.Timer(components);
            txtMessageSize = new TextBox();
            label2 = new Label();
            lblArchitecture = new Label();
            txtThreads = new TextBox();
            label3 = new Label();
            txtMaxMessages = new TextBox();
            label4 = new Label();
            rdoThreads = new RadioButton();
            rdoTasks = new RadioButton();
            label5 = new Label();
            gridStats = new DataGridView();
            colThreadNum = new DataGridViewTextBoxColumn();
            colSuccess = new DataGridViewTextBoxColumn();
            colErrors = new DataGridViewTextBoxColumn();
            colReqPerSec = new DataGridViewTextBoxColumn();
            colAvgMs = new DataGridViewTextBoxColumn();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridStats).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 33);
            label1.Name = "label1";
            label1.Size = new Size(32, 14);
            label1.TabIndex = 0;
            label1.Text = "URL:";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(49, 30);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(311, 22);
            txtURL.TabIndex = 1;
            txtURL.Text = "http://localhost:5002";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(12, 60);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(348, 32);
            btnTest.TabIndex = 2;
            btnTest.Text = "Test Ping (Complete Connect && Test)";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 98);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(348, 98);
            txtOut.TabIndex = 3;
            // 
            // btnStressStart
            // 
            btnStressStart.Location = new Point(12, 327);
            btnStressStart.Name = "btnStressStart";
            btnStressStart.Size = new Size(170, 32);
            btnStressStart.TabIndex = 4;
            btnStressStart.Text = "Start Stress Test";
            btnStressStart.UseVisualStyleBackColor = true;
            btnStressStart.Click += btnStressStart_Click;
            // 
            // txtStressTest
            // 
            txtStressTest.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStressTest.Location = new Point(11, 383);
            txtStressTest.Multiline = true;
            txtStressTest.Name = "txtStressTest";
            txtStressTest.Size = new Size(348, 156);
            txtStressTest.TabIndex = 5;
            // 
            // btnStressStop
            // 
            btnStressStop.Location = new Point(190, 327);
            btnStressStop.Name = "btnStressStop";
            btnStressStop.Size = new Size(170, 32);
            btnStressStop.TabIndex = 6;
            btnStressStop.Text = "Stop Stress Test";
            btnStressStop.UseVisualStyleBackColor = true;
            btnStressStop.Click += btnStressStop_Click;
            // 
            // timerRefresh
            // 
            timerRefresh.Interval = 1000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // txtMessageSize
            // 
            txtMessageSize.Location = new Point(228, 206);
            txtMessageSize.Name = "txtMessageSize";
            txtMessageSize.Size = new Size(105, 22);
            txtMessageSize.TabIndex = 8;
            txtMessageSize.Text = "1000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 209);
            label2.Name = "label2";
            label2.Size = new Size(155, 14);
            label2.TabIndex = 7;
            label2.Text = "Base Message Size (bytes):";
            // 
            // lblArchitecture
            // 
            lblArchitecture.AutoSize = true;
            lblArchitecture.Location = new Point(8, 7);
            lblArchitecture.Name = "lblArchitecture";
            lblArchitecture.Size = new Size(83, 14);
            lblArchitecture.TabIndex = 9;
            lblArchitecture.Text = "Architecture: ";
            // 
            // txtThreads
            // 
            txtThreads.Location = new Point(228, 232);
            txtThreads.Name = "txtThreads";
            txtThreads.Size = new Size(105, 22);
            txtThreads.TabIndex = 11;
            txtThreads.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 235);
            label3.Name = "label3";
            label3.Size = new Size(126, 14);
            label3.TabIndex = 10;
            label3.Text = "# of Threads / Tasks:";
            // 
            // txtMaxMessages
            // 
            txtMaxMessages.Location = new Point(228, 258);
            txtMaxMessages.Name = "txtMaxMessages";
            txtMaxMessages.Size = new Size(105, 22);
            txtMaxMessages.TabIndex = 13;
            txtMaxMessages.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 261);
            label4.Name = "label4";
            label4.Size = new Size(209, 14);
            label4.TabIndex = 12;
            label4.Text = "Messages per Thread (0 - unlimited):";
            // 
            // rdoThreads
            // 
            rdoThreads.AutoSize = true;
            rdoThreads.Checked = true;
            rdoThreads.Location = new Point(12, 289);
            rdoThreads.Name = "rdoThreads";
            rdoThreads.Size = new Size(93, 18);
            rdoThreads.TabIndex = 14;
            rdoThreads.TabStop = true;
            rdoThreads.Text = "Use Threads";
            rdoThreads.UseVisualStyleBackColor = true;
            // 
            // rdoTasks
            // 
            rdoTasks.AutoSize = true;
            rdoTasks.Location = new Point(125, 289);
            rdoTasks.Name = "rdoTasks";
            rdoTasks.Size = new Size(79, 18);
            rdoTasks.TabIndex = 15;
            rdoTasks.Text = "Use Tasks";
            rdoTasks.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 366);
            label5.Name = "label5";
            label5.Size = new Size(61, 14);
            label5.TabIndex = 16;
            label5.Text = "Summary:";
            // 
            // gridStats
            // 
            gridStats.AllowUserToAddRows = false;
            gridStats.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            gridStats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridStats.BackgroundColor = SystemColors.Window;
            gridStats.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridStats.ColumnHeadersHeight = 22;
            gridStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridStats.Columns.AddRange(new DataGridViewColumn[] { colThreadNum, colSuccess, colErrors, colReqPerSec, colAvgMs });
            gridStats.EditMode = DataGridViewEditMode.EditOnF2;
            gridStats.GridColor = SystemColors.ControlDark;
            gridStats.Location = new Point(372, 30);
            gridStats.MultiSelect = false;
            gridStats.Name = "gridStats";
            gridStats.RowHeadersVisible = false;
            dataGridViewCellStyle2.Padding = new Padding(4, 0, 0, 1);
            gridStats.RowsDefaultCellStyle = dataGridViewCellStyle2;
            gridStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridStats.Size = new Size(625, 509);
            gridStats.TabIndex = 17;
            // 
            // colThreadNum
            // 
            colThreadNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colThreadNum.DataPropertyName = "ThreadNum";
            colThreadNum.FillWeight = 80F;
            colThreadNum.HeaderText = "Thread";
            colThreadNum.Name = "colThreadNum";
            colThreadNum.ReadOnly = true;
            colThreadNum.Width = 70;
            // 
            // colSuccess
            // 
            colSuccess.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSuccess.DataPropertyName = "Success";
            colSuccess.FillWeight = 80F;
            colSuccess.HeaderText = "Success";
            colSuccess.Name = "colSuccess";
            colSuccess.ReadOnly = true;
            // 
            // colErrors
            // 
            colErrors.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colErrors.DataPropertyName = "Errors";
            colErrors.FillWeight = 80F;
            colErrors.HeaderText = "Errors";
            colErrors.Name = "colErrors";
            colErrors.ReadOnly = true;
            // 
            // colReqPerSec
            // 
            colReqPerSec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colReqPerSec.DataPropertyName = "ReqPerSec";
            colReqPerSec.FillWeight = 80F;
            colReqPerSec.HeaderText = "Req/sec";
            colReqPerSec.Name = "colReqPerSec";
            colReqPerSec.ReadOnly = true;
            // 
            // colAvgMs
            // 
            colAvgMs.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAvgMs.DataPropertyName = "AvgMs";
            colAvgMs.FillWeight = 80F;
            colAvgMs.HeaderText = "Avg ms";
            colAvgMs.Name = "colAvgMs";
            colAvgMs.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 7);
            label6.Name = "label6";
            label6.Size = new Size(82, 14);
            label6.TabIndex = 18;
            label6.Text = "Thread Stats:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 549);
            Controls.Add(label6);
            Controls.Add(gridStats);
            Controls.Add(label5);
            Controls.Add(rdoTasks);
            Controls.Add(rdoThreads);
            Controls.Add(txtMaxMessages);
            Controls.Add(label4);
            Controls.Add(txtThreads);
            Controls.Add(label3);
            Controls.Add(lblArchitecture);
            Controls.Add(txtMessageSize);
            Controls.Add(label2);
            Controls.Add(btnStressStop);
            Controls.Add(txtStressTest);
            Controls.Add(btnStressStart);
            Controls.Add(txtOut);
            Controls.Add(btnTest);
            Controls.Add(txtURL);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GRPC Client - Test";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtURL;
        private Button btnTest;
        private TextBox txtOut;
        private Button btnStressStart;
        private TextBox txtStressTest;
        private Button btnStressStop;
        private System.Windows.Forms.Timer timerRefresh;
        private TextBox txtMessageSize;
        private Label label2;
        private Label lblArchitecture;
        private TextBox txtThreads;
        private Label label3;
        private TextBox txtMaxMessages;
        private Label label4;
        private RadioButton rdoThreads;
        private RadioButton rdoTasks;
        private Label label5;
        private DataGridView gridStats;
        private Label label6;
        private DataGridViewTextBoxColumn colThreadNum;
        private DataGridViewTextBoxColumn colSuccess;
        private DataGridViewTextBoxColumn colErrors;
        private DataGridViewTextBoxColumn colReqPerSec;
        private DataGridViewTextBoxColumn colAvgMs;
    }
}
