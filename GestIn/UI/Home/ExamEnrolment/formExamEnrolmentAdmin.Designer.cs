namespace GestIn.UI.Home.ExamEnrolment
{
    partial class formExamEnrolmentAdmin
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.ListBox();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CareerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Career = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(24, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "  Buscar estudiante";
            this.searchBox.Size = new System.Drawing.Size(629, 30);
            this.searchBox.TabIndex = 33;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // lbSearch
            // 
            this.lbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.FormattingEnabled = true;
            this.lbSearch.ItemHeight = 20;
            this.lbSearch.Location = new System.Drawing.Point(24, 48);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(629, 124);
            this.lbSearch.TabIndex = 34;
            this.lbSearch.Visible = false;
            this.lbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSearch_KeyDown);
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.AllowUserToDeleteRows = false;
            this.dgvExams.AllowUserToResizeRows = false;
            this.dgvExams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExams.CausesValidation = false;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamId,
            this.CareerId,
            this.SubjectId,
            this.Career,
            this.Subject,
            this.Date});
            this.dgvExams.Location = new System.Drawing.Point(24, 62);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.RowHeadersWidth = 51;
            this.dgvExams.RowTemplate.Height = 29;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(1221, 531);
            this.dgvExams.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Estudiante:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(993, 12);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(63, 20);
            this.lblStudent.TabIndex = 37;
            this.lblStudent.Text = "---------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Dni:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(993, 34);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(63, 20);
            this.lblDni.TabIndex = 39;
            this.lblDni.Text = "---------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 29);
            this.button1.TabIndex = 40;
            this.button1.Text = "Test correlatives";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExamId
            // 
            this.ExamId.HeaderText = "ExamId";
            this.ExamId.MinimumWidth = 6;
            this.ExamId.Name = "ExamId";
            // 
            // CareerId
            // 
            this.CareerId.HeaderText = "CareerId";
            this.CareerId.MinimumWidth = 6;
            this.CareerId.Name = "CareerId";
            // 
            // SubjectId
            // 
            this.SubjectId.HeaderText = "SubjectId";
            this.SubjectId.MinimumWidth = 6;
            this.SubjectId.Name = "SubjectId";
            // 
            // Career
            // 
            this.Career.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Career.HeaderText = "Carrera";
            this.Career.MinimumWidth = 6;
            this.Career.Name = "Career";
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.HeaderText = "Materia";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.FillWeight = 50F;
            this.Date.HeaderText = "Fecha";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // formExamEnrolmentAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExams);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.lbSearch);
            this.Name = "formExamEnrolmentAdmin";
            this.Text = "formExamEnrolmentAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchBox;
        private ListBox lbSearch;
        private DataGridView dgvExams;
        private Label label1;
        private Label lblStudent;
        private Label label3;
        private Label lblDni;
        private Button button1;
        private DataGridViewTextBoxColumn ExamId;
        private DataGridViewTextBoxColumn CareerId;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn Career;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Date;
    }
}