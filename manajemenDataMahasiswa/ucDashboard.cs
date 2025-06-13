using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manajemenDataMahasiswa
{
    public partial class ucDashboard : UserControl
    {
        int selectedId = -1;

        int pageSize = 12;
        int currentPage = 1;
        int totalPages = 1;
        int totalRecords = 0;

        bool isFiltered = false;
        public ucDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            TampilkanJumlahMahasiswa();
            currentPage = 1;
            isFiltered = false;
            TampilkanDataDefault();
            TampilanStudentView();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void TampilkanJumlahMahasiswa()
        {
            string query = "SELECT COUNT(*) FROM mahasiswa";
            string queryAktif = "SELECT COUNT(status) FROM mahasiswa WHERE status = 'aktif';";
            string queryNonaktif = "SELECT COUNT(status) FROM mahasiswa WHERE status = 'tidak_aktif';";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            labelJmlhMhs.Text = result.ToString();
                        }
                    }
                    using (MySqlCommand cmd = new MySqlCommand(queryAktif, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if(result != null)
                        {
                            lblJmlhAktif.Text = result.ToString();
                        }
                    }
                    using (MySqlCommand cmd = new MySqlCommand(queryNonaktif, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            lblJmlhNonaktif.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data mahasiswa. \nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelJmlhMhs.Text = "N/A";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            isFiltered = true;
            TampilkanDataFiltered();
        }

        private void TampilkanDataFiltered()
        {
            string kolom = cmbFilterBy.SelectedItem?.ToString();
            string keyword = txtSearch.Text.Trim();

            string kolomDb = "nim";
            if (kolom == "Nama") kolomDb = "nama";
            else if (kolom == "Jurusan") kolomDb = "jurusan";
            else if (kolom == "Fakultas") kolomDb = "fakultas";
            else if (kolom == "Angkatan") kolomDb = "angkatan";
            else if (kolom == "Status") kolomDb = "status";


            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();

                    string countQuery = $"SELECT COUNT(*) FROM mahasiswa WHERE {kolomDb} LIKE @keyword";
                    using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                    {
                        countCmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
                        totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                        totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                        if (currentPage > totalPages) currentPage = totalPages;
                        if (currentPage < 1) currentPage = 1;

                    }

                    int offset = (currentPage - 1) * pageSize;

                    string query = $"SELECT * FROM mahasiswa WHERE {kolomDb} LIKE @keyword ORDER BY nim ASC " +
                                   $"LIMIT @limit OFFSET @offset";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
                        cmd.Parameters.AddWithValue("@limit", pageSize);
                        cmd.Parameters.AddWithValue("@offset", offset);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMhs.DataSource = dt;

                        lblPageInfo.Text = $"Halaman {currentPage} dari {totalPages}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ini error nya : " + ex.Message);
                }

            }
        }

        private void TampilkanDataDefault()
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string countQuery = "SELECT COUNT(*) FROM mahasiswa";
                    MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                    totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());

                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if(currentPage > totalPages) currentPage = totalPages;
                    if(currentPage < 1) currentPage = 1;

                    int offset = (currentPage - 1) * pageSize;

                    string query = "SELECT * FROM mahasiswa ORDER BY nim ASC LIMIT @limit OFFSET @offset";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@limit", pageSize);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMhs.DataSource= dt;
                    dgvMhs.Columns["user_id"].HeaderText = "ID";
                    dgvMhs.Columns["user_id"].Visible = false;

                    dgvMhs.Columns["nim"].HeaderText = "NIM";
                    dgvMhs.Columns["nama"].HeaderText = "Nama";
                    dgvMhs.Columns["jurusan"].HeaderText = "Jurusan";
                    dgvMhs.Columns["fakultas"].HeaderText = "Fakultas";
                    dgvMhs.Columns["angkatan"].HeaderText = "Angkatan";
                    dgvMhs.Columns["status"].HeaderText = "Status";
                    dgvMhs.Columns["foto_profil"].Visible = false;

                    lblPageInfo.Text = $"Halaman {currentPage} dari {totalPages}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Broo Error: " + ex.Message);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currentPage < totalPages)
            {
                currentPage++;
                if (isFiltered) TampilkanDataFiltered();
                else TampilkanDataDefault();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(currentPage > 1)
            {
                currentPage--;
                if(isFiltered) TampilkanDataFiltered();
                else TampilkanDataDefault();
            }
        }

        private void dgvMhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                object valueSelectedId = dgvMhs.Rows[e.RowIndex].Cells["user_id"].Value;
                selectedId = (valueSelectedId != null && valueSelectedId != DBNull.Value) ? Convert.ToInt32(valueSelectedId) : -1;

                labelNamaMhs.Text = dgvMhs.Rows[e.RowIndex].Cells["nama"].Value?.ToString() ?? "";
                string nim = dgvMhs.Rows[e.RowIndex].Cells["nim"].Value?.ToString() ?? "";
                string jurusan = dgvMhs.Rows[e.RowIndex].Cells["jurusan"].Value?.ToString() ?? "";
                string status = dgvMhs.Rows[e.RowIndex].Cells["status"].Value?.ToString() ?? "";

                labelNim.Text = $"Nim : {nim}";
                labelJurusan.Text = $"Jurusan : {jurusan}";
                labelStatus.Text = $"Status : {status}";
            }
        }
        private void TampilanStudentView()
        {
            string pictMhs = "student.png";
            string folderApp = Application.StartupPath;
            string path = Path.Combine(folderApp, "foto_profil", pictMhs);
            if(!string.IsNullOrEmpty(pictMhs) && File.Exists(path))
            {
                imageProfil.Image = Image.FromFile(path);
            }
            else
            {
                imageProfil.Image = Properties.Resources.student;
            }
        }
    }
}
