using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manajemenDataMahasiswa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan password harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Format email yang Anda masukkan tidak valid.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, password, role FROM users WHERE email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hashFromDb = reader.GetString("password");
                        string userRole = reader.GetString("role");
                        string id = reader.GetString("id");
                        bool isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDb);

                        reader.Close();
                        if (isValid)
                        {
                            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            if (userRole == "mahasiswa")
                            {
                                string queryMhs = "SELECT nama, nim FROM mahasiswa WHERE user_id = @id";
                                MySqlCommand cmdMhs = new MySqlCommand(queryMhs, conn);
                                cmdMhs.Parameters.AddWithValue("@id", id);
                                MySqlDataReader readerMhs = cmdMhs.ExecuteReader();
                                if(readerMhs.Read())
                                {
                                    string nama = readerMhs.GetString("nama");
                                    string nim = readerMhs.GetString("nim");

                                    UserSession.StartSession(nama, email, null, nim);
                                    FormDashboardMahasiswa frmmhs = new FormDashboardMahasiswa();
                                    this.Hide();
                                    frmmhs.Show();
                                }
                                else
                                {
                                    MessageBox.Show($"user_id: {id}, tidak ada");
                                }
                            }
                            else if(userRole == "admin")
                            {
                                string queryDos = "SELECT nama, nip FROM dosen WHERE user_id = @id";
                                MySqlCommand cmdDos = new MySqlCommand(queryDos, conn);
                                cmdDos.Parameters.AddWithValue("@id", id);
                                MySqlDataReader readerDos = cmdDos.ExecuteReader();
                                if (readerDos.Read())
                                {
                                    string nama = readerDos.GetString("nama");
                                    string nip = readerDos.GetString("nip");

                                    UserSession.StartSession(nama, email, nip, null);
                                    FormDashboardAdmin frmadmin = new FormDashboardAdmin();
                                    this.Hide();
                                    frmadmin.Show();
                                }
                                else
                                {
                                    MessageBox.Show($"user_id: {id}, tidak ada");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email atau password yang Anda masukkan salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email Atau!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Kesalahan koneksi:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowHide.Image = Properties.Resources.eye_hide;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowHide.Image= Properties.Resources.eye_show;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
