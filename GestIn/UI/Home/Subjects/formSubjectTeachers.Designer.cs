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
            this.btnRemoveDocente = new System.Windows.Forms.Button();
            this.cbbTeacher = new System.Windows.Forms.ComboBox();
            this.btnAddDocente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.teacherSubjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTeachersSubject = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTeachers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachersSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmateriaName
            // 
            this.lblmateriaName.AutoSize = true;
            this.lblmateriaName.ForeColor = System.Drawing.Color.White;
            this.lblmateriaName.Location = new System.Drawing.Point(312, 78);
            this.lblmateriaName.Name = "lblmateriaName";
            this.lblmateriaName.Size = new System.Drawing.Size(91, 20);
            this.lblmateriaName.TabIndex = 57;
            this.lblmateriaName.Text = "MateriaAqui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Materia Seleccionada: ";
            // 
            // btnRemoveDocente
            // 
            this.btnRemoveDocente.Location = new System.Drawing.Point(347, 193);
            this.btnRemoveDocente.Name = "btnRemoveDocente";
            this.btnRemoveDocente.Size = new System.Drawing.Size(158, 37);
            this.btnRemoveDocente.TabIndex = 55;
            this.btnRemoveDocente.Text = "Remover Docente";
            this.btnRemoveDocente.UseVisualStyleBackColor = true;
            this.btnRemoveDocente.Click += new System.EventHandler(this.btnRemoveDocente_Click);
            // 
            // cbbTeacher
            // 
            this.cbbTeacher.FormattingEnabled = true;
            this.cbbTeacher.Location = new System.Drawing.Point(48, 145);
            this.cbbTeacher.Name = "cbbTeacher";
            this.cbbTeacher.Size = new System.Drawing.Size(216, 28);
            this.cbbTeacher.TabIndex = 54;
            // 
            // btnAddDocente
            // 
            this.btnAddDocente.Location = new System.Drawing.Point(347, 139);
            this.btnAddDocente.Name = "btnAddDocente";
            this.btnAddDocente.Size = new System.Drawing.Size(158, 38);
            this.btnAddDocente.TabIndex = 53;
            this.btnAddDocente.Text = "Agregar Docente";
            this.btnAddDocente.UseVisualStyleBackColor = true;
            this.btnAddDocente.Click += new System.EventHandler(this.btnAddDocente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "Docentes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(185, 263);
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
            this.teacherSubjectsDataGridViewTextBoxColumn});
            this.dataGridViewTeachers.DataSource = this.teacherBindingSource;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(68, 286);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RowHeadersWidth = 51;
            this.dataGridViewTeachers.RowTemplate.Height = 29;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(408, 188);
            this.dataGridViewTeachers.TabIndex = 58;
            // 
            // teacherSubjectsDataGridViewTextBoxColumn
            // 
            this.teacherSubjectsDataGridViewTextBoxColumn.DataPropertyName = "TeacherSubjects";
            this.teacherSubjectsDataGridViewTextBoxColumn.HeaderText = "TeacherSubjects";
            this.teacherSubjectsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherSubjectsDataGridViewTextBoxColumn.Name = "teacherSubjectsDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(GestIn.Model.Teacher);
            // 
            // formSubjectTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(554, 496);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.lblmateriaName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveDocente);
            this.Controls.Add(this.cbbTeacher);
            this.Controls.Add(this.btnAddDocente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "formSubjectTeachers";
            this.Text = "formSubjectTeachers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSubjectTeachers_FormClosed);
            this.Load += new System.EventHandler(this.formSubjectTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachersSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblmateriaName;
        private Label label1;
        private Button btnRemoveDocente;
        private ComboBox cbbTeacher;
        private Button btnAddDocente;
        private Label label2;
        private Label label7;
        private DataGridView dataGridViewTeachers;
        private DataGridViewTextBoxColumn teacherSubjectsDataGridViewTextBoxColumn;
        private BindingSource teacherBindingSource;
        private BindingSource bindingSourceTeachersSubject;
        private BindingSource bindingSourceTeachers;
    }
}