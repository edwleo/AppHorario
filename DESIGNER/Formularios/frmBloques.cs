using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Formularios
{
    public partial class frmBloques : Form
    {
        public frmBloques()
        {
            InitializeComponent();
        }

        private void frmBloques_Load(object sender, EventArgs e)
        {
            gridLunes.Rows.Add("1", "2", "07:45", "09:15");
            gridLunes.Rows.Add("2", "2", "07:45", "09:15");
            gridLunes.Rows.Add("3", "2", "07:45", "09:15");
            gridLunes.Rows.Add("4", "2", "07:45", "09:15");
            gridLunes.Rows.Add("5", "2", "07:45", "09:15");
            gridLunes.Rows.Add("6", "2", "07:45", "09:15");
            gridLunes.Rows.Add("7", "2", "07:45", "09:15");

            //gridLunes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            gridLunes.ClearSelection();
        }
    }
}
