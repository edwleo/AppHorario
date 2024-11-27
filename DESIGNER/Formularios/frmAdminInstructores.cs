using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BOL;

namespace DESIGNER.Formularios
{
    public partial class frmAdminInstructores : Form
    {
        Instructor instructor = new Instructor();
        Semestre semestre = new Semestre();

        public frmAdminInstructores()
        {
            InitializeComponent();
        }

        private void frmAdminInstructores_Load(object sender, EventArgs e)
        {
            grid.DataSource = instructor.getAll();
            grid.Columns[0].Width = 40;
            grid.Columns[1].Visible = false;
            grid.Columns[2].Visible = false;
            grid.Columns[3].Visible = false;
            grid.Columns[6].Visible = false;
            grid.Columns[4].Width = 185;
            grid.Columns[5].Width = 185;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

            cboSemestre.DataSource = semestre.getAll();
            cboSemestre.DisplayMember = "periodo";
            cboSemestre.ValueMember = "id";
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    bool colChecked = Convert.ToBoolean(grid.Rows[i].Cells["chkSeleccion"].Value);
                    if (colChecked)
                    {
                        MessageBox.Show(grid.Rows[i].Cells[1].Value.ToString());
                    }
                }
            }
        }

        private void setCheckGrid(bool estado)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells["chkSeleccion"].Value = estado;
            }
        }

        private void optTodos_CheckedChanged(object sender, EventArgs e)
        {
            setCheckGrid(true);
        }

        private void optNinguno_CheckedChanged(object sender, EventArgs e)
        {
            setCheckGrid(false);
        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grid.ClearSelection();

            if (grid.CurrentRow == null)
            {
                txtEscuela.Clear();
                txtIDSENATI.Clear();
                txtTipoContrato.Clear();
            }
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Rows.Count > 0) 
            {
                txtEscuela.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtIDSENATI.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txtTipoContrato.Text = grid.CurrentRow.Cells[6].Value.ToString();
            }
        }
    }
}
