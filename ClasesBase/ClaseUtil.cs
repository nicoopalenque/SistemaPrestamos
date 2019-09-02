using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClasesBase
{
    public class ClaseUtil
    {
        public static void limpiarFormulario(Control control)
        {           
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else if (txt is ComboBox)
                    ((ComboBox)txt).SelectedIndex = -1;
            }
        }

        public static void limpiarFormulario(GroupBox gb)
        {
            foreach (var txt in gb.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else if (txt is ComboBox)
                    ((ComboBox)txt).SelectedIndex = -1;
            }
        }
    }
}
