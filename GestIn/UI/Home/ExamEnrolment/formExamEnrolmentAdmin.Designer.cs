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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.ListBox();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.ExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CareerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Career = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnEnrol = new System.Windows.Forms.Button();
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
            this.lbSearch.Size = new System.Drawing.Size(629, 144);
            this.lbSearch.TabIndex = 34;
            this.lbSearch.Visible = false;
            this.lbSearch.Click += new System.EventHandler(this.lbSearch_Click);
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
            this.dgvExams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.dgvExams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExams.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamId,
            this.CareerId,
            this.SubjectId,
            this.Career,
            this.Subject,
            this.Date});
            this.dgvExams.EnableHeadersVisualStyles = false;
            this.dgvExams.Location = new System.Drawing.Point(24, 61);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExams.RowHeadersVisible = false;
            this.dgvExams.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvExams.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExams.RowTemplate.Height = 29;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(1221, 513);
            this.dgvExams.TabIndex = 35;
            // 
            // ExamId
            // 
            this.ExamId.HeaderText = "ExamId";
            this.ExamId.MinimumWidth = 6;
            this.ExamId.Name = "ExamId";
            this.ExamId.ReadOnly = true;
            this.ExamId.Visible = false;
            // 
            // CareerId
            // 
            this.CareerId.HeaderText = "CareerId";
            this.CareerId.MinimumWidth = 6;
            this.CareerId.Name = "CareerId";
            this.CareerId.ReadOnly = true;
            this.CareerId.Visible = false;
            // 
            // SubjectId
            // 
            this.SubjectId.HeaderText = "SubjectId";
            this.SubjectId.MinimumWidth = 6;
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            this.SubjectId.Visible = false;
            // 
            // Career
            // 
            this.Career.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Career.HeaderText = "Carrera";
            this.Career.MinimumWidth = 6;
            this.Career.Name = "Career";
            this.Career.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.HeaderText = "Materia";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.FillWeight = 50F;
            this.Date.HeaderText = "Fecha";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(906, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Estudiante:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudent.ForeColor = System.Drawing.Color.White;
            this.lblStudent.Location = new System.Drawing.Point(993, 12);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(63, 20);
            this.lblStudent.TabIndex = 37;
            this.lblStudent.Text = "---------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(906, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Dni:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(993, 35);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(63, 20);
            this.lblDni.TabIndex = 39;
            this.lblDni.Text = "---------";
            // 
            // btnEnrol
            // 
            this.btnEnrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnEnrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnrol.ForeColor = System.Drawing.Color.White;
            this.btnEnrol.Location = new System.Drawing.Point(1151, 580);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(94, 44);
            this.btnEnrol.TabIndex = 40;
            this.btnEnrol.Text = "Inscribir";
            this.btnEnrol.UseVisualStyleBackColor = false;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // formExamEnrolmentAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1274, 636);
            this.Controls.Add(this.btnEnrol);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExams);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.lbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private DataGridViewTextBoxColumn ExamId;
        private DataGridViewTextBoxColumn CareerId;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn Career;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Date;
        private Button btnEnrol;
    }
}