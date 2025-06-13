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
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            TampilkanJumlahMahasiswa();


            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM mahasiswa";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMhs.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Load Data: " + ex.Message);
                }

            }
        }

        private void TampilkanJumlahMahasiswa()
        {
            string query = "SELECT COUNT(*) FROM mahasiswa";
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data mahasiswa. \nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelJmlhMhs.Text = "N/A";
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cariBtn_Click(object sender, EventArgs e)
        {
            TampilkanDataFiltered();
        }

        private void TampilkanDataFiltered()
        {

            string kolom = cmbFilterBy.SelectedItem?.ToString();
            string keyword = txtCari.Text.Trim();

            string kolomDB = "NIM";
            if (kolom == "Nama") kolomDB = "nama";
            else if (kolom == "Jurusan") kolomDB = "jurusan";
            else if (kolom == "Fakultas") kolomDB = "fakultas";
            else if (kolom == "Angkatan") kolomDB = "angkatan";
            else if (kolom == "Status") kolomDB = "status";

            string query = $"SELECT * FROM mahasiswa WHERE {kolomDB} LIKE @keyword ORDER BY user_id DESC";

            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnStr))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvMhs.DataSource = dt;
            }

        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
