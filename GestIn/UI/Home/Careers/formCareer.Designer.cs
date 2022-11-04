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
            this.careerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.careerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.lblqcyo = new System.Windows.Forms.Label();
            this.lblcarreraaqui = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblCareerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumResolucion
            // 
            this.txtNumResolucion.Location = new System.Drawing.Point(370, 82);
            this.txtNumResolucion.Name = "txtNumResolucion";
            this.txtNumResolucion.Size = new System.Drawing.Size(173, 27);
            this.txtNumResolucion.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(370, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(629, 82);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(173, 27);
            this.txtTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "# Resolución:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(290, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(566, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titulo:";
            // 
            // cbbTurno
            // 
            this.cbbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTurno.FormattingEnabled = true;
            this.cbbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Vespertino"});
            this.cbbTurno.Location = new System.Drawing.Point(629, 129);
            this.cbbTurno.Name = "cbbTurno";
            this.cbbTurno.Size = new System.Drawing.Size(173, 28);
            this.cbbTurno.TabIndex = 3;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(566, 132);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(50, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Turno:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(992, 77);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(137, 29);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Crear Carrera";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(992, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 29);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Actualizar Carrera";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.idDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.degreeDataGridViewTextBoxColumn1,
            this.turnDataGridViewTextBoxColumn1,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridViewCarreras.DataSource = this.careerBindingSource1;
            this.dataGridViewCarreras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCarreras.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCarreras.Name = "dataGridViewCarreras";
            this.dataGridViewCarreras.ReadOnly = true;
            this.dataGridViewCarreras.RowHeadersVisible = false;
            this.dataGridViewCarreras.RowHeadersWidth = 51;
            this.dataGridViewCarreras.RowTemplate.Height = 29;
            this.dataGridViewCarreras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarreras.Size = new System.Drawing.Size(1369, 515);
            this.dataGridViewCarreras.TabIndex = 14;
            this.dataGridViewCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellClick);
            this.dataGridViewCarreras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellDoubleClick);
            // 
            // careerBindingSource1
            // 
            this.careerBindingSource1.DataSource = typeof(GestIn.Model.Career);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Resolución";
            this.resolutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.Width = 180;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 225;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.degreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.Width = 299;
            // 
            // turnDataGridViewTextBoxColumn
            // 
            this.turnDataGridViewTextBoxColumn.DataPropertyName = "Turn";
            this.turnDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turnDataGridViewTextBoxColumn.Name = "turnDataGridViewTextBoxColumn";
            this.turnDataGridViewTextBoxColumn.Width = 449;
            // 
            // lblqcyo
            // 
            this.lblqcyo.AutoSize = true;
            this.lblqcyo.ForeColor = System.Drawing.Color.White;
            this.lblqcyo.Location = new System.Drawing.Point(1142, 36);
            this.lblqcyo.Name = "lblqcyo";
            this.lblqcyo.Size = new System.Drawing.Size(150, 20);
            this.lblqcyo.TabIndex = 15;
            this.lblqcyo.Text = "Carrera seleccionada:";
            // 
            // lblcarreraaqui
            // 
            this.lblcarreraaqui.AutoSize = true;
            this.lblcarreraaqui.ForeColor = System.Drawing.Color.White;
            this.lblcarreraaqui.Location = new System.Drawing.Point(371, 36);
            this.lblcarreraaqui.Name = "lblcarreraaqui";
            this.lblcarreraaqui.Size = new System.Drawing.Size(41, 20);
            this.lblcarreraaqui.TabIndex = 18;
            this.lblcarreraaqui.Text = "        ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 14);
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
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(846, 107);
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
            this.label5.Location = new System.Drawing.Point(276, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Seleccione una carrera para actualizar: ";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelInfo.Controls.Add(this.lblCareerName);
            this.panelInfo.Controls.Add(this.cbbTurno);
            this.panelInfo.Controls.Add(this.txtNumResolucion);
            this.panelInfo.Controls.Add(this.chkActivo);
            this.panelInfo.Controls.Add(this.txtNombre);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.txtTitulo);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.lbl4);
            this.panelInfo.Controls.Add(this.btnInsert);
            this.panelInfo.Controls.Add(this.btnUpdate);
            this.panelInfo.Location = new System.Drawing.Point(1, 533);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1369, 191);
            this.panelInfo.TabIndex = 22;
            // 
            // lblCareerName
            // 
            this.lblCareerName.AutoSize = true;
            this.lblCareerName.ForeColor = System.Drawing.Color.White;
            this.lblCareerName.Location = new System.Drawing.Point(549, 31);
            this.lblCareerName.Name = "lblCareerName";
            this.lblCareerName.Size = new System.Drawing.Size(13, 20);
            this.lblCareerName.TabIndex = 22;
            this.lblCareerName.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCarreras);
            this.panel2.Location = new System.Drawing.Point(4, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1369, 515);
            this.panel2.TabIndex = 23;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // resolutionDataGridViewTextBoxColumn1
            // 
            this.resolutionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resolutionDataGridViewTextBoxColumn1.DataPropertyName = "Resolution";
            this.resolutionDataGridViewTextBoxColumn1.FillWeight = 25F;
            this.resolutionDataGridViewTextBoxColumn1.HeaderText = "Resolución";
            this.resolutionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.resolutionDataGridViewTextBoxColumn1.Name = "resolutionDataGridViewTextBoxColumn1";
            this.resolutionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 120F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // degreeDataGridViewTextBoxColumn1
            // 
            this.degreeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.degreeDataGridViewTextBoxColumn1.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn1.FillWeight = 70F;
            this.degreeDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.degreeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.degreeDataGridViewTextBoxColumn1.Name = "degreeDataGridViewTextBoxColumn1";
            this.degreeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // turnDataGridViewTextBoxColumn1
            // 
            this.turnDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.turnDataGridViewTextBoxColumn1.DataPropertyName = "Turn";
            this.turnDataGridViewTextBoxColumn1.FillWeight = 20F;
            this.turnDataGridViewTextBoxColumn1.HeaderText = "Turno";
            this.turnDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.turnDataGridViewTextBoxColumn1.Name = "turnDataGridViewTextBoxColumn1";
            this.turnDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.FillWeight = 10F;
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // formCareer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1373, 722);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblqcyo);
            this.Controls.Add(this.lblcarreraaqui);
            this.Controls.Add(this.panelInfo);
            this.Name = "formCareer";
            this.Text = "FormCarrera";
            this.Load += new System.EventHandler(this.formCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private Label lblcarreraaqui;
        private Label label4;
        private CheckBox chkActivo;
        private Label label5;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnDataGridViewTextBoxColumn;
        private Panel panelInfo;
        private BindingSource careerBindingSource1;
        private Panel panel2;
        private Label lblCareerName;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn turnDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    }
}