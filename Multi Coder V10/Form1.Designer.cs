namespace Multi_Coder_V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewProgress = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Format = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AudioChannels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Audiostreams = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AudiostreamID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VideoStreamID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colum9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewQue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BoxFrame = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxSpeed = new System.Windows.Forms.ComboBox();
            this.BoxField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxRes = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.BoxBit = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.BoxCodec = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ConsoleTxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label28 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.BtnAddVideo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewProgress);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coding Job";
            // 
            // listViewProgress
            // 
            this.listViewProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.listViewProgress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Format,
            this.SizeR,
            this.Duration,
            this.AudioChannels,
            this.Audiostreams,
            this.AudiostreamID,
            this.VideoStreamID,
            this.colum9,
            this.columnHeader8});
            this.listViewProgress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewProgress.ForeColor = System.Drawing.Color.Gainsboro;
            this.listViewProgress.HideSelection = false;
            this.listViewProgress.Location = new System.Drawing.Point(6, 22);
            this.listViewProgress.Name = "listViewProgress";
            this.listViewProgress.Size = new System.Drawing.Size(1105, 75);
            this.listViewProgress.TabIndex = 1;
            this.listViewProgress.UseCompatibleStateImageBehavior = false;
            this.listViewProgress.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 295;
            // 
            // Format
            // 
            this.Format.Text = "Format";
            // 
            // SizeR
            // 
            this.SizeR.Text = "Size";
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 69;
            // 
            // AudioChannels
            // 
            this.AudioChannels.Text = "Audio Ch(s)";
            this.AudioChannels.Width = 88;
            // 
            // Audiostreams
            // 
            this.Audiostreams.Text = "Audio Stream(s)";
            this.Audiostreams.Width = 120;
            // 
            // AudiostreamID
            // 
            this.AudiostreamID.Text = "Audio Stream ID";
            this.AudiostreamID.Width = 115;
            // 
            // VideoStreamID
            // 
            this.VideoStreamID.Text = "Video Stream ID";
            this.VideoStreamID.Width = 120;
            // 
            // colum9
            // 
            this.colum9.Text = "Aspect";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Progress";
            this.columnHeader8.Width = 111;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewQue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1118, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Que Jobs";
            // 
            // listViewQue
            // 
            this.listViewQue.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewQue.AllowDrop = true;
            this.listViewQue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.listViewQue.BackgroundImage = global::Multi_Coder_V10.Properties.Resources.draging;
            this.listViewQue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewQue.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewQue.ForeColor = System.Drawing.Color.Gainsboro;
            this.listViewQue.HideSelection = false;
            this.listViewQue.Location = new System.Drawing.Point(6, 22);
            this.listViewQue.Name = "listViewQue";
            this.listViewQue.Size = new System.Drawing.Size(1105, 308);
            this.listViewQue.TabIndex = 12;
            this.listViewQue.UseCompatibleStateImageBehavior = false;
            this.listViewQue.View = System.Windows.Forms.View.Details;
            this.listViewQue.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewQue_DragDrop);
            this.listViewQue.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewQue_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 295;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Format";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duration";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Audio Ch(s)";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Audio Stream(s)";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Audio Stream ID";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Video Stream ID";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Aspect";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Progress";
            this.columnHeader11.Width = 111;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.TxtTarget);
            this.groupBox3.Controls.Add(this.BtnBrowse);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(12, 497);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(576, 87);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destination";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label21.ForeColor = System.Drawing.Color.DarkGray;
            this.label21.Location = new System.Drawing.Point(6, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "Target Folder :";
            // 
            // TxtTarget
            // 
            this.TxtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTarget.Enabled = false;
            this.TxtTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarget.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtTarget.Location = new System.Drawing.Point(103, 32);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.Size = new System.Drawing.Size(378, 20);
            this.TxtTarget.TabIndex = 50;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.BtnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBrowse.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("BtnBrowse.Image")));
            this.BtnBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBrowse.Location = new System.Drawing.Point(487, 16);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(83, 65);
            this.BtnBrowse.TabIndex = 56;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BoxFrame);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.BoxSpeed);
            this.groupBox4.Controls.Add(this.BoxField);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.BoxRes);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.BoxBit);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.BoxCodec);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Location = new System.Drawing.Point(12, 599);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(801, 111);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Codec Settings ";
            // 
            // BoxFrame
            // 
            this.BoxFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BoxFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxFrame.ForeColor = System.Drawing.Color.DarkGray;
            this.BoxFrame.FormattingEnabled = true;
            this.BoxFrame.Items.AddRange(new object[] {
            "",
            "25",
            "30"});
            this.BoxFrame.Location = new System.Drawing.Point(646, 36);
            this.BoxFrame.Name = "BoxFrame";
            this.BoxFrame.Size = new System.Drawing.Size(130, 21);
            this.BoxFrame.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(560, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Frame Rate :";
            // 
            // BoxSpeed
            // 
            this.BoxSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BoxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxSpeed.ForeColor = System.Drawing.Color.DarkGray;
            this.BoxSpeed.FormattingEnabled = true;
            this.BoxSpeed.Items.AddRange(new object[] {
            "veryslow",
            "slower",
            "slow",
            "fast",
            "faster",
            "veryfast",
            "superfast",
            "ultrafast"});
            this.BoxSpeed.Location = new System.Drawing.Point(646, 73);
            this.BoxSpeed.Name = "BoxSpeed";
            this.BoxSpeed.Size = new System.Drawing.Size(130, 21);
            this.BoxSpeed.TabIndex = 64;
            // 
            // BoxField
            // 
            this.BoxField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BoxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxField.ForeColor = System.Drawing.Color.DarkGray;
            this.BoxField.FormattingEnabled = true;
            this.BoxField.Items.AddRange(new object[] {
            "Topfield",
            "BottomField",
            "Progressive"});
            this.BoxField.Location = new System.Drawing.Point(366, 73);
            this.BoxField.Name = "BoxField";
            this.BoxField.Size = new System.Drawing.Size(130, 21);
            this.BoxField.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(589, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Speed :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(318, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Field :";
            // 
            // BoxRes
            // 
            this.BoxRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BoxRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxRes.ForeColor = System.Drawing.Color.DarkGray;
            this.BoxRes.FormattingEnabled = true;
            this.BoxRes.Items.AddRange(new object[] {
            "",
            "1920x1080",
            "1280x720",
            "720x576",
            "720x480"});
            this.BoxRes.Location = new System.Drawing.Point(366, 36);
            this.BoxRes.Name = "BoxRes";
            this.BoxRes.Size = new System.Drawing.Size(130, 21);
            this.BoxRes.TabIndex = 58;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label23.ForeColor = System.Drawing.Color.DarkGray;
            this.label23.Location = new System.Drawing.Point(285, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 57;
            this.label23.Text = "Resolution :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label24.ForeColor = System.Drawing.Color.DarkGray;
            this.label24.Location = new System.Drawing.Point(166, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 17);
            this.label24.TabIndex = 56;
            this.label24.Text = "kb\\s";
            // 
            // BoxBit
            // 
            this.BoxBit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BoxBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxBit.ForeColor = System.Drawing.Color.DarkGray;
            this.BoxBit.FormattingEnabled = true;
            this.BoxBit.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "11000",
            "12000",
            "13000",
            "14000",
            "15000"});
            this.BoxBit.Location = new System.Drawing.Point(65, 71);
            this.BoxBit.Name = "BoxBit";
            this.BoxBit.Size = new System.Drawing.Size(95, 21);
            this.BoxBit.TabIndex = 55;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label25.ForeColor = System.Drawing.Color.DarkGray;
            this.label25.Location = new System.Drawing.Point(6, 77);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Bit Rate :";
            // 
            // BoxCodec
            // 
            this.BoxCodec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BoxCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxCodec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BoxCodec.ForeColor = System.Drawing.Color.DarkGray;
            this.BoxCodec.FormattingEnabled = true;
            this.BoxCodec.Items.AddRange(new object[] {
            "XDCAM HD 422 ",
            "H264/AVC",
            "H265/HEVC",
            "WhatsappExport"});
            this.BoxCodec.Location = new System.Drawing.Point(65, 36);
            this.BoxCodec.Name = "BoxCodec";
            this.BoxCodec.Size = new System.Drawing.Size(162, 21);
            this.BoxCodec.TabIndex = 53;
            this.BoxCodec.SelectedIndexChanged += new System.EventHandler(this.BoxCodec_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.label26.ForeColor = System.Drawing.Color.DarkGray;
            this.label26.Location = new System.Drawing.Point(14, 36);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 13);
            this.label26.TabIndex = 52;
            this.label26.Text = "Codec :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.ForeColor = System.Drawing.Color.DarkGray;
            this.label27.Location = new System.Drawing.Point(9, 734);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(81, 13);
            this.label27.TabIndex = 66;
            this.label27.Text = "Console Log:";
            // 
            // ConsoleTxt
            // 
            this.ConsoleTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConsoleTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.ConsoleTxt.Location = new System.Drawing.Point(94, 730);
            this.ConsoleTxt.Name = "ConsoleTxt";
            this.ConsoleTxt.Size = new System.Drawing.Size(1029, 20);
            this.ConsoleTxt.TabIndex = 65;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(993, 756);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 30);
            this.button3.TabIndex = 75;
            this.button3.Text = "Delete Logs";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1.Location = new System.Drawing.Point(606, 767);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(182, 17);
            this.linkLabel1.TabIndex = 78;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "murat@muratdemirci.com.tr";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.ForeColor = System.Drawing.Color.DimGray;
            this.label28.Location = new System.Drawing.Point(9, 769);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(603, 17);
            this.label28.TabIndex = 77;
            this.label28.Text = "Please contact to me, for your requests and feedback - Coded By Murat Demirci / ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start.ForeColor = System.Drawing.Color.DarkGray;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Start.Location = new System.Drawing.Point(957, 630);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(96, 80);
            this.Start.TabIndex = 82;
            this.Start.Text = "Start";
            this.Start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // stop
            // 
            this.stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop.ForeColor = System.Drawing.Color.DarkGray;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stop.Location = new System.Drawing.Point(828, 628);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(96, 80);
            this.stop.TabIndex = 81;
            this.stop.Text = "Stop";
            this.stop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // delete
            // 
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete.ForeColor = System.Drawing.Color.DarkGray;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete.Location = new System.Drawing.Point(717, 504);
            this.delete.Name = "delete";
            this.delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delete.Size = new System.Drawing.Size(96, 80);
            this.delete.TabIndex = 80;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // BtnAddVideo
            // 
            this.BtnAddVideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAddVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAddVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAddVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddVideo.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnAddVideo.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddVideo.Image")));
            this.BtnAddVideo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddVideo.Location = new System.Drawing.Point(604, 504);
            this.BtnAddVideo.Name = "BtnAddVideo";
            this.BtnAddVideo.Size = new System.Drawing.Size(96, 80);
            this.BtnAddVideo.TabIndex = 79;
            this.BtnAddVideo.Text = "Add Video";
            this.BtnAddVideo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddVideo.UseVisualStyleBackColor = true;
            this.BtnAddVideo.Click += new System.EventHandler(this.BtnAddVideo_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 8);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1118, 23);
            this.progressBar1.TabIndex = 83;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1140, 803);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.BtnAddVideo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.ConsoleTxt);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coder V 10";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewProgress;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Format;
        private System.Windows.Forms.ColumnHeader SizeR;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader AudioChannels;
        private System.Windows.Forms.ColumnHeader Audiostreams;
        private System.Windows.Forms.ColumnHeader AudiostreamID;
        private System.Windows.Forms.ColumnHeader VideoStreamID;
        private System.Windows.Forms.ColumnHeader colum9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listViewQue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TxtTarget;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox BoxRes;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox BoxBit;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox BoxCodec;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox ConsoleTxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button BtnAddVideo;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog BrowseDialog;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxSpeed;
        private System.Windows.Forms.ComboBox BoxField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BoxFrame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

