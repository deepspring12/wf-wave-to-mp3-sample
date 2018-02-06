namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.inputBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.EncodeBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TargetGroupBox = new System.Windows.Forms.GroupBox();
            this.QualityRadioButton = new System.Windows.Forms.RadioButton();
            this.BitrateRadioButton = new System.Windows.Forms.RadioButton();
            this.MonoCheckBox = new System.Windows.Forms.CheckBox();
            this.BitrateTrackBar = new System.Windows.Forms.TrackBar();
            this.BitrateBox = new System.Windows.Forms.GroupBox();
            this.BitrateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBRCheckBox = new System.Windows.Forms.CheckBox();
            this.QualityBox = new System.Windows.Forms.GroupBox();
            this.QualityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.QualityTrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.PriorityGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.TargetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateTrackBar)).BeginInit();
            this.BitrateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateNumericUpDown)).BeginInit();
            this.QualityBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).BeginInit();
            this.PriorityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBtn
            // 
            this.inputBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBtn.Location = new System.Drawing.Point(494, 46);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(87, 35);
            this.inputBtn.TabIndex = 0;
            this.inputBtn.Text = "Browse";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.browseInputBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.outputBtn);
            this.groupBox1.Controls.Add(this.inputBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Control";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mp3";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wave ";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(127, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(341, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(127, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(341, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File";
            // 
            // outputBtn
            // 
            this.outputBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBtn.Enabled = false;
            this.outputBtn.Location = new System.Drawing.Point(494, 109);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(87, 35);
            this.outputBtn.TabIndex = 1;
            this.outputBtn.Text = "Browse";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Wave Files |*.wav";
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EncodeBtn.Enabled = false;
            this.EncodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EncodeBtn.Location = new System.Drawing.Point(523, 622);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(97, 37);
            this.EncodeBtn.TabIndex = 2;
            this.EncodeBtn.Text = "Encode";
            this.EncodeBtn.UseVisualStyleBackColor = true;
            this.EncodeBtn.Click += new System.EventHandler(this.EncodeBtn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressBar,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(633, 25);
            this.statusStrip1.TabIndex = 3;
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(100, 19);
            this.tsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tsProgressBar.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabel1.Text = "Select Input File";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(52, 20);
            this.toolStripStatusLabel2.Text = ":Status";
            // 
            // TargetGroupBox
            // 
            this.TargetGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetGroupBox.Controls.Add(this.QualityRadioButton);
            this.TargetGroupBox.Controls.Add(this.BitrateRadioButton);
            this.TargetGroupBox.Enabled = false;
            this.TargetGroupBox.Location = new System.Drawing.Point(12, 191);
            this.TargetGroupBox.Name = "TargetGroupBox";
            this.TargetGroupBox.Size = new System.Drawing.Size(200, 100);
            this.TargetGroupBox.TabIndex = 5;
            this.TargetGroupBox.TabStop = false;
            this.TargetGroupBox.Text = "Target";
            // 
            // QualityRadioButton
            // 
            this.QualityRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QualityRadioButton.AutoSize = true;
            this.QualityRadioButton.Checked = true;
            this.QualityRadioButton.Location = new System.Drawing.Point(25, 57);
            this.QualityRadioButton.Name = "QualityRadioButton";
            this.QualityRadioButton.Size = new System.Drawing.Size(73, 21);
            this.QualityRadioButton.TabIndex = 1;
            this.QualityRadioButton.TabStop = true;
            this.QualityRadioButton.Text = "Quality";
            this.QualityRadioButton.UseVisualStyleBackColor = true;
            this.QualityRadioButton.CheckedChanged += new System.EventHandler(this.QualityRadioButton_CheckedChanged);
            // 
            // BitrateRadioButton
            // 
            this.BitrateRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BitrateRadioButton.AutoSize = true;
            this.BitrateRadioButton.Location = new System.Drawing.Point(25, 30);
            this.BitrateRadioButton.Name = "BitrateRadioButton";
            this.BitrateRadioButton.Size = new System.Drawing.Size(70, 21);
            this.BitrateRadioButton.TabIndex = 0;
            this.BitrateRadioButton.Text = "Bitrate";
            this.BitrateRadioButton.UseVisualStyleBackColor = true;
            this.BitrateRadioButton.CheckedChanged += new System.EventHandler(this.BitrateRadioButton_CheckedChanged);
            // 
            // MonoCheckBox
            // 
            this.MonoCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MonoCheckBox.AutoSize = true;
            this.MonoCheckBox.Enabled = false;
            this.MonoCheckBox.Location = new System.Drawing.Point(467, 231);
            this.MonoCheckBox.Name = "MonoCheckBox";
            this.MonoCheckBox.Size = new System.Drawing.Size(128, 21);
            this.MonoCheckBox.TabIndex = 7;
            this.MonoCheckBox.Text = "Mono Encoding";
            this.MonoCheckBox.UseVisualStyleBackColor = true;
            this.MonoCheckBox.CheckedChanged += new System.EventHandler(this.MonoCheckBox_CheckedChanged);
            // 
            // BitrateTrackBar
            // 
            this.BitrateTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BitrateTrackBar.LargeChange = 64;
            this.BitrateTrackBar.Location = new System.Drawing.Point(42, 38);
            this.BitrateTrackBar.Maximum = 320;
            this.BitrateTrackBar.Minimum = 64;
            this.BitrateTrackBar.Name = "BitrateTrackBar";
            this.BitrateTrackBar.Size = new System.Drawing.Size(479, 56);
            this.BitrateTrackBar.SmallChange = 32;
            this.BitrateTrackBar.TabIndex = 9;
            this.BitrateTrackBar.Tag = "";
            this.BitrateTrackBar.TickFrequency = 64;
            this.BitrateTrackBar.Value = 160;
            this.BitrateTrackBar.Scroll += new System.EventHandler(this.BitrateTrackBar_Scroll);
            // 
            // BitrateBox
            // 
            this.BitrateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BitrateBox.Controls.Add(this.BitrateNumericUpDown);
            this.BitrateBox.Controls.Add(this.label11);
            this.BitrateBox.Controls.Add(this.label10);
            this.BitrateBox.Controls.Add(this.label9);
            this.BitrateBox.Controls.Add(this.label8);
            this.BitrateBox.Controls.Add(this.label7);
            this.BitrateBox.Controls.Add(this.CBRCheckBox);
            this.BitrateBox.Controls.Add(this.BitrateTrackBar);
            this.BitrateBox.Enabled = false;
            this.BitrateBox.Location = new System.Drawing.Point(12, 309);
            this.BitrateBox.Name = "BitrateBox";
            this.BitrateBox.Size = new System.Drawing.Size(608, 138);
            this.BitrateBox.TabIndex = 10;
            this.BitrateBox.TabStop = false;
            this.BitrateBox.Text = "Bitrate";
            // 
            // BitrateNumericUpDown
            // 
            this.BitrateNumericUpDown.Location = new System.Drawing.Point(530, 38);
            this.BitrateNumericUpDown.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.BitrateNumericUpDown.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.BitrateNumericUpDown.Name = "BitrateNumericUpDown";
            this.BitrateNumericUpDown.Size = new System.Drawing.Size(58, 22);
            this.BitrateNumericUpDown.TabIndex = 16;
            this.BitrateNumericUpDown.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.BitrateNumericUpDown.ValueChanged += new System.EventHandler(this.BitrateNumericUpDown_ValueChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "320";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "256";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "192";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "128";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "64";
            // 
            // CBRCheckBox
            // 
            this.CBRCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBRCheckBox.AutoSize = true;
            this.CBRCheckBox.Location = new System.Drawing.Point(294, 111);
            this.CBRCheckBox.Name = "CBRCheckBox";
            this.CBRCheckBox.Size = new System.Drawing.Size(294, 21);
            this.CBRCheckBox.TabIndex = 10;
            this.CBRCheckBox.Text = "Restrict encoder to constant bitrate (CBR)";
            this.CBRCheckBox.UseVisualStyleBackColor = true;
            this.CBRCheckBox.CheckedChanged += new System.EventHandler(this.CBRCheckBox_CheckedChanged);
            // 
            // QualityBox
            // 
            this.QualityBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QualityBox.Controls.Add(this.QualityNumericUpDown);
            this.QualityBox.Controls.Add(this.label13);
            this.QualityBox.Controls.Add(this.label12);
            this.QualityBox.Controls.Add(this.QualityTrackBar);
            this.QualityBox.Enabled = false;
            this.QualityBox.Location = new System.Drawing.Point(12, 464);
            this.QualityBox.Name = "QualityBox";
            this.QualityBox.Size = new System.Drawing.Size(608, 144);
            this.QualityBox.TabIndex = 11;
            this.QualityBox.TabStop = false;
            this.QualityBox.Text = "Quality";
            // 
            // QualityNumericUpDown
            // 
            this.QualityNumericUpDown.Location = new System.Drawing.Point(530, 42);
            this.QualityNumericUpDown.Name = "QualityNumericUpDown";
            this.QualityNumericUpDown.Size = new System.Drawing.Size(58, 22);
            this.QualityNumericUpDown.TabIndex = 15;
            this.QualityNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.QualityNumericUpDown.ValueChanged += new System.EventHandler(this.QualityNumericUpDown_ValueChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(479, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Highest";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Lowest";
            // 
            // QualityTrackBar
            // 
            this.QualityTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QualityTrackBar.Location = new System.Drawing.Point(42, 42);
            this.QualityTrackBar.Maximum = 99;
            this.QualityTrackBar.Name = "QualityTrackBar";
            this.QualityTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QualityTrackBar.Size = new System.Drawing.Size(479, 56);
            this.QualityTrackBar.TabIndex = 9;
            this.QualityTrackBar.TickFrequency = 5;
            this.QualityTrackBar.Value = 20;
            this.QualityTrackBar.Scroll += new System.EventHandler(this.QualityTrackBar_Scroll);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 672);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Using L.A.M.E Encoder";
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb.Enabled = false;
            this.tb.Location = new System.Drawing.Point(180, 616);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(315, 47);
            this.tb.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(18, 632);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Processing Command";
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.PriorityComboBox.Location = new System.Drawing.Point(37, 40);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(121, 24);
            this.PriorityComboBox.TabIndex = 0;
            this.PriorityComboBox.Text = "Normal";
           
            // 
            // PriorityGroupBox
            // 
            this.PriorityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityGroupBox.Controls.Add(this.PriorityComboBox);
            this.PriorityGroupBox.Enabled = false;
            this.PriorityGroupBox.Location = new System.Drawing.Point(239, 191);
            this.PriorityGroupBox.Name = "PriorityGroupBox";
            this.PriorityGroupBox.Size = new System.Drawing.Size(200, 100);
            this.PriorityGroupBox.TabIndex = 6;
            this.PriorityGroupBox.TabStop = false;
            this.PriorityGroupBox.Text = "Priority";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(633, 696);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QualityBox);
            this.Controls.Add(this.BitrateBox);
            this.Controls.Add(this.MonoCheckBox);
            this.Controls.Add(this.PriorityGroupBox);
            this.Controls.Add(this.TargetGroupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "WaveToMp3 Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TargetGroupBox.ResumeLayout(false);
            this.TargetGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateTrackBar)).EndInit();
            this.BitrateBox.ResumeLayout(false);
            this.BitrateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitrateNumericUpDown)).EndInit();
            this.QualityBox.ResumeLayout(false);
            this.QualityBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).EndInit();
            this.PriorityGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button EncodeBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox TargetGroupBox;
        private System.Windows.Forms.RadioButton QualityRadioButton;
        private System.Windows.Forms.RadioButton BitrateRadioButton;
        private System.Windows.Forms.CheckBox MonoCheckBox;
        private System.Windows.Forms.GroupBox QualityBox;
        private System.Windows.Forms.TrackBar QualityTrackBar;
        private System.Windows.Forms.GroupBox BitrateBox;
        private System.Windows.Forms.TrackBar BitrateTrackBar;
        private System.Windows.Forms.CheckBox CBRCheckBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown QualityNumericUpDown;
        private System.Windows.Forms.NumericUpDown BitrateNumericUpDown;
        private System.Windows.Forms.GroupBox PriorityGroupBox;
        private System.Windows.Forms.ComboBox PriorityComboBox;
    }
}

