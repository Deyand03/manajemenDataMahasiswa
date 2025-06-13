using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manajemenDataMahasiswa
{
    public partial class ucRegistrasiMahasiswa : UserControl
    {
        private string pathPict = null; 
        public ucRegistrasiMahasiswa()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nameFilePict = null;
            if (pathPict != null)
            {
                try
                {
                    string nim = txtNim.Text;
                    string format = Path.GetExtension(pathPict);
                    nameFilePict = nim + format;

                    string folderPath = Path.Combine(Application.StartupPath, "foto_mahasiswa");

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string pathNewPict = Path.Combine(folderPath, nameFilePict);
                    File.Copy(pathPict, pathNewPict, true);

                    if (!string.IsNullOrEmpty(nameFilePict) && File.Exists(pathNewPict))
                    {
                        LoadImageToPictureBox(pictMhs, pathNewPict);
                    }
                    else
                    {
                        pictMhs.Image = Properties.Resources.student;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan gambar : " + ex.Message);
                    return;
                }
            }
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();
                try
                {
                    string userSql = "INSERT INTO users (email, password, role) VALUES (@email, @password, 'mahasiswa');";

                    MySqlCommand userCmd = new MySqlCommand(userSql, conn, transaction);
                    userCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    userCmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(txtPassword.Text));

                    userCmd.ExecuteNonQuery();

                    long newId = userCmd.LastInsertedId;
                    if(newId <= 0)
                    {
                        throw new InvalidOperationException("Gagal membuat user baru");
                    }


                    string mhsSql = "INSERT INTO mahasiswa (nim, nama, jurusan, fakultas, angkatan, status, foto_profil, user_id)" +
                        "VALUES (@nim, @nama, @jurusan, @fakultas, @angkatan, @status, @foto_profil, @userId);";

                    MySqlCommand mhsCmd = new MySqlCommand(mhsSql, conn, transaction);
                    mhsCmd.Parameters.AddWithValue("@nim", txtNim.Text);
                    mhsCmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    mhsCmd.Parameters.AddWithValue("@jurusan", txtJurusan.Text);
                    mhsCmd.Parameters.AddWithValue("@fakultas", txtFakultas.Text);
                    mhsCmd.Parameters.AddWithValue("@angkatan", txtAngkatan.Text);
                    mhsCmd.Parameters.AddWithValue("@status", "aktif");
                    mhsCmd.Parameters.AddWithValue("@userId", newId);
                    mhsCmd.Parameters.AddWithValue("@foto_profil", (object)nameFilePict ?? DBNull.Value);

                    mhsCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show($"Data Berhasil Di Simpan\n User Berhasil Dibuat dengan ID: {newId}");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Error: " + ex.Message);
                }
            }
        }
        private void LoadImageToPictureBox(PictureBox pb, string imagePath)
        {
            try
            {
                // Cek dulu apakah file ada
                if (File.Exists(imagePath))
                {
                    // Baca semua byte dari file ke memory
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    // Buat MemoryStream dari byte tersebut
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        // Set gambar di PictureBox dari MemoryStream
                        pb.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Set gambar default jika file tidak ditemukan
                    pb.Image = null; // atau Properties.Resources.gambar_default
                }
            }
            catch (Exception ex)
            {
                // Tangani jika ada error saat memuat gambar
                MessageBox.Show("Gagal memuat gambar: " + ex.Message);
                pb.Image = null; // atau gambar error
            }
        }
        private void ClearForm()
        {
            txtNim.Clear();
            txtNama.Clear();
            txtJurusan.Clear();
            txtFakultas.Clear();
            txtAngkatan.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAddPict_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                ofd.Title = "Pilih Foto";

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pathPict = ofd.FileName;
                    pictMhs.Image = Image.FromFile(pathPict);
                }
            }
        }
    }
}
