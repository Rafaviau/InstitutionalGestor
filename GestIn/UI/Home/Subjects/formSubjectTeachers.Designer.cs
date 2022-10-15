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
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.teacherSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTeachersSubject = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTeachers = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblteachername = new System.Windows.Forms.Label();
            this.ListboxSearchResults = new System.Windows.Forms.ListBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.lblmateriaName.Location = new System.Drawing.Point(546, 66);
            this.lblmateriaName.Name = "lblmateriaName";
            this.lblmateriaName.Size = new System.Drawing.Size(91, 20);
            this.lblmateriaName.TabIndex = 57;
            this.lblmateriaName.Text = "MateriaAqui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Materia Seleccionada: ";
            // 
            // btnRemoveDocente
            // 
            this.btnRemoveDocente.Location = new System.Drawing.Point(721, 248);
            this.btnRemoveDocente.Name = "btnRemoveDocente";
            this.btnRemoveDocente.Size = new System.Drawing.Size(148, 37);
            this.btnRemoveDocente.TabIndex = 55;
            this.btnRemoveDocente.Text = "Remover Docente";
            this.btnRemoveDocente.UseVisualStyleBackColor = true;
            this.btnRemoveDocente.Click += new System.EventHandler(this.btnRemoveDocente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "Docentes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(167, 326);
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
            this.Active});
            this.dataGridViewTeachers.DataSource = this.teacherSubjectBindingSource;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(167, 364);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RowHeadersWidth = 51;
            this.dataGridViewTeachers.RowTemplate.Height = 29;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(730, 233);
            this.dataGridViewTeachers.TabIndex = 58;
            this.dataGridViewTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeachers_CellClick);
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
            this.txtSearchbar.Location = new System.Drawing.Point(167, 112);
            this.txtSearchbar.Name = "txtSearchbar";
            this.txtSearchbar.Size = new System.Drawing.Size(307, 27);
            this.txtSearchbar.TabIndex = 59;
            this.txtSearchbar.TextChanged += new System.EventHandler(this.txtSearchbar_TextChanged);
            this.txtSearchbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchbar_KeyDown);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(803, 603);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 38);
            this.btnModificar.TabIndex = 60;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(568, 119);
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
            this.lblteachername.Location = new System.Drawing.Point(756, 119);
            this.lblteachername.Name = "lblteachername";
            this.lblteachername.Size = new System.Drawing.Size(125, 20);
            this.lblteachername.TabIndex = 62;
            this.lblteachername.Text = "                             ";
            // 
            // ListboxSearchResults
            // 
            this.ListboxSearchResults.FormattingEnabled = true;
            this.ListboxSearchResults.ItemHeight = 20;
            this.ListboxSearchResults.Location = new System.Drawing.Point(167, 161);
            this.ListboxSearchResults.Name = "ListboxSearchResults";
            this.ListboxSearchResults.Size = new System.Drawing.Size(307, 124);
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
            this.cmbCondition.Location = new System.Drawing.Point(756, 161);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(125, 28);
            this.cmbCondition.TabIndex = 64;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(546, 248);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(134, 37);
            this.btnInsert.TabIndex = 65;
            this.btnInsert.Text = "Agregar Docente";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(568, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Condicion:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            // 
            // Condition
            // 
            this.Condition.DataPropertyName = "Condition";
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 6;
            this.Condition.Name = "Condition";
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            // 
            // formSubjectTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1236, 680);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.ListboxSearchResults);
            this.Controls.Add(this.lblteachername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtSearchbar);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.lblmateriaName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveDocente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Name = "formSubjectTeachers";
            this.Text = "formSubjectTeachers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSubjectTeachers_FormClosed);
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
        private Button btnRemoveDocente;
        private Label label2;
        private Label label7;
        private DataGridView dataGridViewTeachers;
        private BindingSource teacherBindingSource;
        private BindingSource bindingSourceTeachersSubject;
        private BindingSource bindingSourceTeachers;
        private TextBox txtSearchbar;
        private Button btnModificar;
        private Label label3;
        private Label lblteachername;
        private ListBox ListboxSearchResults;
        private BindingSource teacherSubjectBindingSource;
        private ComboBox cmbCondition;
        private Button btnInsert;
        private Label label4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Condition;
        private DataGridViewCheckBoxColumn Active;
    }
}