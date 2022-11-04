namespace GestIn.UI.Home.Subjects
{
    partial class formSubjectTeachers
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
            this.lblmateriaName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DateSince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTeachersSubject = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTeachers = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblteachername = new System.Windows.Forms.Label();
            this.ListboxSearchResults = new System.Windows.Forms.ListBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModifyUntil = new System.Windows.Forms.Button();
            this.btnDeactivateSubstitute = new System.Windows.Forms.Button();
            this.dateTimePickerSince = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerUntil = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeactivateTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachersSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmateriaName
            // 
            this.lblmateriaName.AutoSize = true;
            this.lblmateriaName.ForeColor = System.Drawing.Color.White;
            this.lblmateriaName.Location = new System.Drawing.Point(683, 57);
            this.lblmateriaName.Name = "lblmateriaName";
            this.lblmateriaName.Size = new System.Drawing.Size(91, 20);
            this.lblmateriaName.TabIndex = 57;
            this.lblmateriaName.Text = "MateriaAqui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(518, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Materia Seleccionada: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(601, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "Docentes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(112, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Docentes de la Materia";
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
            this.Id,
            this.teacherDataGridViewTextBoxColumn,
            this.Condition,
            this.Active,
            this.DateSince,
            this.DateUntil});
            this.dataGridViewTeachers.DataSource = this.teacherSubjectBindingSource;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(112, 371);
            this.dataGridViewTeachers.MultiSelect = false;
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.ReadOnly = true;
            this.dataGridViewTeachers.RowHeadersVisible = false;
            this.dataGridViewTeachers.RowHeadersWidth = 51;
            this.dataGridViewTeachers.RowTemplate.Height = 29;
            this.dataGridViewTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(1054, 276);
            this.dataGridViewTeachers.TabIndex = 58;
            this.dataGridViewTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeachers_CellClick);
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
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.FillWeight = 140F;
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Docente";
            this.teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Condition
            // 
            this.Condition.DataPropertyName = "Condition";
            this.Condition.HeaderText = "Condición";
            this.Condition.MinimumWidth = 6;
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.FillWeight = 80F;
            this.Active.HeaderText = "Activo";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // DateSince
            // 
            this.DateSince.DataPropertyName = "DateSince";
            this.DateSince.FillWeight = 90F;
            this.DateSince.HeaderText = "Fecha Desde";
            this.DateSince.MinimumWidth = 6;
            this.DateSince.Name = "DateSince";
            this.DateSince.ReadOnly = true;
            // 
            // DateUntil
            // 
            this.DateUntil.DataPropertyName = "DateUntil";
            this.DateUntil.FillWeight = 90F;
            this.DateUntil.HeaderText = "Fecha Hasta";
            this.DateUntil.MinimumWidth = 6;
            this.DateUntil.Name = "DateUntil";
            this.DateUntil.ReadOnly = true;
            // 
            // teacherSubjectBindingSource
            // 
            this.teacherSubjectBindingSource.DataSource = typeof(GestIn.Model.TeacherSubject);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(GestIn.Model.Teacher);
            // 
            // txtSearchbar
            // 
            this.txtSearchbar.Location = new System.Drawing.Point(112, 112);
            this.txtSearchbar.Name = "txtSearchbar";
            this.txtSearchbar.Size = new System.Drawing.Size(348, 27);
            this.txtSearchbar.TabIndex = 59;
            this.txtSearchbar.TextChanged += new System.EventHandler(this.txtSearchbar_TextChanged);
            this.txtSearchbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchbar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(517, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Docente seleccionado:";
            // 
            // lblteachername
            // 
            this.lblteachername.AutoSize = true;
            this.lblteachername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblteachername.ForeColor = System.Drawing.Color.White;
            this.lblteachername.Location = new System.Drawing.Point(692, 180);
            this.lblteachername.Name = "lblteachername";
            this.lblteachername.Size = new System.Drawing.Size(125, 20);
            this.lblteachername.TabIndex = 62;
            this.lblteachername.Text = "                             ";
            // 
            // ListboxSearchResults
            // 
            this.ListboxSearchResults.FormattingEnabled = true;
            this.ListboxSearchResults.ItemHeight = 20;
            this.ListboxSearchResults.Location = new System.Drawing.Point(112, 164);
            this.ListboxSearchResults.Name = "ListboxSearchResults";
            this.ListboxSearchResults.Size = new System.Drawing.Size(348, 124);
            this.ListboxSearchResults.TabIndex = 63;
            this.ListboxSearchResults.DoubleClick += new System.EventHandler(this.ListboxSearchResults_DoubleClick);
            this.ListboxSearchResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListboxSearchResults_KeyDown);
            // 
            // cmbCondition
            // 
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.Enabled = false;
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "Titular",
            "Suplente",
            "Provisional"});
            this.cmbCondition.Location = new System.Drawing.Point(692, 223);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(125, 28);
            this.cmbCondition.TabIndex = 64;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(453, 331);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(148, 34);
            this.btnInsert.TabIndex = 65;
            this.btnInsert.Text = "Activar Docente";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(518, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Situación de Revista:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(906, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Fecha Inicio: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(906, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Fecha Cese:";
            // 
            // btnModifyUntil
            // 
            this.btnModifyUntil.Location = new System.Drawing.Point(1022, 335);
            this.btnModifyUntil.Name = "btnModifyUntil";
            this.btnModifyUntil.Size = new System.Drawing.Size(144, 31);
            this.btnModifyUntil.TabIndex = 72;
            this.btnModifyUntil.Text = "Modificar Fechas";
            this.btnModifyUntil.UseVisualStyleBackColor = true;
            this.btnModifyUntil.Click += new System.EventHandler(this.btnModifyDates_Click);
            // 
            // btnDeactivateSubstitute
            // 
            this.btnDeactivateSubstitute.Location = new System.Drawing.Point(768, 331);
            this.btnDeactivateSubstitute.Name = "btnDeactivateSubstitute";
            this.btnDeactivateSubstitute.Size = new System.Drawing.Size(155, 34);
            this.btnDeactivateSubstitute.TabIndex = 73;
            this.btnDeactivateSubstitute.Text = "Desactivar Suplente";
            this.btnDeactivateSubstitute.UseVisualStyleBackColor = true;
            this.btnDeactivateSubstitute.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // dateTimePickerSince
            // 
            this.dateTimePickerSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSince.Location = new System.Drawing.Point(1030, 179);
            this.dateTimePickerSince.Name = "dateTimePickerSince";
            this.dateTimePickerSince.Size = new System.Drawing.Size(125, 27);
            this.dateTimePickerSince.TabIndex = 74;
            this.dateTimePickerSince.Value = new System.DateTime(2022, 10, 27, 18, 45, 8, 0);
            // 
            // dateTimePickerUntil
            // 
            this.dateTimePickerUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUntil.Location = new System.Drawing.Point(1030, 224);
            this.dateTimePickerUntil.Name = "dateTimePickerUntil";
            this.dateTimePickerUntil.Size = new System.Drawing.Size(125, 27);
            this.dateTimePickerUntil.TabIndex = 75;
            this.dateTimePickerUntil.Value = new System.DateTime(2022, 10, 27, 18, 45, 8, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(112, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Ingrese el nombre de un docente:";
            // 
            // btnDeactivateTeacher
            // 
            this.btnDeactivateTeacher.Location = new System.Drawing.Point(607, 331);
            this.btnDeactivateTeacher.Name = "btnDeactivateTeacher";
            this.btnDeactivateTeacher.Size = new System.Drawing.Size(155, 34);
            this.btnDeactivateTeacher.TabIndex = 77;
            this.btnDeactivateTeacher.Text = "Desactivar Docente";
            this.btnDeactivateTeacher.UseVisualStyleBackColor = true;
            this.btnDeactivateTeacher.Click += new System.EventHandler(this.btnDeactivateTeacher_Click);
            // 
            // formSubjectTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1241, 699);
            this.Controls.Add(this.btnDeactivateTeacher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerUntil);
            this.Controls.Add(this.dateTimePickerSince);
            this.Controls.Add(this.btnDeactivateSubstitute);
            this.Controls.Add(this.btnModifyUntil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.ListboxSearchResults);
            this.Controls.Add(this.lblteachername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchbar);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.lblmateriaName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "formSubjectTeachers";
            this.Text = "Docentes de una Materia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSubjectTeachers_FormClosing);
            this.Load += new System.EventHandler(this.formSubjectTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachersSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblmateriaName;
        private Label label1;
        private Label label2;
        private Label label7;
        private DataGridView dataGridViewTeachers;
        private BindingSource teacherBindingSource;
        private BindingSource bindingSourceTeachersSubject;
        private BindingSource bindingSourceTeachers;
        private TextBox txtSearchbar;
        private Label label3;
        private Label lblteachername;
        private ListBox ListboxSearchResults;
        private BindingSource teacherSubjectBindingSource;
        private ComboBox cmbCondition;
        private Button btnInsert;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnModifyUntil;
        private Button btnDeactivateSubstitute;
        private DateTimePicker dateTimePickerSince;
        private DateTimePicker dateTimePickerUntil;
        private Label label8;
        private Button btnDeactivateTeacher;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Condition;
        private DataGridViewCheckBoxColumn Active;
        private DataGridViewTextBoxColumn DateSince;
        private DataGridViewTextBoxColumn DateUntil;
    }
}