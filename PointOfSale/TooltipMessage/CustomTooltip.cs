using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PointOfSale.TooltipMessage {
    public class CustomTooltip {
        public static System.Drawing.Icon tooltipIcon;

        public static void Show (ToolTip toolTipObj, string message, Control handlerObj, int duration, bool isFocus = false) {
            toolTipObj.BackColor = Color.FromArgb(241,44,77);
            if (isFocus) {
                handlerObj.Focus ();
            }
            toolTipObj.RemoveAll ();
            toolTipObj.Show (message, handlerObj, handlerObj.Size.Width / 2, -40, duration);
        }

        public static void Show (ToolTip toolTipObj, string message, Control handlerObj, int duration, System.Drawing.Icon icon, bool isFocus = false) {
            toolTipObj.BackColor = Color.FromArgb(241, 44, 77);
            if (isFocus) {
                handlerObj.Focus ();
            }
            toolTipObj.RemoveAll ();
            if (icon != null) {
                tooltipIcon = icon;
                message = "            " + message;
            }
            toolTipObj.Show ( message, handlerObj, handlerObj.Size.Width / 2, -40, duration);
        }

        public static void Show (ToolTip toolTipObj, string message, Control handlerObj, int locationX, int locationY, int duration, System.Drawing.Icon icon, bool isFocus = false) {
            toolTipObj.BackColor = Color.FromArgb(241, 44, 77);
            if (isFocus) {
                handlerObj.Focus ();
            }
            toolTipObj.RemoveAll ();
            if (icon != null) {
                tooltipIcon = icon;
                message = "            " + message;
            }
            toolTipObj.Show ("            " + message, handlerObj, locationX, locationY, duration);
        }
    }
}
