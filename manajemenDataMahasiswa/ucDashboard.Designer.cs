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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMhs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelJmlhMhs = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cariBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(50, 841);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(190, 56);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "p";
            // 
            // dgvMhs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMhs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMhs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMhs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMhs.ColumnHeadersHeight = 4;
            this.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMhs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMhs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMhs.Location = new System.Drawing.Point(50, 355);
            this.dgvMhs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMhs.Name = "dgvMhs";
            this.dgvMhs.RowHeadersVisible = false;
            this.dgvMhs.RowHeadersWidth = 51;
            this.dgvMhs.RowTemplate.Height = 24;
            this.dgvMhs.Size = new System.Drawing.Size(1047, 456);
            this.dgvMhs.TabIndex = 7;
            this.dgvMhs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMhs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMhs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMhs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMhs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMhs.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.dgvMhs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMhs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMhs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMhs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMhs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMhs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMhs.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvMhs.ThemeStyle.ReadOnly = false;
            this.dgvMhs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMhs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMhs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMhs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMhs.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMhs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMhs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel4.BorderRadius = 8;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.labelJmlhMhs);
            this.guna2Panel4.Controls.Add(this.label0);
            this.guna2Panel4.Location = new System.Drawing.Point(50, 104);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(379, 159);
            this.guna2Panel4.TabIndex = 6;
            // 
            // labelJmlhMhs
            // 
            this.labelJmlhMhs.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelJmlhMhs.AutoSize = true;
            this.labelJmlhMhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJmlhMhs.ForeColor = System.Drawing.Color.White;
            this.labelJmlhMhs.Location = new System.Drawing.Point(20, 84);
            this.labelJmlhMhs.Name = "labelJmlhMhs";
            this.labelJmlhMhs.Size = new System.Drawing.Size(38, 40);
            this.labelJmlhMhs.TabIndex = 1;
            this.labelJmlhMhs.Text = "0";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label0.Location = new System.Drawing.Point(20, 25);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(232, 29);
            this.label0.TabIndex = 0;
            this.label0.Text = "Jumlah Mahasiswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manajemen Data Mahasiswa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cariBtn
            // 
            this.cariBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cariBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cariBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cariBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cariBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(30)))), ((int)(((byte)(85)))));
            this.cariBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cariBtn.ForeColor = System.Drawing.Color.White;
            this.cariBtn.Location = new System.Drawing.Point(960, 296);
            this.cariBtn.Name = "cariBtn";
            this.cariBtn.Size = new System.Drawing.Size(137, 38);
            this.cariBtn.TabIndex = 13;
            this.cariBtn.Text = "Cari";
            this.cariBtn.Click += new System.EventHandler(this.cariBtn_Click);
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "NIM",
            "Nama",
            "Jurusan",
            "Fakultas",
            "Angkatan",
            "Status"});
            this.cmbFilterBy.Location = new System.Drawing.Point(50, 306);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(252, 28);
            this.cmbFilterBy.TabIndex = 14;
            this.cmbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBy_SelectedIndexChanged);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(347, 306);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(577, 26);
            this.txtCari.TabIndex = 15;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cmbFilterBy);
            this.Controls.Add(this.cariBtn);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dgvMhs);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(1140, 934);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMhs;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label labelJmlhMhs;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button cariBtn;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.TextBox txtCari;
    }
}
