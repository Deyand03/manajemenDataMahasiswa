using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace manajemenDataMahasiswa
{
    public static class ThemeManager
    {
        public enum Theme { Light, Dark }

        // Properti untuk menyimpan tema saat ini
        public static Theme CurrentTheme { get; private set; } = Theme.Light;

        // === PALET WARNA LIGHT MODE ===
        public static Color Light_Background = SystemColors.Control;
        public static Color Light_Foreground = SystemColors.ControlText;
        public static Color Light_TextBox_Background = SystemColors.Window;
        public static Color Light_Button_Background = SystemColors.Control;
        public static Color Light_Grid_Background = SystemColors.Window;
        public static Color Light_Grid_Cell_Background = SystemColors.Window;

        // === PALET WARNA DARK MODE ===
        public static Color Dark_Background = Color.FromArgb(45, 45, 48);
        public static Color Dark_Foreground = Color.White;
        public static Color Dark_TextBox_Background = Color.FromArgb(60, 60, 60);
        public static Color Dark_Button_Background = Color.FromArgb(60, 60, 60);
        public static Color Dark_Grid_Background = Color.FromArgb(45, 45, 48);
        public static Color Dark_Grid_Cell_Background = Color.FromArgb(60, 60, 60);

        // Method untuk mengubah tema
        public static void SetTheme(Theme theme)
        {
            CurrentTheme = theme;
        }

        // Tambahkan method ini di dalam class ThemeManager.cs

        // Method utama yang dipanggil dari luar
        public static void ApplyTheme(Control parentControl)
        {
            ApplyThemeRecursive(parentControl);
        }

        // Method rekursif yang melakukan pekerjaan berat
        private static void ApplyThemeRecursive(Control control)
        {
            Color bgColor, fgColor;

            // Tentukan palet warna berdasarkan tema saat ini
            if (CurrentTheme == Theme.Dark)
            {
                bgColor = Dark_Background;
                fgColor = Dark_Foreground;
            }
            else
            {
                bgColor = Light_Background;
                fgColor = Light_Foreground;
            }

            // Terapkan warna ke kontrol saat ini
            control.BackColor = bgColor;
            control.ForeColor = fgColor;

            // --- PENANGANAN KHUSUS UNTUK TIAP TIPE KONTROL ---
            if (control is TextBox || control is RichTextBox || control is ComboBox)
            {
                control.BackColor = (CurrentTheme == Theme.Dark) ? Dark_TextBox_Background : Light_TextBox_Background;
            }
            else if (control is Button)
            {
                Button btn = control as Button;
                btn.BackColor = (CurrentTheme == Theme.Dark) ? Dark_Button_Background : Light_Button_Background;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = (CurrentTheme == Theme.Dark) ? Color.Gray : Color.Black;
            }
            else if (control is DataGridView)
            {
                DataGridView dgv = control as DataGridView;
                dgv.BackgroundColor = (CurrentTheme == Theme.Dark) ? Dark_Grid_Background : Light_Grid_Background;
                dgv.GridColor = (CurrentTheme == Theme.Dark) ? Color.Gray : Color.Black;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = bgColor;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = fgColor;
                dgv.DefaultCellStyle.BackColor = (CurrentTheme == Theme.Dark) ? Dark_Grid_Cell_Background : Light_Grid_Cell_Background;
                dgv.DefaultCellStyle.ForeColor = fgColor;
                dgv.EnableHeadersVisualStyles = false; // Penting!
            }
            else if (control is Label || control is CheckBox || control is RadioButton)
            {
                // Label dan Checkbox biasanya transparan, jadi kita tidak set BackColor
                control.ForeColor = fgColor;
            }

            // Panggil method ini lagi untuk setiap kontrol anak di dalamnya (rekursif)
            foreach (Control childControl in control.Controls)
            {
                ApplyThemeRecursive(childControl);
            }
        }
    }
}
