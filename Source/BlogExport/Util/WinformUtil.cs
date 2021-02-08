using System;
using System.Windows.Forms;

namespace BlogExport.Util
{
    public class WinformUtil
    {
        public static void ShowDialog(string tip)
        {
            MessageBox.Show(tip);
        }

        public static void ShowDialog(string title, string tip)
        {
            MessageBox.Show(tip, title);
        }
        public static void ShowDialog(string title, string tip, Action okAction = null, Action cancelAction = null)
        {
            DialogResult result = MessageBox.Show(tip, title, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (okAction != null) okAction();
            }
            else if (result == DialogResult.Cancel)
            {
                if (cancelAction != null) cancelAction();
            }
        }
    }
}
