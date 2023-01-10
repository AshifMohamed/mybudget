using MyBudget.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget.Framework.Controls
{
    public class MyBudgetDataGrid : DataGridView
    {
        public MyBudgetDataGrid()
        {
            AutoGenerateColumns = false;
            EnableHeadersVisualStyles = false;
            GridColor = Color.White;
            ReadOnly = true;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BackgroundColor = Color.White;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Cursor = Cursors.Hand;

            DefaultCellStyle = GetDefaultCellStyle();
            AlternatingRowsDefaultCellStyle = GetAlternatingRowsDefaultCellStyle();
            ColumnHeadersDefaultCellStyle = GetColumnHeadersDefaultCellStyle();
        }

        private DataGridViewCellStyle GetAlternatingRowsDefaultCellStyle()
        {
            return new DataGridViewCellStyle
            {
                BackColor = Color.Gainsboro
            };
        }

        private DataGridViewCellStyle GetColumnHeadersDefaultCellStyle()
        {
            return new DataGridViewCellStyle
            {
               Alignment = DataGridViewContentAlignment.MiddleLeft,
            BackColor = ThemeColor.PrimaryColor,
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
            ForeColor = Color.White,
            Padding = new Padding(0, 10, 10, 10),
            SelectionBackColor = ThemeColor.PrimaryColor,

            SelectionForeColor = SystemColors.HighlightText,
            WrapMode = DataGridViewTriState.True
            };
        }

        private DataGridViewCellStyle GetDefaultCellStyle()
        {
            return new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
            BackColor = SystemColors.Window,
            Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
            ForeColor = SystemColors.ControlText,
            SelectionBackColor = ThemeColor.SecondaryColor,
            SelectionForeColor = SystemColors.HighlightText
        };
        }
    }
}
