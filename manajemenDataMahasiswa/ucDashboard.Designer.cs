namespace manajemenDataMahasiswa
{
    partial class ucDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelJmlhMhs = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMhs = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJmlhAktif = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJmlhNonaktif = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageProfil = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelNamaMhs = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelNim = new System.Windows.Forms.Label();
            this.labelIPK = new System.Windows.Forms.Label();
            this.labelJurusan = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfil)).BeginInit();
            this.labelNamaMhs.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.labelJmlhMhs);
            this.guna2Panel4.Controls.Add(this.label0);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(208)))));
            this.guna2Panel4.Location = new System.Drawing.Point(13, 71);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(337, 127);
            this.guna2Panel4.TabIndex = 6;
            // 
            // labelJmlhMhs
            // 
            this.labelJmlhMhs.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelJmlhMhs.AutoSize = true;
            this.labelJmlhMhs.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJmlhMhs.ForeColor = System.Drawing.Color.White;
            this.labelJmlhMhs.Location = new System.Drawing.Point(15, 65);
            this.labelJmlhMhs.Name = "labelJmlhMhs";
            this.labelJmlhMhs.Size = new System.Drawing.Size(43, 53);
            this.labelJmlhMhs.TabIndex = 1;
            this.labelJmlhMhs.Text = "0";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.Color.White;
            this.label0.Location = new System.Drawing.Point(18, 20);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(216, 36);
            this.label0.TabIndex = 0;
            this.label0.Text = "Jumlah Mahasiswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manajemen Data Mahasiswa";
            // 
            // dgvMhs
            // 
            this.dgvMhs.BackgroundColor = System.Drawing.Color.White;
            this.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMhs.Location = new System.Drawing.Point(31, 88);
            this.dgvMhs.Name = "dgvMhs";
            this.dgvMhs.RowHeadersWidth = 51;
            this.dgvMhs.RowTemplate.Height = 24;
            this.dgvMhs.Size = new System.Drawing.Size(674, 371);
            this.dgvMhs.TabIndex = 9;
            this.dgvMhs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMhs_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.btnRefresh);
            this.guna2Panel1.Controls.Add(this.btnNext);
            this.guna2Panel1.Controls.Add(this.btnPrev);
            this.guna2Panel1.Controls.Add(this.lblPageInfo);
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.cmbFilterBy);
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.dgvMhs);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 216);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1101, 530);
            this.guna2Panel1.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BorderRadius = 6;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(208)))));
            this.btnRefresh.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(31, 465);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(162, 37);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.TextOffset = new System.Drawing.Point(0, 2);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.BorderRadius = 6;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(208)))));
            this.btnNext.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnNext.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(462, 465);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 37);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.TextOffset = new System.Drawing.Point(0, 2);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Animated = true;
            this.btnPrev.BorderRadius = 6;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(208)))));
            this.btnPrev.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnPrev.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(369, 465);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(78, 37);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextOffset = new System.Drawing.Point(0, 2);
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.lblPageInfo.Location = new System.Drawing.Point(570, 465);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(135, 26);
            this.lblPageInfo.TabIndex = 14;
            this.lblPageInfo.Text = "Halaman 1 dari 1";
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 6;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(208)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(627, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 39);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterBy.Font = new System.Drawing.Font("Poppins", 11F);
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "Nim",
            "Nama",
            "Jurusan",
            "Fakultas",
            "Angkatan",
            "Status"});
            this.cmbFilterBy.Location = new System.Drawing.Point(472, 26);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(149, 39);
            this.cmbFilterBy.TabIndex = 12;
            this.cmbFilterBy.Text = "Nim";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::manajemenDataMahasiswa.Properties.Resources.search;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.Location = new System.Drawing.Point(31, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Cari berdasarkan ...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(434, 52);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.labelNamaMhs);
            this.guna2Panel2.Controls.Add(this.imageProfil);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(735, 18);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(340, 441);
            this.guna2Panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student View";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.lblJmlhAktif);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(208)))));
            this.guna2Panel3.Location = new System.Drawing.Point(356, 71);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(337, 127);
            this.guna2Panel3.TabIndex = 7;
            // 
            // lblJmlhAktif
            // 
            this.lblJmlhAktif.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblJmlhAktif.AutoSize = true;
            this.lblJmlhAktif.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmlhAktif.ForeColor = System.Drawing.Color.White;
            this.lblJmlhAktif.Location = new System.Drawing.Point(15, 65);
            this.lblJmlhAktif.Name = "lblJmlhAktif";
            this.lblJmlhAktif.Size = new System.Drawing.Size(43, 53);
            this.lblJmlhAktif.TabIndex = 1;
            this.lblJmlhAktif.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jumlah Mahasiswa Aktif";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.BorderThickness = 2;
            this.guna2Panel5.Controls.Add(this.lblJmlhNonaktif);
            this.guna2Panel5.Controls.Add(this.label6);
            this.guna2Panel5.Location = new System.Drawing.Point(699, 71);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(376, 127);
            this.guna2Panel5.TabIndex = 8;
            // 
            // lblJmlhNonaktif
            // 
            this.lblJmlhNonaktif.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblJmlhNonaktif.AutoSize = true;
            this.lblJmlhNonaktif.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmlhNonaktif.ForeColor = System.Drawing.Color.Black;
            this.lblJmlhNonaktif.Location = new System.Drawing.Point(15, 65);
            this.lblJmlhNonaktif.Name = "lblJmlhNonaktif";
            this.lblJmlhNonaktif.Size = new System.Drawing.Size(43, 53);
            this.lblJmlhNonaktif.TabIndex = 1;
            this.lblJmlhNonaktif.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jumlah Mahasiswa Tidak Aktif";
            // 
            // imageProfil
            // 
            this.imageProfil.BackColor = System.Drawing.Color.Transparent;
            this.imageProfil.Image = global::manajemenDataMahasiswa.Properties.Resources.student;
            this.imageProfil.ImageRotate = 0F;
            this.imageProfil.Location = new System.Drawing.Point(111, 47);
            this.imageProfil.Name = "imageProfil";
            this.imageProfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imageProfil.Size = new System.Drawing.Size(125, 109);
            this.imageProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageProfil.TabIndex = 4;
            this.imageProfil.TabStop = false;
            this.imageProfil.UseTransparentBackground = true;
            // 
            // labelNamaMhs
            // 
            this.labelNamaMhs.Controls.Add(this.labelStatus);
            this.labelNamaMhs.Controls.Add(this.labelJurusan);
            this.labelNamaMhs.Controls.Add(this.labelIPK);
            this.labelNamaMhs.Controls.Add(this.labelNim);
            this.labelNamaMhs.Font = new System.Drawing.Font("Poppins SemiBold", 11F);
            this.labelNamaMhs.ForeColor = System.Drawing.Color.DimGray;
            this.labelNamaMhs.Location = new System.Drawing.Point(0, 175);
            this.labelNamaMhs.Name = "labelNamaMhs";
            this.labelNamaMhs.Size = new System.Drawing.Size(340, 266);
            this.labelNamaMhs.TabIndex = 6;
            this.labelNamaMhs.Text = "Nama Mahasiswa";
            this.labelNamaMhs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNim
            // 
            this.labelNim.AutoSize = true;
            this.labelNim.Location = new System.Drawing.Point(3, 40);
            this.labelNim.Name = "labelNim";
            this.labelNim.Size = new System.Drawing.Size(69, 34);
            this.labelNim.TabIndex = 0;
            this.labelNim.Text = "Nim : ";
            // 
            // labelIPK
            // 
            this.labelIPK.AutoSize = true;
            this.labelIPK.Location = new System.Drawing.Point(3, 142);
            this.labelIPK.Name = "labelIPK";
            this.labelIPK.Size = new System.Drawing.Size(149, 34);
            this.labelIPK.TabIndex = 1;
            this.labelIPK.Text = "IPK (saat ini) :";
            // 
            // labelJurusan
            // 
            this.labelJurusan.AutoSize = true;
            this.labelJurusan.Location = new System.Drawing.Point(3, 74);
            this.labelJurusan.Name = "labelJurusan";
            this.labelJurusan.Size = new System.Drawing.Size(106, 34);
            this.labelJurusan.TabIndex = 2;
            this.labelJurusan.Text = "Jurusan :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(3, 108);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(87, 34);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status :";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1101, 746);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfil)).EndInit();
            this.labelNamaMhs.ResumeLayout(false);
            this.labelNamaMhs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label labelJmlhMhs;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMhs;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private Guna.UI2.WinForms.Guna2GradientButton btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnRefresh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblJmlhAktif;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label lblJmlhNonaktif;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imageProfil;
        private Guna.UI2.WinForms.Guna2GroupBox labelNamaMhs;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelJurusan;
        private System.Windows.Forms.Label labelIPK;
        private System.Windows.Forms.Label labelNim;
    }
}
