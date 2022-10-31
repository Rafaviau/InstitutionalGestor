namespace GestIn.UI.Home.Careers

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
            this.dataGridViewCarreras = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.careerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.lblqcyo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblcarreraaqui = new System.Windows.Forms.Label();
            this.lblPermission = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumResolucion
            // 
            this.txtNumResolucion.Enabled = false;
            this.txtNumResolucion.Location = new System.Drawing.Point(184, 165);
            this.txtNumResolucion.Name = "txtNumResolucion";
            this.txtNumResolucion.Size = new System.Drawing.Size(173, 27);
            this.txtNumResolucion.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(184, 212);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(184, 261);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(173, 27);
            this.txtTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Resolución";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titulo";
            // 
            // cbbTurno
            // 
            this.cbbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTurno.Enabled = false;
            this.cbbTurno.FormattingEnabled = true;
            this.cbbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Vespertino"});
            this.cbbTurno.Location = new System.Drawing.Point(184, 311);
            this.cbbTurno.Name = "cbbTurno";
            this.cbbTurno.Size = new System.Drawing.Size(173, 28);
            this.cbbTurno.TabIndex = 3;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(121, 319);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(47, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Turno";
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(57, 503);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 29);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Crear Carrera";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(270, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 29);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Actualizar Carrera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataGridViewCarreras
            // 
            this.dataGridViewCarreras.AllowUserToAddRows = false;
            this.dataGridViewCarreras.AllowUserToDeleteRows = false;
            this.dataGridViewCarreras.AllowUserToResizeRows = false;
            this.dataGridViewCarreras.AutoGenerateColumns = false;
            this.dataGridViewCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarreras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridViewCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.resolutionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.turnDataGridViewTextBoxColumn,
            this.Active});
            this.dataGridViewCarreras.DataSource = this.careerBindingSource;
            this.dataGridViewCarreras.Location = new System.Drawing.Point(427, 103);
            this.dataGridViewCarreras.Name = "dataGridViewCarreras";
            this.dataGridViewCarreras.ReadOnly = true;
            this.dataGridViewCarreras.RowHeadersVisible = false;
            this.dataGridViewCarreras.RowHeadersWidth = 51;
            this.dataGridViewCarreras.RowTemplate.Height = 29;
            this.dataGridViewCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarreras.Size = new System.Drawing.Size(901, 586);
            this.dataGridViewCarreras.TabIndex = 14;
            this.dataGridViewCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellClick);
            this.dataGridViewCarreras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Resolución";
            this.resolutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.degreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turnDataGridViewTextBoxColumn
            // 
            this.turnDataGridViewTextBoxColumn.DataPropertyName = "Turn";
            this.turnDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnDataGridViewTextBoxColumn.Name = "turnDataGridViewTextBoxColumn";
            this.turnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Activa";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // careerBindingSource
            // 
            this.careerBindingSource.DataSource = typeof(GestIn.Model.Career);
            // 
            // lblqcyo
            // 
            this.lblqcyo.AutoSize = true;
            this.lblqcyo.ForeColor = System.Drawing.Color.White;
            this.lblqcyo.Location = new System.Drawing.Point(427, 693);
            this.lblqcyo.Name = "lblqcyo";
            this.lblqcyo.Size = new System.Drawing.Size(150, 20);
            this.lblqcyo.TabIndex = 15;
            this.lblqcyo.Text = "Carrera seleccionada:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(150, 418);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 29);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Permitir Modificacion";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblcarreraaqui
            // 
            this.lblcarreraaqui.AutoSize = true;
            this.lblcarreraaqui.ForeColor = System.Drawing.Color.White;
            this.lblcarreraaqui.Location = new System.Drawing.Point(580, 693);
            this.lblcarreraaqui.Name = "lblcarreraaqui";
            this.lblcarreraaqui.Size = new System.Drawing.Size(41, 20);
            this.lblcarreraaqui.TabIndex = 18;
            this.lblcarreraaqui.Text = "        ";
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.ForeColor = System.Drawing.Color.White;
            this.lblPermission.Location = new System.Drawing.Point(152, 459);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(163, 20);
            this.lblPermission.TabIndex = 19;
            this.lblPermission.Text = "Modificación Permitida";
            this.lblPermission.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(172, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 41);
            this.label4.TabIndex = 20;
            this.label4.Text = "Carreras";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Enabled = false;
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(184, 361);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(72, 24);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activa";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(427, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Seleccione una carrera para actualizar: ";
            // 
            // formCareer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1368, 722);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPermission);
            this.Controls.Add(this.lblcarreraaqui);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblqcyo);
            this.Controls.Add(this.dataGridViewCarreras);
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
        private DataGridView dataGridViewCarreras;
        private BindingSource BindingSourceCarreras;
        private BindingSource careerBindingSource;
        private Label lblqcyo;
        private Button btnModificar;
        private Label lblcarreraaqui;
        private Label lblPermission;
        private Label label4;
        private CheckBox chkActivo;
        private Label label5;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Active;
    }
}