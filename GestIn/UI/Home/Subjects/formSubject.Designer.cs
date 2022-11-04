namespace GestIn.UI.Home.Subjects
{
    partial class formSubject
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cbbCarreraSelector = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCargaHorariaTotal = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnioCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridViewMaterias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCarreraMaterias = new System.Windows.Forms.BindingSource(this.components);
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnCorrelativas = new System.Windows.Forms.Button();
            this.label123 = new System.Windows.Forms.Label();
            this.lblShowSubjectName = new System.Windows.Forms.Label();
            this.cbbSubjectYear = new System.Windows.Forms.ComboBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.teacherSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTable = new System.Windows.Forms.Panel();
            this.panelSelector = new System.Windows.Forms.Panel();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectBindingSource)).BeginInit();
            this.panelTable.SuspendLayout();
            this.panelSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.ForeColor = System.Drawing.Color.White;
            this.lblCarrera.Location = new System.Drawing.Point(3, 10);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(138, 20);
            this.lblCarrera.TabIndex = 29;
            this.lblCarrera.Text = "Seleccionar carrera:";
            // 
            // cbbCarreraSelector
            // 
            this.cbbCarreraSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCarreraSelector.FormattingEnabled = true;
            this.cbbCarreraSelector.Location = new System.Drawing.Point(147, 7);
            this.cbbCarreraSelector.Name = "cbbCarreraSelector";
            this.cbbCarreraSelector.Size = new System.Drawing.Size(754, 28);
            this.cbbCarreraSelector.TabIndex = 0;
            this.cbbCarreraSelector.SelectedIndexChanged += new System.EventHandler(this.cbCareerSelector_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(552, 76);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Actualizar Materia";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(462, 76);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(74, 111);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Crear Materia";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCargaHorariaTotal
            // 
            this.txtCargaHorariaTotal.Location = new System.Drawing.Point(281, 157);
            this.txtCargaHorariaTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargaHorariaTotal.Name = "txtCargaHorariaTotal";
            this.txtCargaHorariaTotal.Size = new System.Drawing.Size(175, 27);
            this.txtCargaHorariaTotal.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(281, 76);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(119, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Carga Horaria Total: ";
            // 
            // lblAnioCarrera
            // 
            this.lblAnioCarrera.AutoSize = true;
            this.lblAnioCarrera.ForeColor = System.Drawing.Color.White;
            this.lblAnioCarrera.Location = new System.Drawing.Point(119, 124);
            this.lblAnioCarrera.Name = "lblAnioCarrera";
            this.lblAnioCarrera.Size = new System.Drawing.Size(43, 20);
            this.lblAnioCarrera.TabIndex = 20;
            this.lblAnioCarrera.Text = "Año: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(119, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre: ";
            // 
            // dataGridViewMaterias
            // 
            this.dataGridViewMaterias.AllowUserToAddRows = false;
            this.dataGridViewMaterias.AllowUserToDeleteRows = false;
            this.dataGridViewMaterias.AllowUserToResizeRows = false;
            this.dataGridViewMaterias.AutoGenerateColumns = false;
            this.dataGridViewMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaterias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridViewMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridViewMaterias.DataSource = this.subjectBindingSource1;
            this.dataGridViewMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaterias.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterias.MultiSelect = false;
            this.dataGridViewMaterias.Name = "dataGridViewMaterias";
            this.dataGridViewMaterias.ReadOnly = true;
            this.dataGridViewMaterias.RowHeadersVisible = false;
            this.dataGridViewMaterias.RowHeadersWidth = 51;
            this.dataGridViewMaterias.RowTemplate.Height = 29;
            this.dataGridViewMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterias.Size = new System.Drawing.Size(1356, 569);
            this.dataGridViewMaterias.TabIndex = 30;
            this.dataGridViewMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_CellClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CareerId";
            this.dataGridViewTextBoxColumn11.HeaderText = "CareerId";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn12.FillWeight = 40F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "YearInCareer";
            this.dataGridViewTextBoxColumn13.FillWeight = 10.32264F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Año";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AnnualHourlyLoad";
            this.dataGridViewTextBoxColumn14.FillWeight = 8.928704F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Horas anuales";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataSource = typeof(GestIn.Model.Subject);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CareerId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CareerId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 144;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 181;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "YearInCareer";
            this.dataGridViewTextBoxColumn4.HeaderText = "YearInCareer";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 241;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AnnualHourlyLoad";
            this.dataGridViewTextBoxColumn5.HeaderText = "AnnualHourlyLoad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 360;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(11, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 41);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Materia";
            // 
            // btnDocentes
            // 
            this.btnDocentes.Location = new System.Drawing.Point(552, 159);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(175, 31);
            this.btnDocentes.TabIndex = 6;
            this.btnDocentes.Text = "Cargar Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnCorrelativas
            // 
            this.btnCorrelativas.Location = new System.Drawing.Point(552, 117);
            this.btnCorrelativas.Name = "btnCorrelativas";
            this.btnCorrelativas.Size = new System.Drawing.Size(175, 31);
            this.btnCorrelativas.TabIndex = 6;
            this.btnCorrelativas.Text = "Cargar Correlativas";
            this.btnCorrelativas.UseVisualStyleBackColor = true;
            this.btnCorrelativas.Click += new System.EventHandler(this.btnCorrelativas_Click);
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.ForeColor = System.Drawing.Color.White;
            this.label123.Location = new System.Drawing.Point(229, 38);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(155, 20);
            this.label123.TabIndex = 37;
            this.label123.Text = "Materia Seleccionada:";
            // 
            // lblShowSubjectName
            // 
            this.lblShowSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lblShowSubjectName.ForeColor = System.Drawing.Color.White;
            this.lblShowSubjectName.Location = new System.Drawing.Point(390, 30);
            this.lblShowSubjectName.Name = "lblShowSubjectName";
            this.lblShowSubjectName.Size = new System.Drawing.Size(337, 32);
            this.lblShowSubjectName.TabIndex = 38;
            this.lblShowSubjectName.Text = "                                   ";
            // 
            // cbbSubjectYear
            // 
            this.cbbSubjectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubjectYear.FormattingEnabled = true;
            this.cbbSubjectYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbSubjectYear.Location = new System.Drawing.Point(281, 116);
            this.cbbSubjectYear.Name = "cbbSubjectYear";
            this.cbbSubjectYear.Size = new System.Drawing.Size(175, 28);
            this.cbbSubjectYear.TabIndex = 2;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelInfo.Controls.Add(this.dataGridViewTeachers);
            this.panelInfo.Controls.Add(this.btnUpdate);
            this.panelInfo.Controls.Add(this.cbbSubjectYear);
            this.panelInfo.Controls.Add(this.lblTitle);
            this.panelInfo.Controls.Add(this.lblNombre);
            this.panelInfo.Controls.Add(this.lblShowSubjectName);
            this.panelInfo.Controls.Add(this.lblAnioCarrera);
            this.panelInfo.Controls.Add(this.btnCorrelativas);
            this.panelInfo.Controls.Add(this.label123);
            this.panelInfo.Controls.Add(this.btnDocentes);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.txtNombre);
            this.panelInfo.Controls.Add(this.txtCargaHorariaTotal);
            this.panelInfo.Controls.Add(this.btnInsert);
            this.panelInfo.Location = new System.Drawing.Point(1, 612);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1349, 213);
            this.panelInfo.TabIndex = 39;
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.AutoGenerateColumns = false;
            this.dataGridViewTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherDataGridViewTextBoxColumn});
            this.dataGridViewTeachers.DataSource = this.teacherSubjectBindingSource;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(756, 33);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.ReadOnly = true;
            this.dataGridViewTeachers.RowHeadersVisible = false;
            this.dataGridViewTeachers.RowHeadersWidth = 51;
            this.dataGridViewTeachers.RowTemplate.Height = 29;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(506, 157);
            this.dataGridViewTeachers.TabIndex = 39;
            // 
            // teacherSubjectBindingSource
            // 
            this.teacherSubjectBindingSource.DataSource = typeof(GestIn.Model.TeacherSubject);
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridViewMaterias);
            this.panelTable.Location = new System.Drawing.Point(-6, 0);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(1356, 569);
            this.panelTable.TabIndex = 40;
            // 
            // panelSelector
            // 
            this.panelSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSelector.Controls.Add(this.cbbCarreraSelector);
            this.panelSelector.Controls.Add(this.lblCarrera);
            this.panelSelector.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSelector.Location = new System.Drawing.Point(1, 568);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Size = new System.Drawing.Size(1349, 48);
            this.panelSelector.TabIndex = 31;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Docentes";
            this.teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1350, 826);
            this.Controls.Add(this.panelSelector);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelInfo);
            this.Name = "formSubject";
            this.Text = "formSubject";
            this.Load += new System.EventHandler(this.formSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectBindingSource)).EndInit();
            this.panelTable.ResumeLayout(false);
            this.panelSelector.ResumeLayout(false);
            this.panelSelector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblCarrera;
        private ComboBox cbbCarreraSelector;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox txtCargaHorariaTotal;
        private TextBox txtNombre;
        private Label label5;
        private Label lblAnioCarrera;
        private Label lblNombre;
        private DataGridView dataGridViewMaterias;
        private Label lblTitle;
        private BindingSource bindingSourceCarreras;
        private BindingSource bindingSourceCarreraMaterias;
        private Button btnDocentes;
        private Button btnCorrelativas;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cAREERIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yEARINCAREERDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aNNUALHOURLYLOADDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private BindingSource subjectBindingSource;
        private Label label123;
        private Label lblShowSubjectName;
        private ComboBox cbbSubjectYear;
        private BindingSource subjectBindingSource1;
        private Panel panelInfo;
        private Panel panelTable;
        private Panel panelSelector;
        private DataGridView dataGridViewTeachers;
        private BindingSource teacherSubjectBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
    }
}