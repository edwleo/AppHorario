using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

using BOL;
using DESIGNER.Herramientas;
using DESIGNER.Clases;

namespace DESIGNER.Formularios
{
    public partial class frmAdminInstructores : Form
    {
        Instructor instructor = new Instructor();
        Semestre semestre = new Semestre();
        Carga carga = new Carga();

        public frmAdminInstructores()
        {
            InitializeComponent();
        }

        private void frmAdminInstructores_Load(object sender, EventArgs e)
        {
            gridInstructores.DataSource = instructor.getAll();
            gridInstructores.Columns[0].Width = 40;
            gridInstructores.Columns[1].Visible = false;
            gridInstructores.Columns[2].Visible = false;
            gridInstructores.Columns[3].Visible = false;
            gridInstructores.Columns[6].Visible = false;
            gridInstructores.Columns[4].Width = 185;
            gridInstructores.Columns[5].Width = 185;
            gridInstructores.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;

            cboSemestre.DataSource = semestre.getAll();
            cboSemestre.DisplayMember = "periodo";
            cboSemestre.ValueMember = "id";

            if (cboSemestre.Text != "")
            {
                gridAsignados.DataSource = carga.showInstructor(Convert.ToInt32(cboSemestre.SelectedValue));
                gridAsignados.Columns[0].Visible = false;
                gridAsignados.Columns[1].Width = 200;
                gridAsignados.Columns[2].Width = 200;
                gridAsignados.ClearSelection();
            }

            gridAsignados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }

        private int checkActivos()
        {
            int checkeds = 0;
            if (gridInstructores.Rows.Count > 0)
            {
                for (int i = 0; i < gridInstructores.Rows.Count; i++)
                {
                    bool colChecked = Convert.ToBoolean(gridInstructores.Rows[i].Cells["chkSeleccion"].Value);
                    if (colChecked)
                    {
                        checkeds++;
                    }
                }
            }

            return checkeds;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int totalInstructores = gridInstructores.Rows.Count;
            int totalPeriodos = cboSemestre.Items.Count;


            if (totalInstructores == 0)
            {
                MsgBox.advertir("No existen instructores, agregue registros antes de continuar");
            }
            
            if (totalPeriodos == 0 || cboSemestre.Text == "")
            {
                MsgBox.advertir("No ha seleccionado o cargado el semestre-periodo");
            }


            if (checkActivos() == 0)
            {
                MsgBox.informar("Debe indicar un instructor de la lista");
            }
            else
            {
                if (MsgBox.preguntar("¿Asignamos estos instructores al periodo " + cboSemestre.Text + "?") == DialogResult.Yes)
                {
                    var listaClaves = new List<ClaveInstructor>();

                    for (int i = 0; i < gridInstructores.Rows.Count; i++)
                    {
                        bool colChecked = Convert.ToBoolean(gridInstructores.Rows[i].Cells["chkSeleccion"].Value);
                        if (colChecked)
                        {
                            listaClaves.Add(new ClaveInstructor { idinstructor = Convert.ToInt32(gridInstructores.Rows[i].Cells[1].Value) });
                        }
                    }

                    string json = JsonConvert.SerializeObject(listaClaves);
                    carga.add(Convert.ToInt32(cboSemestre.SelectedValue), json);

                    gridAsignados.DataSource = carga.showInstructor(Convert.ToInt32(cboSemestre.SelectedValue));
                    setCheckGrid(false);
                    gridAsignados.ClearSelection();
                    gridInstructores.ClearSelection();
                }
            }
        }

        private void setCheckGrid(bool estado)
        {
            for (int i = 0; i < gridInstructores.Rows.Count; i++)
            {
                gridInstructores.Rows[i].Cells["chkSeleccion"].Value = estado;
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
            gridInstructores.ClearSelection();

            if (gridInstructores.CurrentRow == null)
            {
                txtEscuela.Clear();
                txtIDSENATI.Clear();
                txtTipoContrato.Clear();
            }
        }

        private void grid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridInstructores.Rows.Count > 0) 
            {
                txtEscuela.Text = gridInstructores.CurrentRow.Cells[2].Value.ToString();
                txtIDSENATI.Text = gridInstructores.CurrentRow.Cells[3].Value.ToString();
                txtTipoContrato.Text = gridInstructores.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridAsignados.Rows.Count == 0)
            {
                MsgBox.informar("No hay datos que puedan ser removidos");
            }
            else
            {
                if (gridAsignados.CurrentRow == null)
                {
                    MsgBox.informar("Seleccione un elemento de la lista");
                }
                else
                {
                    string instructor = gridAsignados.CurrentRow.Cells[1].Value.ToString() + " " + gridAsignados.CurrentRow.Cells[2].Value.ToString();
                    if (MsgBox.preguntar("¿Está seguro de quitar a: " + instructor + "?") == DialogResult.Yes)
                    {
                        carga.delete(Convert.ToInt32(gridAsignados.CurrentRow.Cells[0].Value));
                        gridAsignados.DataSource = carga.showInstructor(Convert.ToInt32(cboSemestre.SelectedValue));
                        gridAsignados.ClearSelection();
                    }
                }
            }
        }
    }
}
