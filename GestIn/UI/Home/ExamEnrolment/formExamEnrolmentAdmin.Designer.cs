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
            this.searchBox.Location = new System.Drawing.Point(126, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "  Buscar estudiante";
            this.searchBox.Size = new System.Drawing.Size(628, 30);
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
            this.lbSearch.Location = new System.Drawing.Point(126, 48);
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
            this.dgvExams.Size = new System.Drawing.Size(825, 434);
            this.dgvExams.TabIndex = 35;
            // 
            // ExamId
            // 
            this.ExamId.HeaderText = "ExamId";
            this.ExamId.MinimumWidth = 6;
            this.ExamId.Name = "ExamId";
            this.ExamId.Visible = false;
            // 
            // CareerId
            // 
            this.CareerId.HeaderText = "CareerId";
            this.CareerId.MinimumWidth = 6;
            this.CareerId.Name = "CareerId";
            this.CareerId.Visible = false;
            // 
            // SubjectId
            // 
            this.SubjectId.HeaderText = "SubjectId";
            this.SubjectId.MinimumWidth = 6;
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(878, 532);
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
        private DataGridViewTextBoxColumn ExamId;
        private DataGridViewTextBoxColumn CareerId;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn Career;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Date;
    }
}