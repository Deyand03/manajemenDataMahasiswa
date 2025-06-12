using MySql.Data.MySqlClient;
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
    public partial class FormDashboardAdmin : Form
    {
        private int selectedId = -1;
        public FormDashboardAdmin()
        {
            InitializeComponent();
            LoadUserControl(new ucDashboard());
        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void LoadUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(userControl);
        }



        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucDashboard());
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnData.Height;
            pnlNav.Top = btnData.Top;
            pnlNav.Left = btnData.Left;
            btnData.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRegis.Height;
            pnlNav.Top = btnRegis.Top;
            pnlNav.Left = btnRegis.Left;
            btnRegis.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnData_Leave(object sender, EventArgs e)
        {
            btnData.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnRegis_Leave(object sender, EventArgs e)
        {
            btnRegis.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvMhs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
