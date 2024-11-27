namespace DESIGNER.Formularios
{
    partial class frmAdminInstructores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridInstructores = new System.Windows.Forms.DataGridView();
            this.chkSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.optTodos = new System.Windows.Forms.RadioButton();
            this.optNinguno = new System.Windows.Forms.RadioButton();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.gridAsignados = new System.Windows.Forms.DataGridView();
            this.txtEscuela = new System.Windows.Forms.TextBox();
            this.txtIDSENATI = new System.Windows.Forms.TextBox();
            this.txtTipoContrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridInstructores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridInstructores
            // 
            this.gridInstructores.AllowUserToAddRows = false;
            this.gridInstructores.AllowUserToDeleteRows = false;
            this.gridInstructores.BackgroundColor = System.Drawing.Color.White;
            this.gridInstructores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInstructores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSeleccion});
            this.gridInstructores.Location = new System.Drawing.Point(12, 95);
            this.gridInstructores.Name = "gridInstructores";
            this.gridInstructores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInstructores.Size = new System.Drawing.Size(462, 398);
            this.gridInstructores.TabIndex = 0;
            this.gridInstructores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            this.gridInstructores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
            // 
            // chkSeleccion
            // 
            this.chkSeleccion.HeaderText = "#";
            this.chkSeleccion.Name = "chkSeleccion";
            // 
            // optTodos
            // 
            this.optTodos.AutoSize = true;
            this.optTodos.Location = new System.Drawing.Point(12, 68);
            this.optTodos.Name = "optTodos";
            this.optTodos.Size = new System.Drawing.Size(63, 21);
            this.optTodos.TabIndex = 1;
            this.optTodos.Text = "Todos";
            this.optTodos.UseVisualStyleBackColor = true;
            this.optTodos.CheckedChanged += new System.EventHandler(this.optTodos_CheckedChanged);
            // 
            // optNinguno
            // 
            this.optNinguno.AutoSize = true;
            this.optNinguno.Checked = true;
            this.optNinguno.Location = new System.Drawing.Point(81, 68);
            this.optNinguno.Name = "optNinguno";
            this.optNinguno.Size = new System.Drawing.Size(81, 21);
            this.optNinguno.TabIndex = 1;
            this.optNinguno.TabStop = true;
            this.optNinguno.Text = "Ninguno";
            this.optNinguno.UseVisualStyleBackColor = true;
            this.optNinguno.CheckedChanged += new System.EventHandler(this.optNinguno_CheckedChanged);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(818, 64);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(141, 25);
            this.btnEvaluar.TabIndex = 2;
            this.btnEvaluar.Text = "Asignar al periodo";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // gridAsignados
            // 
            this.gridAsignados.AllowUserToAddRows = false;
            this.gridAsignados.AllowUserToDeleteRows = false;
            this.gridAsignados.AllowUserToResizeColumns = false;
            this.gridAsignados.AllowUserToResizeRows = false;
            this.gridAsignados.BackgroundColor = System.Drawing.Color.White;
            this.gridAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsignados.Location = new System.Drawing.Point(497, 95);
            this.gridAsignados.MultiSelect = false;
            this.gridAsignados.Name = "gridAsignados";
            this.gridAsignados.ReadOnly = true;
            this.gridAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAsignados.Size = new System.Drawing.Size(462, 398);
            this.gridAsignados.TabIndex = 3;
            // 
            // txtEscuela
            // 
            this.txtEscuela.Location = new System.Drawing.Point(167, 500);
            this.txtEscuela.Name = "txtEscuela";
            this.txtEscuela.Size = new System.Drawing.Size(307, 23);
            this.txtEscuela.TabIndex = 4;
            // 
            // txtIDSENATI
            // 
            this.txtIDSENATI.Location = new System.Drawing.Point(167, 529);
            this.txtIDSENATI.Name = "txtIDSENATI";
            this.txtIDSENATI.Size = new System.Drawing.Size(307, 23);
            this.txtIDSENATI.TabIndex = 4;
            // 
            // txtTipoContrato
            // 
            this.txtTipoContrato.Location = new System.Drawing.Point(167, 558);
            this.txtTipoContrato.Name = "txtTipoContrato";
            this.txtTipoContrato.Size = new System.Drawing.Size(307, 23);
            this.txtTipoContrato.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escuela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID SENATI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo contrato:";
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Location = new System.Drawing.Point(634, 64);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(131, 25);
            this.cboSemestre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Semestre y periodo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gestor Instructores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Asigne los instructores para el periodo a trabajar.";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(496, 497);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(112, 26);
            this.btnQuitar.TabIndex = 8;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(847, 549);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 26);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(805, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Instructores asignados:";
            // 
            // frmAdminInstructores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 593);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboSemestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoContrato);
            this.Controls.Add(this.txtIDSENATI);
            this.Controls.Add(this.txtEscuela);
            this.Controls.Add(this.gridAsignados);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.optNinguno);
            this.Controls.Add(this.optTodos);
            this.Controls.Add(this.gridInstructores);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminInstructores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructores";
            this.Load += new System.EventHandler(this.frmAdminInstructores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInstructores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridInstructores;
        private System.Windows.Forms.RadioButton optTodos;
        private System.Windows.Forms.RadioButton optNinguno;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSeleccion;
        private System.Windows.Forms.DataGridView gridAsignados;
        private System.Windows.Forms.TextBox txtEscuela;
        private System.Windows.Forms.TextBox txtIDSENATI;
        private System.Windows.Forms.TextBox txtTipoContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label7;
    }
}