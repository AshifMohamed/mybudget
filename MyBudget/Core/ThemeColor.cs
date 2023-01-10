using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Core
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; } = Color.FromArgb(0, 150, 136);
        public static Color SecondaryColor { get; set; } = Color.FromArgb(77, 176, 167);
        public static Color ActionPanelColor { get; set; } = Color.FromArgb(39, 39, 58);
        public static Color CancelBtnColor { get; set; } = Color.FromArgb(219, 37, 43);
        public static Color CancelBtnBorderColor { get; set; } = Color.FromArgb(217, 59, 64);

    }
}
