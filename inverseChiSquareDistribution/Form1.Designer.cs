namespace distribution
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.formA = new System.Windows.Forms.NumericUpDown();
            this.formNiter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.formLeft = new System.Windows.Forms.NumericUpDown();
            this.formRight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxNeymon = new System.Windows.Forms.CheckBox();
            this.checkBoxMetropolis = new System.Windows.Forms.CheckBox();
            this.checkBoxInverse = new System.Windows.Forms.CheckBox();
            this.formStep = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarMetropolis = new System.Windows.Forms.ProgressBar();
            this.progressBarNeymon = new System.Windows.Forms.ProgressBar();
            this.progressBarInverse = new System.Windows.Forms.ProgressBar();
            this.Sigm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disperse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.indexNfield = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formNiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexNfield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripButton1, this.toolStripLabel1, this.toolStripProgressBar1 });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 27);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripButton1.Text = "Розподіл";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 24);
            this.toolStripLabel1.Text = "Допомога";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.OliveDrab;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // formA
            // 
            this.formA.DecimalPlaces = 1;
            this.formA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.formA.Location = new System.Drawing.Point(63, 37);
            this.formA.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.formA.Minimum = new decimal(new int[] { 1, 0, 0, 262144 });
            this.formA.Name = "formA";
            this.formA.Size = new System.Drawing.Size(92, 24);
            this.formA.TabIndex = 1;
            this.formA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formA.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // formNiter
            // 
            this.formNiter.DecimalPlaces = 1;
            this.formNiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formNiter.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.formNiter.Location = new System.Drawing.Point(200, 37);
            this.formNiter.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.formNiter.Minimum = new decimal(new int[] { 1, 0, 0, 262144 });
            this.formNiter.Name = "formNiter";
            this.formNiter.Size = new System.Drawing.Size(120, 24);
            this.formNiter.TabIndex = 2;
            this.formNiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formNiter.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "v";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(178, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "k";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(41, 322);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(418, 78);
            this.Start.TabIndex = 5;
            this.Start.Text = "Запустити";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // formLeft
            // 
            this.formLeft.DecimalPlaces = 1;
            this.formLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formLeft.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.formLeft.Location = new System.Drawing.Point(63, 72);
            this.formLeft.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            this.formLeft.Name = "formLeft";
            this.formLeft.Size = new System.Drawing.Size(92, 24);
            this.formLeft.TabIndex = 7;
            this.formLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formRight
            // 
            this.formRight.DecimalPlaces = 1;
            this.formRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formRight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.formRight.Location = new System.Drawing.Point(63, 97);
            this.formRight.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            this.formRight.Name = "formRight";
            this.formRight.Size = new System.Drawing.Size(92, 24);
            this.formRight.TabIndex = 8;
            this.formRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formRight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "X від";
            // 
            // checkBoxNeymon
            // 
            this.checkBoxNeymon.AutoSize = true;
            this.checkBoxNeymon.Checked = true;
            this.checkBoxNeymon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNeymon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxNeymon.Location = new System.Drawing.Point(37, 179);
            this.checkBoxNeymon.Name = "checkBoxNeymon";
            this.checkBoxNeymon.Size = new System.Drawing.Size(88, 22);
            this.checkBoxNeymon.TabIndex = 11;
            this.checkBoxNeymon.Text = "Неймон";
            this.checkBoxNeymon.UseVisualStyleBackColor = true;
            this.checkBoxNeymon.Visible = false;
            this.checkBoxNeymon.CheckedChanged += new System.EventHandler(this.checkBoxNeymon_CheckedChanged);
            // 
            // checkBoxMetropolis
            // 
            this.checkBoxMetropolis.AutoSize = true;
            this.checkBoxMetropolis.Checked = true;
            this.checkBoxMetropolis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMetropolis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMetropolis.Location = new System.Drawing.Point(37, 230);
            this.checkBoxMetropolis.Name = "checkBoxMetropolis";
            this.checkBoxMetropolis.Size = new System.Drawing.Size(119, 22);
            this.checkBoxMetropolis.TabIndex = 12;
            this.checkBoxMetropolis.Text = "Меторполіс";
            this.checkBoxMetropolis.UseVisualStyleBackColor = true;
            this.checkBoxMetropolis.Visible = false;
            this.checkBoxMetropolis.CheckedChanged += new System.EventHandler(this.checkBoxMetropolis_CheckedChanged);
            // 
            // checkBoxInverse
            // 
            this.checkBoxInverse.AutoSize = true;
            this.checkBoxInverse.Checked = true;
            this.checkBoxInverse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxInverse.Location = new System.Drawing.Point(37, 277);
            this.checkBoxInverse.Name = "checkBoxInverse";
            this.checkBoxInverse.Size = new System.Drawing.Size(150, 22);
            this.checkBoxInverse.TabIndex = 13;
            this.checkBoxInverse.Text = "Обернутий CDF";
            this.checkBoxInverse.UseVisualStyleBackColor = true;
            this.checkBoxInverse.Visible = false;
            this.checkBoxInverse.CheckedChanged += new System.EventHandler(this.checkBoxInverse_CheckedChanged);
            // 
            // formStep
            // 
            this.formStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formStep.Location = new System.Drawing.Point(339, 80);
            this.formStep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.formStep.Name = "formStep";
            this.formStep.Size = new System.Drawing.Size(92, 24);
            this.formStep.TabIndex = 14;
            this.formStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formStep.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(241, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Стовпчики";
            // 
            // progressBarMetropolis
            // 
            this.progressBarMetropolis.Location = new System.Drawing.Point(193, 225);
            this.progressBarMetropolis.Name = "progressBarMetropolis";
            this.progressBarMetropolis.Size = new System.Drawing.Size(266, 27);
            this.progressBarMetropolis.TabIndex = 16;
            // 
            // progressBarNeymon
            // 
            this.progressBarNeymon.Location = new System.Drawing.Point(193, 174);
            this.progressBarNeymon.Name = "progressBarNeymon";
            this.progressBarNeymon.Size = new System.Drawing.Size(266, 27);
            this.progressBarNeymon.TabIndex = 17;
            // 
            // progressBarInverse
            // 
            this.progressBarInverse.Location = new System.Drawing.Point(193, 272);
            this.progressBarInverse.Name = "progressBarInverse";
            this.progressBarInverse.Size = new System.Drawing.Size(266, 27);
            this.progressBarInverse.TabIndex = 20;
            // 
            // Sigm
            // 
            this.Sigm.HeaderText = "Sigma";
            this.Sigm.MinimumWidth = 6;
            this.Sigm.Name = "Sigm";
            this.Sigm.ReadOnly = true;
            this.Sigm.Width = 125;
            // 
            // Disperse
            // 
            this.Disperse.HeaderText = "Dispers";
            this.Disperse.MinimumWidth = 6;
            this.Disperse.Name = "Disperse";
            this.Disperse.ReadOnly = true;
            this.Disperse.Width = 125;
            // 
            // Mean
            // 
            this.Mean.HeaderText = "Mean";
            this.Mean.MinimumWidth = 6;
            this.Mean.Name = "Mean";
            this.Mean.ReadOnly = true;
            this.Mean.Width = 125;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.MinimumWidth = 6;
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            this.Method.Width = 125;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Method, this.Mean, this.Disperse, this.Sigm });
            this.dataGrid.Location = new System.Drawing.Point(3, 333);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(600, 191);
            this.dataGrid.TabIndex = 24;
            this.dataGrid.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer1.Panel1.Controls.Add(this.indexNfield);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.Save);
            this.splitContainer1.Panel1.Controls.Add(this.StopButton);
            this.splitContainer1.Panel1.Controls.Add(this.PauseButton);
            this.splitContainer1.Panel1.Controls.Add(this.formA);
            this.splitContainer1.Panel1.Controls.Add(this.formNiter);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarInverse);
            this.splitContainer1.Panel1.Controls.Add(this.Start);
            this.splitContainer1.Panel1.Controls.Add(this.formLeft);
            this.splitContainer1.Panel1.Controls.Add(this.formRight);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarNeymon);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarMetropolis);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxNeymon);
            this.splitContainer1.Panel1.Controls.Add(this.formStep);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMetropolis);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxInverse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.CausesValidation = false;
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 524);
            this.splitContainer1.SplitterDistance = 476;
            this.splitContainer1.TabIndex = 0;
            // 
            // indexNfield
            // 
            this.indexNfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexNfield.Location = new System.Drawing.Point(367, 37);
            this.indexNfield.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.indexNfield.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            this.indexNfield.Name = "indexNfield";
            this.indexNfield.Size = new System.Drawing.Size(92, 24);
            this.indexNfield.TabIndex = 29;
            this.indexNfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.indexNfield.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(342, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "N";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(193, 415);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(127, 63);
            this.Save.TabIndex = 28;
            this.Save.Text = "Вивести результат";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(41, 432);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(106, 28);
            this.StopButton.TabIndex = 26;
            this.StopButton.Text = "Зупинити";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseButton.Location = new System.Drawing.Point(353, 432);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(106, 28);
            this.PauseButton.TabIndex = 25;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightCyan;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Black;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Absolute";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Neymon";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series3.Legend = "Legend1";
            series3.Name = "Metropolis";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Inverse";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(604, 327);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inverse-chi-square Distribution Роман Савченко КС43";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formNiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indexNfield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.NumericUpDown formA;
        private System.Windows.Forms.NumericUpDown formNiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.NumericUpDown formLeft;
        private System.Windows.Forms.NumericUpDown formRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxNeymon;
        private System.Windows.Forms.CheckBox checkBoxMetropolis;
        private System.Windows.Forms.CheckBox checkBoxInverse;
        private System.Windows.Forms.NumericUpDown formStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarMetropolis;
        private System.Windows.Forms.ProgressBar progressBarNeymon;
        private System.Windows.Forms.ProgressBar progressBarInverse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disperse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.NumericUpDown indexNfield;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

