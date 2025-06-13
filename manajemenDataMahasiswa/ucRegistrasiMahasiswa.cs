using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public ucRegistrasiMahasiswa()
        {
            InitializeComponent();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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


                    string mhsSql = "INSERT INTO mahasiswa (nim, nama, jurusan, fakultas, angkatan, status, user_id)" +
                        "VALUES (@nim, @nama, @jurusan, @fakultas, @angkatan, @status, @userId);";

                    MySqlCommand mhsCmd = new MySqlCommand(mhsSql, conn, transaction);
                    mhsCmd.Parameters.AddWithValue("@nim", txtNim.Text);
                    mhsCmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    mhsCmd.Parameters.AddWithValue("@jurusan", txtJurusan.Text);
                    mhsCmd.Parameters.AddWithValue("@fakultas", txtFakultas.Text);
                    mhsCmd.Parameters.AddWithValue("@angkatan", txtAngkatan.Text);
                    mhsCmd.Parameters.AddWithValue("@status", "aktif");
                    mhsCmd.Parameters.AddWithValue("@userId", newId);

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
    }
}
