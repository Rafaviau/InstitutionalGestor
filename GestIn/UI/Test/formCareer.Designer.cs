namespace GestIn.Vista.Test
{
    partial class formCareer
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
            this.components = new System.ComponentModel.Container();
            this.txtNumResolucion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTurno = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFormMateria = new System.Windows.Forms.Button();
            this.dataGridViewCarreras = new System.Windows.Forms.DataGridView();
            this.BindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.careerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumResolucion
            // 
            this.txtNumResolucion.Location = new System.Drawing.Point(183, 68);
            this.txtNumResolucion.Name = "txtNumResolucion";
            this.txtNumResolucion.Size = new System.Drawing.Size(151, 27);
            this.txtNumResolucion.TabIndex = 0;
            this.txtNumResolucion.TextChanged += new System.EventHandler(this.txtNumResolucion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(183, 160);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(151, 27);
            this.txtTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NumResolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titulo";
            // 
            // cbbTurno
            // 
            this.cbbTurno.FormattingEnabled = true;
            this.cbbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Vespertino"});
            this.cbbTurno.Location = new System.Drawing.Point(183, 209);
            this.cbbTurno.Name = "cbbTurno";
            this.cbbTurno.Size = new System.Drawing.Size(151, 28);
            this.cbbTurno.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(91, 212);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(47, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Turno";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(55, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(169, 305);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(286, 305);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFormMateria
            // 
            this.btnFormMateria.Location = new System.Drawing.Point(879, 356);
            this.btnFormMateria.Name = "btnFormMateria";
            this.btnFormMateria.Size = new System.Drawing.Size(94, 29);
            this.btnFormMateria.TabIndex = 13;
            this.btnFormMateria.Text = "Materia";
            this.btnFormMateria.UseVisualStyleBackColor = true;
            this.btnFormMateria.Click += new System.EventHandler(this.btnFormMateria_Click);
            // 
            // dataGridViewCarreras
            // 
            this.dataGridViewCarreras.AutoGenerateColumns = false;
            this.dataGridViewCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.turnDataGridViewTextBoxColumn});
            this.dataGridViewCarreras.DataSource = this.careerBindingSource;
            this.dataGridViewCarreras.Location = new System.Drawing.Point(426, 38);
            this.dataGridViewCarreras.Name = "dataGridViewCarreras";
            this.dataGridViewCarreras.RowHeadersWidth = 51;
            this.dataGridViewCarreras.RowTemplate.Height = 29;
            this.dataGridViewCarreras.Size = new System.Drawing.Size(550, 296);
            this.dataGridViewCarreras.TabIndex = 14;
            this.dataGridViewCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellClick);
            this.dataGridViewCarreras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellDoubleClick);
            // 
            // careerBindingSource
            // 
            this.careerBindingSource.DataSource = typeof(GestIn.Model.Career);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnDataGridViewTextBoxColumn
            // 
            this.turnDataGridViewTextBoxColumn.DataPropertyName = "Turn";
            this.turnDataGridViewTextBoxColumn.HeaderText = "Turn";
            this.turnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnDataGridViewTextBoxColumn.Name = "turnDataGridViewTextBoxColumn";
            this.turnDataGridViewTextBoxColumn.Width = 125;
            // 
            // formCareer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(993, 398);
            this.Controls.Add(this.dataGridViewCarreras);
            this.Controls.Add(this.btnFormMateria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cbbTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumResolucion);
            this.Name = "formCareer";
            this.Text = "FormCarrera";
            this.Load += new System.EventHandler(this.formCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumResolucion;
        private TextBox txtNombre;
        private TextBox txtTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbTurno;
        private Label lbl4;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnFormMateria;
        private DataGridView dataGridViewCarreras;
        private BindingSource BindingSourceCarreras;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnDataGridViewTextBoxColumn;
        private BindingSource careerBindingSource;
    }
}