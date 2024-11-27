using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace DESIGNER.Herramientas
{
    public static class MsgBox
    {
        public static void advertir(string mensaje)
        {
            MessageBox.Show(mensaje, "SENATI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void informar(string mensaje)
        {
            MessageBox.Show(mensaje, "SENATI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult preguntar(string pregunta)
        {
            return MessageBox.Show(pregunta, "SENATI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
