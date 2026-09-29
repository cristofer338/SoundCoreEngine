namespace SoundCoreEngine
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
            dgvPlaylist = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colArtist = new DataGridViewTextBoxColumn();
            colBpm = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            btnAddToEnd = new Button();
            btnPlayNext = new Button();
            btnAdvanceTrack = new Button();
            btnReverseList = new Button();
            btnRemoveDuplicates = new Button();
            btnSortByBpm = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            lblBenchmarkResults = new Label();
            btnBenchmark = new Button();
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            txtArtist = new TextBox();
            label3 = new Label();
            numBpm = new NumericUpDown();
            numDuration = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rdoArrayList = new RadioButton();
            rdoDotNetList = new RadioButton();
            rdoOwnList = new RadioButton();
            btnPause = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlaylist).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBpm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPlaylist
            // 
            dgvPlaylist.AllowUserToAddRows = false;
            dgvPlaylist.AllowUserToDeleteRows = false;
            dgvPlaylist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlaylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlaylist.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colArtist, colBpm, colDuration });
            dgvPlaylist.Location = new Point(6, 26);
            dgvPlaylist.Name = "dgvPlaylist";
            dgvPlaylist.ReadOnly = true;
            dgvPlaylist.RowHeadersWidth = 51;
            dgvPlaylist.Size = new Size(545, 205);
            dgvPlaylist.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colArtist
            // 
            colArtist.HeaderText = "Artist";
            colArtist.MinimumWidth = 6;
            colArtist.Name = "colArtist";
            colArtist.ReadOnly = true;
            // 
            // colBpm
            // 
            colBpm.HeaderText = "BPM";
            colBpm.MinimumWidth = 6;
            colBpm.Name = "colBpm";
            colBpm.ReadOnly = true;
            // 
            // colDuration
            // 
            colDuration.HeaderText = "Duration";
            colDuration.MinimumWidth = 6;
            colDuration.Name = "colDuration";
            colDuration.ReadOnly = true;
            // 
            // btnAddToEnd
            // 
            btnAddToEnd.Location = new Point(6, 26);
            btnAddToEnd.Name = "btnAddToEnd";
            btnAddToEnd.Size = new Size(198, 29);
            btnAddToEnd.TabIndex = 1;
            btnAddToEnd.Text = "Add to End";
            btnAddToEnd.UseVisualStyleBackColor = true;
            btnAddToEnd.Click += btnAddToEnd_Click;
            // 
            // btnPlayNext
            // 
            btnPlayNext.Location = new Point(6, 61);
            btnPlayNext.Name = "btnPlayNext";
            btnPlayNext.Size = new Size(198, 29);
            btnPlayNext.TabIndex = 2;
            btnPlayNext.Text = "Play Next";
            btnPlayNext.UseVisualStyleBackColor = true;
            btnPlayNext.Click += btnPlayNext_Click;
            // 
            // btnAdvanceTrack
            // 
            btnAdvanceTrack.Location = new Point(6, 96);
            btnAdvanceTrack.Name = "btnAdvanceTrack";
            btnAdvanceTrack.Size = new Size(199, 29);
            btnAdvanceTrack.TabIndex = 3;
            btnAdvanceTrack.Text = "Advance Track";
            btnAdvanceTrack.UseVisualStyleBackColor = true;
            btnAdvanceTrack.Click += btnAdvanceTrack_Click;
            // 
            // btnReverseList
            // 
            btnReverseList.Location = new Point(6, 131);
            btnReverseList.Name = "btnReverseList";
            btnReverseList.Size = new Size(199, 29);
            btnReverseList.TabIndex = 4;
            btnReverseList.Text = "Reverse List (In-Place)";
            btnReverseList.UseVisualStyleBackColor = true;
            btnReverseList.Click += btnReverseList_Click;
            // 
            // btnRemoveDuplicates
            // 
            btnRemoveDuplicates.Location = new Point(6, 202);
            btnRemoveDuplicates.Name = "btnRemoveDuplicates";
            btnRemoveDuplicates.Size = new Size(199, 29);
            btnRemoveDuplicates.TabIndex = 5;
            btnRemoveDuplicates.Text = "Remove Duplicates";
            btnRemoveDuplicates.UseVisualStyleBackColor = true;
            btnRemoveDuplicates.Click += btnRemoveDuplicates_Click;
            // 
            // btnSortByBpm
            // 
            btnSortByBpm.Location = new Point(6, 167);
            btnSortByBpm.Name = "btnSortByBpm";
            btnSortByBpm.Size = new Size(199, 29);
            btnSortByBpm.TabIndex = 6;
            btnSortByBpm.Text = "Sort by BPM";
            btnSortByBpm.UseVisualStyleBackColor = true;
            btnSortByBpm.Click += btnSortByBpm_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddToEnd);
            groupBox2.Controls.Add(btnPlayNext);
            groupBox2.Controls.Add(btnSortByBpm);
            groupBox2.Controls.Add(btnAdvanceTrack);
            groupBox2.Controls.Add(btnRemoveDuplicates);
            groupBox2.Controls.Add(btnReverseList);
            groupBox2.Location = new Point(12, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 237);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "QUEUE ACTIONS";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvPlaylist);
            groupBox3.Location = new Point(231, 139);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(557, 237);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "LIVE PLAYLIST";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnPause);
            groupBox4.Controls.Add(lblBenchmarkResults);
            groupBox4.Controls.Add(btnBenchmark);
            groupBox4.Location = new Point(14, 380);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(774, 156);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "BENCHMARK TELEMETRY";
            // 
            // lblBenchmarkResults
            // 
            lblBenchmarkResults.AutoSize = true;
            lblBenchmarkResults.Location = new Point(13, 64);
            lblBenchmarkResults.Name = "lblBenchmarkResults";
            lblBenchmarkResults.Size = new Size(166, 20);
            lblBenchmarkResults.TabIndex = 1;
            lblBenchmarkResults.Text = "Results will appear here";
            // 
            // btnBenchmark
            // 
            btnBenchmark.Location = new Point(6, 26);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(203, 27);
            btnBenchmark.TabIndex = 0;
            btnBenchmark.Text = "Probar 25,000 Inserciones";
            btnBenchmark.UseVisualStyleBackColor = true;
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 26);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(60, 24);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(179, 27);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 27);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Artist:";
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(311, 24);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(160, 27);
            txtArtist.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 30);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "BPM:";
            // 
            // numBpm
            // 
            numBpm.Location = new Point(525, 23);
            numBpm.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numBpm.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBpm.Name = "numBpm";
            numBpm.Size = new Size(61, 27);
            numBpm.TabIndex = 5;
            numBpm.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numDuration
            // 
            numDuration.Location = new Point(681, 21);
            numDuration.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(53, 27);
            numDuration.TabIndex = 6;
            numDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(605, 28);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Duration:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 81);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 8;
            label5.Text = "Model";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoArrayList);
            groupBox1.Controls.Add(rdoDotNetList);
            groupBox1.Controls.Add(rdoOwnList);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numDuration);
            groupBox1.Controls.Add(numBpm);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtArtist);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(777, 125);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRATION";
            // 
            // rdoArrayList
            // 
            rdoArrayList.AutoSize = true;
            rdoArrayList.Location = new Point(370, 79);
            rdoArrayList.Name = "rdoArrayList";
            rdoArrayList.Size = new Size(137, 24);
            rdoArrayList.TabIndex = 11;
            rdoArrayList.Text = "Array-Based List";
            rdoArrayList.UseVisualStyleBackColor = true;
            // 
            // rdoDotNetList
            // 
            rdoDotNetList.AutoSize = true;
            rdoDotNetList.Location = new Point(207, 79);
            rdoDotNetList.Name = "rdoDotNetList";
            rdoDotNetList.Size = new Size(157, 24);
            rdoDotNetList.TabIndex = 10;
            rdoDotNetList.Text = ".NET LinkedList<T>";
            rdoDotNetList.UseVisualStyleBackColor = true;
            // 
            // rdoOwnList
            // 
            rdoOwnList.AutoSize = true;
            rdoOwnList.Checked = true;
            rdoOwnList.Location = new Point(65, 79);
            rdoOwnList.Name = "rdoOwnList";
            rdoOwnList.Size = new Size(136, 24);
            rdoOwnList.TabIndex = 9;
            rdoOwnList.TabStop = true;
            rdoOwnList.Text = "Own Simple List";
            rdoOwnList.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(217, 25);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(94, 29);
            btnPause.TabIndex = 2;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "SoundCore Engine";
            ((System.ComponentModel.ISupportInitialize)dgvPlaylist).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBpm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPlaylist;
        private Button btnAddToEnd;
        private Button btnPlayNext;
        private Button btnAdvanceTrack;
        private Button btnReverseList;
        private Button btnRemoveDuplicates;
        private Button btnSortByBpm;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtArtist;
        private Label label3;
        private NumericUpDown numBpm;
        private NumericUpDown numDuration;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rdoArrayList;
        private RadioButton rdoDotNetList;
        private RadioButton rdoOwnList;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colArtist;
        private DataGridViewTextBoxColumn colBpm;
        private DataGridViewTextBoxColumn colDuration;
        private Button btnBenchmark;
        private Label lblBenchmarkResults;
        private Button btnPause;
    }
}
