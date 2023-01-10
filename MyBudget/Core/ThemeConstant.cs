using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Core
{
    public class ThemeConstant
    {
        public static readonly Font DEFAULT_FONT = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        public static readonly string DATE_FORMAT = "MMM dd yyyy";
        public static readonly string DEFAULT_EDIT_ICON = "edit_icon";
        public static readonly string DEFAULT_DELETE_ICON = "delete_icon";

        public static Image GetResourceIcon(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image; 
        }
    }
}
