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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFormMateria = new System.Windows.Forms.Button();
            this.dataGridViewCarreras = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.lblqcyo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblcarreraaqui = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumResolucion
            // 
            this.txtNumResolucion.Enabled = false;
            this.txtNumResolucion.Location = new System.Drawing.Point(1117, 138);
            this.txtNumResolucion.Name = "txtNumResolucion";
            this.txtNumResolucion.Size = new System.Drawing.Size(151, 27);
            this.txtNumResolucion.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(1117, 185);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(1117, 230);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(151, 27);
            this.txtTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(998, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NumResolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1019, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1025, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titulo";
            // 
            // cbbTurno
            // 
            this.cbbTurno.Enabled = false;
            this.cbbTurno.FormattingEnabled = true;
            this.cbbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Vespertino"});
            this.cbbTurno.Location = new System.Drawing.Point(1117, 279);
            this.cbbTurno.Name = "cbbTurno";
            this.cbbTurno.Size = new System.Drawing.Size(151, 28);
            this.cbbTurno.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(1025, 282);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(47, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Turno";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1025, 386);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Guardar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1174, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnFormMateria
            // 
            this.btnFormMateria.Location = new System.Drawing.Point(760, 489);
            this.btnFormMateria.Name = "btnFormMateria";
            this.btnFormMateria.Size = new System.Drawing.Size(192, 29);
            this.btnFormMateria.TabIndex = 13;
            this.btnFormMateria.Text = "Ver materias por carrera";
            this.btnFormMateria.UseVisualStyleBackColor = true;
            this.btnFormMateria.Click += new System.EventHandler(this.btnFormMateria_Click);
            // 
            // dataGridViewCarreras
            // 
            this.dataGridViewCarreras.AllowUserToAddRows = false;
            this.dataGridViewCarreras.AllowUserToDeleteRows = false;
            this.dataGridViewCarreras.AllowUserToResizeRows = false;
            this.dataGridViewCarreras.AutoGenerateColumns = false;
            this.dataGridViewCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.turnDataGridViewTextBoxColumn});
            this.dataGridViewCarreras.DataSource = this.careerBindingSource;
            this.dataGridViewCarreras.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCarreras.Name = "dataGridViewCarreras";
            this.dataGridViewCarreras.RowHeadersWidth = 51;
            this.dataGridViewCarreras.RowTemplate.Height = 29;
            this.dataGridViewCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarreras.Size = new System.Drawing.Size(940, 471);
            this.dataGridViewCarreras.TabIndex = 14;
            this.dataGridViewCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellClick);
            this.dataGridViewCarreras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            // 
            // turnDataGridViewTextBoxColumn
            // 
            this.turnDataGridViewTextBoxColumn.DataPropertyName = "Turn";
            this.turnDataGridViewTextBoxColumn.HeaderText = "Turn";
            this.turnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnDataGridViewTextBoxColumn.Name = "turnDataGridViewTextBoxColumn";
            // 
            // careerBindingSource
            // 
            this.careerBindingSource.DataSource = typeof(GestIn.Model.Career);
            // 
            // lblqcyo
            // 
            this.lblqcyo.AutoSize = true;
            this.lblqcyo.Location = new System.Drawing.Point(1078, 51);
            this.lblqcyo.Name = "lblqcyo";
            this.lblqcyo.Size = new System.Drawing.Size(147, 20);
            this.lblqcyo.TabIndex = 15;
            this.lblqcyo.Text = "Carrera seleccionada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1025, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Nueva carrera";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 489);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseClick);
            // 
            // lblcarreraaqui
            // 
            this.lblcarreraaqui.AutoSize = true;
            this.lblcarreraaqui.Location = new System.Drawing.Point(1100, 80);
            this.lblcarreraaqui.Name = "lblcarreraaqui";
            this.lblcarreraaqui.Size = new System.Drawing.Size(92, 20);
            this.lblcarreraaqui.TabIndex = 18;
            this.lblcarreraaqui.Text = "Carrera Aqui";
            // 
            // formCareer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1324, 664);
            this.Controls.Add(this.lblcarreraaqui);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblqcyo);
            this.Controls.Add(this.dataGridViewCarreras);
            this.Controls.Add(this.btnFormMateria);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
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
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).EndInit();
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
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnFormMateria;
        private DataGridView dataGridViewCarreras;
        private BindingSource BindingSourceCarreras;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnDataGridViewTextBoxColumn;
        private BindingSource careerBindingSource;
        private Label lblqcyo;
        private Button button1;
        private Button btnModificar;
        private Label lblcarreraaqui;
    }
}