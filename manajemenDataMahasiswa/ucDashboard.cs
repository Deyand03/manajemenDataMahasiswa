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
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
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

                txtNama.Text = dgvMhs.Rows[e.RowIndex].Cells["nama"].Value?.ToString() ?? "";
                txtNim.Text = dgvMhs.Rows[e.RowIndex].Cells["nim"].Value?.ToString() ?? "";
                txtJurusan.Text = dgvMhs.Rows[e.RowIndex].Cells["jurusan"].Value?.ToString() ?? "";
                txtFakultas.Text = dgvMhs.Rows[e.RowIndex].Cells["fakultas"].Value?.ToString() ?? "";
                txtAngkatan.Text = dgvMhs.Rows[e.RowIndex].Cells["angkatan"].Value?.ToString() ?? "";
                cmbStatus.Text = dgvMhs.Rows[e.RowIndex].Cells["status"].Value?.ToString() ?? "";
                string profilPict = dgvMhs.Rows[e.RowIndex].Cells["foto_profil"].Value?.ToString() ?? "";
                string folderApp = Application.StartupPath;
                string path = Path.Combine(folderApp, "foto_mahasiswa", profilPict);
                if (!string.IsNullOrEmpty(profilPict) && File.Exists(path))
                {
                    LoadImageToPictureBox(imageProfil, path);
                }
                else
                {
                    imageProfil.Image = Properties.Resources.student;
                }
            }
        }
        private void LoadImageToPictureBox(PictureBox pb, string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pb.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb.Image = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat gambar: " + ex.Message);
                pb.Image = null; 
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            DialogResult result = MessageBox.Show("Yakin ingin menghapus data ? ", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    string namaFileFoto = null;
                    conn.Open();
                    string querySelect = "SELECT foto_profil FROM mahasiswa WHERE user_id = @user_id";
                    using(MySqlCommand cmdSelect = new MySqlCommand(querySelect, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@user_id", selectedId);
                        object resultSelect = cmdSelect.ExecuteScalar();
                        if(resultSelect != null && resultSelect != DBNull.Value)
                        {
                            namaFileFoto = resultSelect.ToString();
                        }
                    }
                    if(imageProfil.Image != null)
                    {
                        imageProfil.Image.Dispose();
                        imageProfil.Image = null;
                    }

                    if(!string.IsNullOrEmpty(namaFileFoto))
                    {
                        string pathPict = Path.Combine(Application.StartupPath, "foto_mahasiswa", namaFileFoto);
                        if (File.Exists(pathPict))
                        {
                            File.Delete(pathPict);
                        }
                    }
                    string queryUpdate = "UPDATE mahasiswa SET foto_profil = NULL WHERE user_id = @user_id";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@user_id", selectedId);
                        cmdUpdate.ExecuteNonQuery();
                        imageProfil.Image = Properties.Resources.student;
                    }

                    string queryMhs = "DELETE FROM mahasiswa WHERE user_id = @user_id";
                    using (MySqlCommand cmdDeleteMhs = new MySqlCommand(queryMhs, conn))
                    {
                        cmdDeleteMhs.Parameters.AddWithValue("@user_id", selectedId);
                        cmdDeleteMhs.ExecuteNonQuery();
                    }
                    string queryUsers = "DELETE FROM users WHERE id = @id";
                    using (MySqlCommand cmdDeleteUsers = new MySqlCommand(queryUsers, conn))
                    {
                        cmdDeleteUsers.Parameters.AddWithValue("@id", selectedId);
                        cmdDeleteUsers.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal dihapus: " + ex.Message);
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE mahasiswa SET nim=@nim, nama=@nama, jurusan=@jurusan, fakultas=@fakultas, angkatan=@angkatan, status=@status WHERE user_id=@user_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@nim", txtNim.Text);
                    cmd.Parameters.AddWithValue("@jurusan", txtJurusan.Text);
                    cmd.Parameters.AddWithValue("@fakultas", txtFakultas.Text);
                    cmd.Parameters.AddWithValue("@angkatan", txtAngkatan.Text);
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@user_id", selectedId);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Data Berhasil Diupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR COGG " + ex.Message);
                }

            }
        }
        private void ClearForm()
        {
            txtNama.Clear();
            txtNim.Clear();
            txtJurusan.Clear();
            txtFakultas.Clear();
            txtAngkatan.Clear();
            cmbStatus.Text = "";

            selectedId = -1;
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            FormrReportMahasiswa frm = new FormrReportMahasiswa();
            frm.ShowDialog();
        }
    }
}
