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
                    dgvMhs.Columns["user_id"].HeaderText = "ID";
                    dgvMhs.Columns["user_id"].Visible = false;

                    dgvMhs.Columns["nim"].HeaderText = "NIM";
                    dgvMhs.Columns["nama"].HeaderText = "Nama";
                    dgvMhs.Columns["jurusan"].HeaderText = "Jurusan";
                    dgvMhs.Columns["fakultas"].HeaderText = "Fakultas";
                    dgvMhs.Columns["angkatan"].HeaderText = "Angkatan";
                    dgvMhs.Columns["status"].HeaderText = "Status";


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFilteredBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
