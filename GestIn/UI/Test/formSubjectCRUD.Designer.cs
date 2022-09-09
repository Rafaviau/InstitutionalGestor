namespace GestIn.UI.Test.Subject
{
    partial class formSubjectCRUD
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
            this.txtAnioCarrera = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnioCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridViewMaterias = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearInCareerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualHourlyLoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModificationByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativeCorrelativeSubjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativeSubjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectEnrolmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherSubjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCarreraMaterias = new System.Windows.Forms.BindingSource(this.components);
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnCronograma = new System.Windows.Forms.Button();
            this.btnCorrelativas = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(310, 129);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(52, 20);
            this.lblCarrera.TabIndex = 29;
            this.lblCarrera.Text = "Career";
            // 
            // cbbCarreraSelector
            // 
            this.cbbCarreraSelector.Enabled = false;
            this.cbbCarreraSelector.FormattingEnabled = true;
            this.cbbCarreraSelector.Location = new System.Drawing.Point(472, 121);
            this.cbbCarreraSelector.Name = "cbbCarreraSelector";
            this.cbbCarreraSelector.Size = new System.Drawing.Size(175, 28);
            this.cbbCarreraSelector.TabIndex = 28;
            this.cbbCarreraSelector.SelectedIndexChanged += new System.EventHandler(this.cbbCarreraSelector_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(472, 319);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 31);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(370, 319);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 31);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "Guardar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseClick);
            // 
            // txtCargaHorariaTotal
            // 
            this.txtCargaHorariaTotal.Enabled = false;
            this.txtCargaHorariaTotal.Location = new System.Drawing.Point(472, 242);
            this.txtCargaHorariaTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargaHorariaTotal.Name = "txtCargaHorariaTotal";
            this.txtCargaHorariaTotal.Size = new System.Drawing.Size(175, 27);
            this.txtCargaHorariaTotal.TabIndex = 24;
            // 
            // txtAnioCarrera
            // 
            this.txtAnioCarrera.Enabled = false;
            this.txtAnioCarrera.Location = new System.Drawing.Point(472, 201);
            this.txtAnioCarrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnioCarrera.Name = "txtAnioCarrera";
            this.txtAnioCarrera.Size = new System.Drawing.Size(175, 27);
            this.txtAnioCarrera.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(472, 160);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 27);
            this.txtNombre.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "CargaHorariaTotal";
            // 
            // lblAnioCarrera
            // 
            this.lblAnioCarrera.AutoSize = true;
            this.lblAnioCarrera.Location = new System.Drawing.Point(310, 208);
            this.lblAnioCarrera.Name = "lblAnioCarrera";
            this.lblAnioCarrera.Size = new System.Drawing.Size(88, 20);
            this.lblAnioCarrera.TabIndex = 20;
            this.lblAnioCarrera.Text = "AnioCarrera";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(310, 167);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // dataGridViewMaterias
            // 
            this.dataGridViewMaterias.AllowUserToAddRows = false;
            this.dataGridViewMaterias.AllowUserToDeleteRows = false;
            this.dataGridViewMaterias.AllowUserToResizeRows = false;
            this.dataGridViewMaterias.AutoGenerateColumns = false;
            this.dataGridViewMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.careerIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.yearInCareerDataGridViewTextBoxColumn,
            this.annualHourlyLoadDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn,
            this.deletedAtDataGridViewTextBoxColumn,
            this.lastModificationByDataGridViewTextBoxColumn,
            this.careerDataGridViewTextBoxColumn,
            this.correlativeCorrelativeSubjectsDataGridViewTextBoxColumn,
            this.correlativeSubjectsDataGridViewTextBoxColumn,
            this.gradesDataGridViewTextBoxColumn,
            this.schedulesDataGridViewTextBoxColumn,
            this.subjectEnrolmentsDataGridViewTextBoxColumn,
            this.teacherSubjectsDataGridViewTextBoxColumn});
            this.dataGridViewMaterias.DataSource = this.subjectBindingSource;
            this.dataGridViewMaterias.Location = new System.Drawing.Point(29, 416);
            this.dataGridViewMaterias.Name = "dataGridViewMaterias";
            this.dataGridViewMaterias.ReadOnly = true;
            this.dataGridViewMaterias.RowHeadersWidth = 51;
            this.dataGridViewMaterias.RowTemplate.Height = 29;
            this.dataGridViewMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterias.Size = new System.Drawing.Size(774, 319);
            this.dataGridViewMaterias.TabIndex = 30;
            this.dataGridViewMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 51;
            // 
            // careerIdDataGridViewTextBoxColumn
            // 
            this.careerIdDataGridViewTextBoxColumn.DataPropertyName = "CareerId";
            this.careerIdDataGridViewTextBoxColumn.HeaderText = "CareerId";
            this.careerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.careerIdDataGridViewTextBoxColumn.Name = "careerIdDataGridViewTextBoxColumn";
            this.careerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.careerIdDataGridViewTextBoxColumn.Width = 94;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 78;
            // 
            // yearInCareerDataGridViewTextBoxColumn
            // 
            this.yearInCareerDataGridViewTextBoxColumn.DataPropertyName = "YearInCareer";
            this.yearInCareerDataGridViewTextBoxColumn.HeaderText = "YearInCareer";
            this.yearInCareerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearInCareerDataGridViewTextBoxColumn.Name = "yearInCareerDataGridViewTextBoxColumn";
            this.yearInCareerDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearInCareerDataGridViewTextBoxColumn.Width = 121;
            // 
            // annualHourlyLoadDataGridViewTextBoxColumn
            // 
            this.annualHourlyLoadDataGridViewTextBoxColumn.DataPropertyName = "AnnualHourlyLoad";
            this.annualHourlyLoadDataGridViewTextBoxColumn.HeaderText = "AnnualHourlyLoad";
            this.annualHourlyLoadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.annualHourlyLoadDataGridViewTextBoxColumn.Name = "annualHourlyLoadDataGridViewTextBoxColumn";
            this.annualHourlyLoadDataGridViewTextBoxColumn.ReadOnly = true;
            this.annualHourlyLoadDataGridViewTextBoxColumn.Width = 161;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Width = 105;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn.Width = 111;
            // 
            // deletedAtDataGridViewTextBoxColumn
            // 
            this.deletedAtDataGridViewTextBoxColumn.DataPropertyName = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.HeaderText = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedAtDataGridViewTextBoxColumn.Name = "deletedAtDataGridViewTextBoxColumn";
            this.deletedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedAtDataGridViewTextBoxColumn.Width = 106;
            // 
            // lastModificationByDataGridViewTextBoxColumn
            // 
            this.lastModificationByDataGridViewTextBoxColumn.DataPropertyName = "LastModificationBy";
            this.lastModificationByDataGridViewTextBoxColumn.HeaderText = "LastModificationBy";
            this.lastModificationByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastModificationByDataGridViewTextBoxColumn.Name = "lastModificationByDataGridViewTextBoxColumn";
            this.lastModificationByDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastModificationByDataGridViewTextBoxColumn.Width = 165;
            // 
            // careerDataGridViewTextBoxColumn
            // 
            this.careerDataGridViewTextBoxColumn.DataPropertyName = "Career";
            this.careerDataGridViewTextBoxColumn.HeaderText = "Career";
            this.careerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.careerDataGridViewTextBoxColumn.Name = "careerDataGridViewTextBoxColumn";
            this.careerDataGridViewTextBoxColumn.ReadOnly = true;
            this.careerDataGridViewTextBoxColumn.Width = 81;
            // 
            // correlativeCorrelativeSubjectsDataGridViewTextBoxColumn
            // 
            this.correlativeCorrelativeSubjectsDataGridViewTextBoxColumn.DataPropertyName = "CorrelativeCorrelativeSubjects";
            this.correlativeCorrelativeSubjectsDataGridViewTextBoxColumn.HeaderText = "CorrelativeCorrelativeSubjects";
            this.correlativeCorrelativeSubjectsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correlativeCorrelativeSubjectsDataGridViewTextBoxColumn.Name = "correlativeCorrelativeSubjectsDataGridViewTextBoxColumn";
            this.correlativeCorrelativeSubjectsDataGridViewTextBoxColumn.ReadOnly = true;
            this.correlativeCorrelativeSubjectsDataGridViewTextBoxColumn.Width = 237;
            // 
            // correlativeSubjectsDataGridViewTextBoxColumn
            // 
            this.correlativeSubjectsDataGridViewTextBoxColumn.DataPropertyName = "CorrelativeSubjects";
            this.correlativeSubjectsDataGridViewTextBoxColumn.HeaderText = "CorrelativeSubjects";
            this.correlativeSubjectsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correlativeSubjectsDataGridViewTextBoxColumn.Name = "correlativeSubjectsDataGridViewTextBoxColumn";
            this.correlativeSubjectsDataGridViewTextBoxColumn.ReadOnly = true;
            this.correlativeSubjectsDataGridViewTextBoxColumn.Width = 165;
            // 
            // gradesDataGridViewTextBoxColumn
            // 
            this.gradesDataGridViewTextBoxColumn.DataPropertyName = "Grades";
            this.gradesDataGridViewTextBoxColumn.HeaderText = "Grades";
            this.gradesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradesDataGridViewTextBoxColumn.Name = "gradesDataGridViewTextBoxColumn";
            this.gradesDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradesDataGridViewTextBoxColumn.Width = 84;
            // 
            // schedulesDataGridViewTextBoxColumn
            // 
            this.schedulesDataGridViewTextBoxColumn.DataPropertyName = "Schedules";
            this.schedulesDataGridViewTextBoxColumn.HeaderText = "Schedules";
            this.schedulesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.schedulesDataGridViewTextBoxColumn.Name = "schedulesDataGridViewTextBoxColumn";
            this.schedulesDataGridViewTextBoxColumn.ReadOnly = true;
            this.schedulesDataGridViewTextBoxColumn.Width = 104;
            // 
            // subjectEnrolmentsDataGridViewTextBoxColumn
            // 
            this.subjectEnrolmentsDataGridViewTextBoxColumn.DataPropertyName = "SubjectEnrolments";
            this.subjectEnrolmentsDataGridViewTextBoxColumn.HeaderText = "SubjectEnrolments";
            this.subjectEnrolmentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectEnrolmentsDataGridViewTextBoxColumn.Name = "subjectEnrolmentsDataGridViewTextBoxColumn";
            this.subjectEnrolmentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectEnrolmentsDataGridViewTextBoxColumn.Width = 161;
            // 
            // teacherSubjectsDataGridViewTextBoxColumn
            // 
            this.teacherSubjectsDataGridViewTextBoxColumn.DataPropertyName = "TeacherSubjects";
            this.teacherSubjectsDataGridViewTextBoxColumn.HeaderText = "TeacherSubjects";
            this.teacherSubjectsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherSubjectsDataGridViewTextBoxColumn.Name = "teacherSubjectsDataGridViewTextBoxColumn";
            this.teacherSubjectsDataGridViewTextBoxColumn.ReadOnly = true;
            this.teacherSubjectsDataGridViewTextBoxColumn.Width = 144;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(GestIn.Model.Subject);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "CRUD SUBJECT";
            // 
            // btnDocentes
            // 
            this.btnDocentes.Location = new System.Drawing.Point(827, 543);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(107, 51);
            this.btnDocentes.TabIndex = 33;
            this.btnDocentes.Text = "Cargar Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnCronograma
            // 
            this.btnCronograma.Location = new System.Drawing.Point(827, 629);
            this.btnCronograma.Name = "btnCronograma";
            this.btnCronograma.Size = new System.Drawing.Size(107, 62);
            this.btnCronograma.TabIndex = 34;
            this.btnCronograma.Text = "Cargar Cronograma";
            this.btnCronograma.UseVisualStyleBackColor = true;
            // 
            // btnCorrelativas
            // 
            this.btnCorrelativas.Location = new System.Drawing.Point(827, 460);
            this.btnCorrelativas.Name = "btnCorrelativas";
            this.btnCorrelativas.Size = new System.Drawing.Size(107, 52);
            this.btnCorrelativas.TabIndex = 35;
            this.btnCorrelativas.Text = "Cargar Correlativas";
            this.btnCorrelativas.UseVisualStyleBackColor = true;
            this.btnCorrelativas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCorrelativas_MouseClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(709, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseClick);
            // 
            // formSubjectCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCorrelativas);
            this.Controls.Add(this.btnCronograma);
            this.Controls.Add(this.btnDocentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMaterias);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cbbCarreraSelector);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtCargaHorariaTotal);
            this.Controls.Add(this.txtAnioCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAnioCarrera);
            this.Controls.Add(this.lblNombre);
            this.Name = "formSubjectCRUD";
            this.Text = "formSubjectCRUD";
            this.Load += new System.EventHandler(this.formSubjectCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCarrera;
        private ComboBox cbbCarreraSelector;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox txtCargaHorariaTotal;
        private TextBox txtAnioCarrera;
        private TextBox txtNombre;
        private Label label5;
        private Label lblAnioCarrera;
        private Label lblNombre;
        private DataGridView dataGridViewMaterias;
        private Label label1;
        private BindingSource bindingSourceCarreras;
        private BindingSource bindingSourceCarreraMaterias;
        private Button btnDocentes;
        private Button btnCronograma;
        private Button btnCorrelativas;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cAREERIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yEARINCAREERDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aNNUALHOURLYLOADDataGridViewTextBoxColumn;
        private BindingSource subjectBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn careerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearInCareerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn annualHourlyLoadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deletedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastModificationByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn careerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correlativeCorrelativeSubjectsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correlativeSubjectsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gradesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schedulesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectEnrolmentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teacherSubjectsDataGridViewTextBoxColumn;
        private Button btnModificar;
    }
}