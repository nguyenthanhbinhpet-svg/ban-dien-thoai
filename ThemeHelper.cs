using System.Drawing;
using System.Windows.Forms;

namespace GUI_PhoneStore
{
    public static class ThemeHelper
    {
        public static readonly Color Primary = Color.FromArgb(37, 99, 235);
        public static readonly Color Success = Color.FromArgb(22, 163, 74);
        public static readonly Color Danger = Color.FromArgb(220, 38, 38);
        public static readonly Color Secondary = Color.FromArgb(100, 116, 139);
        public static readonly Color Dark = Color.FromArgb(15, 23, 42);
        public static readonly Color LightBg = Color.FromArgb(248, 250, 252);
        public static readonly Color Border = Color.FromArgb(226, 232, 240);

        public static void StyleButton(Button btn)
        {
            StyleButton(btn, Primary);
        }

        public static void StyleButton(Button btn, Color color)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Dark;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.RowTemplate.Height = 30;
        }
    }
}
