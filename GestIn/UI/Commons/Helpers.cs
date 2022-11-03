using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestIn.UI.Commons
{
    internal static class Helpers
    {
        public static void OpenChildForm(Form formHijo, object pan)
        {
            Panel p = pan as Panel;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            p.Controls.Add(formHijo);
            p.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
    }
}
