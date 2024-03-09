using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.PresentationLayer.Helpers
{
    public class ControlHelperManager
    {
        internal static void ClearControl(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;

                if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }
        }
    }
}
