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

namespace manajemenDataMahasiswa
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
            LoadData();
            LoadUserControl(new ucDashboard());
        }


        private void LoadUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(userControl);
        }

        private void LoadData()
        {
            labelNama.Text = UserSession.Nama;

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(255, 245, 245);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucDashboard());
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(255, 245, 245);
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucRegistrasiMahasiswa());
            pnlNav.Height = btnRegis.Height;
            pnlNav.Top = btnRegis.Top;
            pnlNav.Left = btnRegis.Left;
            btnRegis.BackColor = Color.FromArgb(255, 245, 245);
            btnDashboard.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnRegis_Leave(object sender, EventArgs e)
        {
            btnRegis.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Yakin Ingin Logout?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            UserSession.EndSession();
            FormLogin frmLogin = new FormLogin();
            this.Close();
            frmLogin.Show();
        }

    }
}
