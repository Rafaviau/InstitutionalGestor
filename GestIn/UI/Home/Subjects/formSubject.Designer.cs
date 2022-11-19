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
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCarreraMaterias = new System.Windows.Forms.BindingSource(this.components);
            this.teacherSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lableTimer = new System.Windows.Forms.Timer(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCargaHorariaTotal = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.label123 = new System.Windows.Forms.Label();
            this.btnCorrelativas = new System.Windows.Forms.Button();
            this.lblAnioCarrera = new System.Windows.Forms.Label();
            this.lblShowSubjectName = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbbSubjectYear = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCupof = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dataGridViewMaterias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cbbCarreraSelector = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelCombo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.panelCombo.SuspendLayout();
            this.SuspendLayout();
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
            // teacherSubjectBindingSource
            // 
            this.teacherSubjectBindingSource.DataSource = typeof(GestIn.Model.TeacherSubject);
            // 
            // lableTimer
            // 
            this.lableTimer.Tick += new System.EventHandler(this.lableTimer_Tick);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(323, 38);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(66, 112);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Crear Materia";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCargaHorariaTotal
            // 
            this.txtCargaHorariaTotal.Location = new System.Drawing.Point(152, 101);
            this.txtCargaHorariaTotal.Name = "txtCargaHorariaTotal";
            this.txtCargaHorariaTotal.Size = new System.Drawing.Size(154, 23);
            this.txtCargaHorariaTotal.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Carga Horaria Total: ";
            // 
            // btnDocentes
            // 
            this.btnDocentes.Location = new System.Drawing.Point(609, 94);
            this.btnDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(129, 33);
            this.btnDocentes.TabIndex = 6;
            this.btnDocentes.Text = "Cargar Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.ForeColor = System.Drawing.Color.White;
            this.label123.Location = new System.Drawing.Point(152, 16);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(122, 15);
            this.label123.TabIndex = 37;
            this.label123.Text = "Materia Seleccionada:";
            // 
            // btnCorrelativas
            // 
            this.btnCorrelativas.Location = new System.Drawing.Point(609, 52);
            this.btnCorrelativas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCorrelativas.Name = "btnCorrelativas";
            this.btnCorrelativas.Size = new System.Drawing.Size(129, 34);
            this.btnCorrelativas.TabIndex = 6;
            this.btnCorrelativas.Text = "Cargar Correlativas";
            this.btnCorrelativas.UseVisualStyleBackColor = true;
            this.btnCorrelativas.Click += new System.EventHandler(this.btnCorrelativas_Click);
            // 
            // lblAnioCarrera
            // 
            this.lblAnioCarrera.AutoSize = true;
            this.lblAnioCarrera.ForeColor = System.Drawing.Color.White;
            this.lblAnioCarrera.Location = new System.Drawing.Point(10, 76);
            this.lblAnioCarrera.Name = "lblAnioCarrera";
            this.lblAnioCarrera.Size = new System.Drawing.Size(35, 15);
            this.lblAnioCarrera.TabIndex = 20;
            this.lblAnioCarrera.Text = "Año: ";
            // 
            // lblShowSubjectName
            // 
            this.lblShowSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lblShowSubjectName.ForeColor = System.Drawing.Color.White;
            this.lblShowSubjectName.Location = new System.Drawing.Point(293, 10);
            this.lblShowSubjectName.Name = "lblShowSubjectName";
            this.lblShowSubjectName.Size = new System.Drawing.Size(477, 24);
            this.lblShowSubjectName.TabIndex = 38;
            this.lblShowSubjectName.Text = "                                   ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(10, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 32);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Materia";
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
            this.cbbSubjectYear.Location = new System.Drawing.Point(152, 70);
            this.cbbSubjectYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSubjectYear.Name = "cbbSubjectYear";
            this.cbbSubjectYear.Size = new System.Drawing.Size(154, 23);
            this.cbbSubjectYear.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(408, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Actualizar Materia";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.AllowUserToAddRows = false;
            this.dataGridViewTeachers.AllowUserToDeleteRows = false;
            this.dataGridViewTeachers.AutoGenerateColumns = false;
            this.dataGridViewTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherDataGridViewTextBoxColumn,
            this.Condition});
            this.dataGridViewTeachers.DataSource = this.teacherSubjectBindingSource;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(775, 28);
            this.dataGridViewTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.ReadOnly = true;
            this.dataGridViewTeachers.RowHeadersVisible = false;
            this.dataGridViewTeachers.RowHeadersWidth = 51;
            this.dataGridViewTeachers.RowTemplate.Height = 29;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(396, 114);
            this.dataGridViewTeachers.TabIndex = 39;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.FillWeight = 125F;
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Docentes";
            this.teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Condition
            // 
            this.Condition.DataPropertyName = "Condition";
            this.Condition.FillWeight = 65F;
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 6;
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.txtCupof);
            this.panelInfo.Controls.Add(this.btnRemove);
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
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 402);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1181, 160);
            this.panelInfo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cupof: ";
            // 
            // txtCupof
            // 
            this.txtCupof.Location = new System.Drawing.Point(152, 130);
            this.txtCupof.Name = "txtCupof";
            this.txtCupof.Size = new System.Drawing.Size(154, 23);
            this.txtCupof.TabIndex = 41;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(408, 98);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(153, 23);
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "Dar de baja materia";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.Cupof,
            this.dataGridViewTextBoxColumn14});
            this.dataGridViewMaterias.DataSource = this.subjectBindingSource1;
            this.dataGridViewMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaterias.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMaterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMaterias.MultiSelect = false;
            this.dataGridViewMaterias.Name = "dataGridViewMaterias";
            this.dataGridViewMaterias.ReadOnly = true;
            this.dataGridViewMaterias.RowHeadersVisible = false;
            this.dataGridViewMaterias.RowHeadersWidth = 51;
            this.dataGridViewMaterias.RowTemplate.Height = 29;
            this.dataGridViewMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterias.Size = new System.Drawing.Size(1181, 402);
            this.dataGridViewMaterias.TabIndex = 30;
            this.dataGridViewMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_CellClick);
            this.dataGridViewMaterias.SelectionChanged += new System.EventHandler(this.dataGridViewMaterias_SelectionChanged);
            this.dataGridViewMaterias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewMaterias_KeyDown);
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
            this.dataGridViewTextBoxColumn12.FillWeight = 64.39043F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "YearInCareer";
            this.dataGridViewTextBoxColumn13.FillWeight = 16.61698F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Año";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Cupof
            // 
            this.Cupof.DataPropertyName = "Cupof";
            this.Cupof.FillWeight = 14F;
            this.Cupof.HeaderText = "Cupof";
            this.Cupof.MinimumWidth = 6;
            this.Cupof.Name = "Cupof";
            this.Cupof.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AnnualHourlyLoad";
            this.dataGridViewTextBoxColumn14.FillWeight = 14.37308F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Horas anuales";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridViewMaterias);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1181, 402);
            this.panelGrid.TabIndex = 40;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.ForeColor = System.Drawing.Color.White;
            this.lblCarrera.Location = new System.Drawing.Point(3, 8);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(109, 15);
            this.lblCarrera.TabIndex = 29;
            this.lblCarrera.Text = "Seleccionar carrera:";
            // 
            // cbbCarreraSelector
            // 
            this.cbbCarreraSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCarreraSelector.FormattingEnabled = true;
            this.cbbCarreraSelector.Location = new System.Drawing.Point(129, 5);
            this.cbbCarreraSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCarreraSelector.Name = "cbbCarreraSelector";
            this.cbbCarreraSelector.Size = new System.Drawing.Size(660, 23);
            this.cbbCarreraSelector.TabIndex = 0;
            this.cbbCarreraSelector.SelectedIndexChanged += new System.EventHandler(this.cbCareerSelector_SelectedIndexChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Crimson;
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(823, 8);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 15);
            this.lblResult.TabIndex = 30;
            this.lblResult.Text = "Resultado";
            this.lblResult.Visible = false;
            // 
            // panelCombo
            // 
            this.panelCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCombo.Controls.Add(this.lblResult);
            this.panelCombo.Controls.Add(this.cbbCarreraSelector);
            this.panelCombo.Controls.Add(this.lblCarrera);
            this.panelCombo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCombo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCombo.Location = new System.Drawing.Point(0, 366);
            this.panelCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCombo.Name = "panelCombo";
            this.panelCombo.Size = new System.Drawing.Size(1181, 36);
            this.panelCombo.TabIndex = 31;
            // 
            // formSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1181, 562);
            this.Controls.Add(this.panelCombo);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formSubject";
            this.Text = "Materias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSubject_FormClosing);
            this.Load += new System.EventHandler(this.formSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.panelCombo.ResumeLayout(false);
            this.panelCombo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource bindingSourceCarreras;
        private BindingSource bindingSourceCarreraMaterias;
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
        private BindingSource subjectBindingSource1;
        private BindingSource teacherSubjectBindingSource;
        private System.Windows.Forms.Timer lableTimer;
        private Button btnInsert;
        private TextBox txtCargaHorariaTotal;
        private TextBox txtNombre;
        private Label label5;
        private Button btnDocentes;
        private Label label123;
        private Button btnCorrelativas;
        private Label lblAnioCarrera;
        private Label lblShowSubjectName;
        private Label lblNombre;
        private Label lblTitle;
        private ComboBox cbbSubjectYear;
        private Button btnUpdate;
        private DataGridView dataGridViewTeachers;
        private DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Condition;
        private Panel panelInfo;
        private DataGridView dataGridViewMaterias;
        private Panel panelGrid;
        private Label lblCarrera;
        private ComboBox cbbCarreraSelector;
        private Label lblResult;
        private Panel panelCombo;
        private Button btnRemove;
        private Label label1;
        private TextBox txtCupof;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn Cupof;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}