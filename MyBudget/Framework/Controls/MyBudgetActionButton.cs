using MyBudget.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget.Framework.Controls
{
    public class MyBudgetActionButton : MyBudgetButton
    {
        private static readonly string SAVE = "SAVE";
        private static readonly string CANCEL = "CANCEL";
        public enum ActionType
        {
            Save,
            Cancel
        }
        //Fields
        private ActionType actionType = ActionType.Save;

        //Properties
        [Category("My Budget Advance")]
        public ActionType Type
        {
            get { return actionType; }
            set
            {
                actionType = value;
                SetButtonProps();
                this.Invalidate();
            }
        }

        public MyBudgetActionButton()
        {
            ForeColor = Color.White;

            SetButtonProps();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Text = actionType == ActionType.Save ? SAVE : CANCEL;
        }

        private void SetButtonProps()
        {
            if (actionType == ActionType.Save)
            {
                BackColor = ThemeColor.PrimaryColor;
                BorderColor = ThemeColor.SecondaryColor;
                Text = "SAVE";
            }
            else
            {
                BackColor = ThemeColor.CancelBtnColor;
                BorderColor = ThemeColor.CancelBtnBorderColor;
                Text = "CANCEL";
            }
        }

    }
}
