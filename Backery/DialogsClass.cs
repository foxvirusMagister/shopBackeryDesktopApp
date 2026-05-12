using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backery
{
    public static class DialogsClass
    {
        public static DialogResult MessageDialog(string message)
        {
            var dialog = new MessageBoxBackery(message);
            return dialog.ShowDialog();
        }
    }
}
