using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioMusik
{
    public class ButtonStyler
    {
        public static void SetFlatStyle(params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
            }
        }
    }
}
