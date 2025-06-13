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
            this.btnCetak = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNamaMhs = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAngkatan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFakultas = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJurusan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNim = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelJurusan = new System.Windows.Forms.Label();
            this.labelNim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJmlhAktif = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblJmlhNonaktif = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageProfil = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.labelNamaMhs.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfil)).BeginInit();
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
            this.guna2Panel1.Controls.Add(this.btnCetak);
            this.guna2Panel1.Controls.Add(this.btnUpdate);
            this.guna2Panel1.Controls.Add(this.btnDelete);
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
            // btnCetak
            // 
            this.btnCetak.Animated = true;
            this.btnCetak.BorderRadius = 6;
            this.btnCetak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCetak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCetak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCetak.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCetak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCetak.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(208)))));
            this.btnCetak.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnCetak.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Location = new System.Drawing.Point(217, 465);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(122, 37);
            this.btnCetak.TabIndex = 20;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.TextOffset = new System.Drawing.Point(0, 2);
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BorderRadius = 6;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.FillColor2 = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(735, 465);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 37);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Data";
            this.btnUpdate.TextOffset = new System.Drawing.Point(0, 2);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 6;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Brown;
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(933, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 37);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Data";
            this.btnDelete.TextOffset = new System.Drawing.Point(0, 2);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.guna2Panel2.Controls.Add(this.imageProfil);
            this.guna2Panel2.Controls.Add(this.labelNamaMhs);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(735, 18);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(340, 441);
            this.guna2Panel2.TabIndex = 10;
            // 
            // labelNamaMhs
            // 
            this.labelNamaMhs.Controls.Add(this.cmbStatus);
            this.labelNamaMhs.Controls.Add(this.label7);
            this.labelNamaMhs.Controls.Add(this.label5);
            this.labelNamaMhs.Controls.Add(this.txtAngkatan);
            this.labelNamaMhs.Controls.Add(this.txtFakultas);
            this.labelNamaMhs.Controls.Add(this.txtJurusan);
            this.labelNamaMhs.Controls.Add(this.txtNama);
            this.labelNamaMhs.Controls.Add(this.label3);
            this.labelNamaMhs.Controls.Add(this.txtNim);
            this.labelNamaMhs.Controls.Add(this.labelStatus);
            this.labelNamaMhs.Controls.Add(this.labelJurusan);
            this.labelNamaMhs.Controls.Add(this.labelNim);
            this.labelNamaMhs.Font = new System.Drawing.Font("Poppins SemiBold", 11F);
            this.labelNamaMhs.ForeColor = System.Drawing.Color.DimGray;
            this.labelNamaMhs.Location = new System.Drawing.Point(0, 175);
            this.labelNamaMhs.Name = "labelNamaMhs";
            this.labelNamaMhs.Size = new System.Drawing.Size(340, 266);
            this.labelNamaMhs.TabIndex = 6;
            this.labelNamaMhs.Text = "Biodata Mahasiswa";
            this.labelNamaMhs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Poppins", 8F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "aktif",
            "tidak_aktif"});
            this.cmbStatus.Location = new System.Drawing.Point(125, 224);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(212, 31);
            this.cmbStatus.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label7.Location = new System.Drawing.Point(3, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Angkatan :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fakultas  :";
            // 
            // txtAngkatan
            // 
            this.txtAngkatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAngkatan.DefaultText = "";
            this.txtAngkatan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAngkatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAngkatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAngkatan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAngkatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAngkatan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngkatan.ForeColor = System.Drawing.Color.Black;
            this.txtAngkatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAngkatan.Location = new System.Drawing.Point(125, 192);
            this.txtAngkatan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAngkatan.Name = "txtAngkatan";
            this.txtAngkatan.PlaceholderText = "";
            this.txtAngkatan.SelectedText = "";
            this.txtAngkatan.Size = new System.Drawing.Size(215, 24);
            this.txtAngkatan.TabIndex = 9;
            // 
            // txtFakultas
            // 
            this.txtFakultas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFakultas.DefaultText = "";
            this.txtFakultas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFakultas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFakultas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFakultas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFakultas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFakultas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFakultas.ForeColor = System.Drawing.Color.Black;
            this.txtFakultas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFakultas.Location = new System.Drawing.Point(125, 157);
            this.txtFakultas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFakultas.Name = "txtFakultas";
            this.txtFakultas.PlaceholderText = "";
            this.txtFakultas.SelectedText = "";
            this.txtFakultas.Size = new System.Drawing.Size(212, 25);
            this.txtFakultas.TabIndex = 8;
            // 
            // txtJurusan
            // 
            this.txtJurusan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJurusan.DefaultText = "";
            this.txtJurusan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJurusan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJurusan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJurusan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJurusan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJurusan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJurusan.ForeColor = System.Drawing.Color.Black;
            this.txtJurusan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJurusan.Location = new System.Drawing.Point(125, 123);
            this.txtJurusan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJurusan.Name = "txtJurusan";
            this.txtJurusan.PlaceholderText = "";
            this.txtJurusan.SelectedText = "";
            this.txtJurusan.Size = new System.Drawing.Size(212, 26);
            this.txtJurusan.TabIndex = 7;
            // 
            // txtNama
            // 
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(125, 89);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(212, 26);
            this.txtNama.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nim : ";
            // 
            // txtNim
            // 
            this.txtNim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNim.DefaultText = "";
            this.txtNim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNim.ForeColor = System.Drawing.Color.Black;
            this.txtNim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNim.Location = new System.Drawing.Point(125, 55);
            this.txtNim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNim.Name = "txtNim";
            this.txtNim.PlaceholderText = "";
            this.txtNim.SelectedText = "";
            this.txtNim.Size = new System.Drawing.Size(212, 26);
            this.txtNim.TabIndex = 4;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.labelStatus.Location = new System.Drawing.Point(4, 225);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(87, 34);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status :";
            // 
            // labelJurusan
            // 
            this.labelJurusan.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.labelJurusan.Location = new System.Drawing.Point(4, 123);
            this.labelJurusan.Name = "labelJurusan";
            this.labelJurusan.Size = new System.Drawing.Size(105, 26);
            this.labelJurusan.TabIndex = 2;
            this.labelJurusan.Text = "Jurusan :";
            // 
            // labelNim
            // 
            this.labelNim.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.labelNim.Location = new System.Drawing.Point(4, 89);
            this.labelNim.Name = "labelNim";
            this.labelNim.Size = new System.Drawing.Size(106, 26);
            this.labelNim.TabIndex = 0;
            this.labelNim.Text = "Nama :";
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
            this.imageProfil.Location = new System.Drawing.Point(46, 54);
            this.imageProfil.Name = "imageProfil";
            this.imageProfil.Size = new System.Drawing.Size(248, 115);
            this.imageProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageProfil.TabIndex = 7;
            this.imageProfil.TabStop = false;
            this.imageProfil.UseTransparentBackground = true;
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
            this.labelNamaMhs.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProfil)).EndInit();
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
        private Guna.UI2.WinForms.Guna2GroupBox labelNamaMhs;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelJurusan;
        private System.Windows.Forms.Label labelNim;
        private Guna.UI2.WinForms.Guna2TextBox txtNim;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtAngkatan;
        private Guna.UI2.WinForms.Guna2TextBox txtFakultas;
        private Guna.UI2.WinForms.Guna2TextBox txtJurusan;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnCetak;
        private Guna.UI2.WinForms.Guna2PictureBox imageProfil;
    }
}
