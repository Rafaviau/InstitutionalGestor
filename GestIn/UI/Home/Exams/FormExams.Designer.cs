namespace GestIn.UI.Home.Exams
{
    partial class FormExams
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.lblCarrer = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTenured = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdateExam = new System.Windows.Forms.Button();
            this.gbNewExam = new System.Windows.Forms.GroupBox();
            this.lblExamCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.lblShowThird = new System.Windows.Forms.Label();
            this.lblShowFirst = new System.Windows.Forms.Label();
            this.lblShowPlace = new System.Windows.Forms.Label();
            this.lblShowSec = new System.Windows.Forms.Label();
            this.lblShowTit = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.lblShowSubject = new System.Windows.Forms.Label();
            this.lblShowCareer = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.cbb3Vowel = new System.Windows.Forms.ComboBox();
            this.cbb1Vowel = new System.Windows.Forms.ComboBox();
            this.cbb2Vowel = new System.Windows.Forms.ComboBox();
            this.cbbTitular = new System.Windows.Forms.ComboBox();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.cbbCarrer = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnNewExam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnGenerateActaVolante = new System.Windows.Forms.Button();
            this.btnGenerateExams = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtSearchDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchExam = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toggDate = new GestIn.controls.ToggleButton();
            this.panel3 = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CareerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.button1 = new System.Windows.Forms.Button();
>>>>>>> 6631b5b6d17632583f5edda7d0760b64a44a9f2c
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.gbNewExam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.AllowUserToDeleteRows = false;
            this.dgvExams.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.dgvExams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dgvExams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.carrer,
            this.subject,
            this.date,
            this.enrollments,
            this.SubjectId,
            this.CareerId});
            this.dgvExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExams.EnableHeadersVisualStyles = false;
            this.dgvExams.Location = new System.Drawing.Point(0, 0);
            this.dgvExams.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dgvExams.MultiSelect = false;
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvExams.RowHeadersVisible = false;
            this.dgvExams.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExams.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(1371, 379);
            this.dgvExams.TabIndex = 0;
            this.dgvExams.SelectionChanged += new System.EventHandler(this.dgvExams_SelectionChanged);
            this.dgvExams.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvExams_KeyDown);
            this.dgvExams.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvExams_MouseDoubleClick);
            // 
            // lblCarrer
            // 
            this.lblCarrer.AutoSize = true;
            this.lblCarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCarrer.ForeColor = System.Drawing.Color.White;
            this.lblCarrer.Location = new System.Drawing.Point(13, 41);
            this.lblCarrer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCarrer.Name = "lblCarrer";
            this.lblCarrer.Size = new System.Drawing.Size(79, 20);
            this.lblCarrer.TabIndex = 2;
            this.lblCarrer.Text = "Carrera:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.Color.White;
            this.lblSubject.Location = new System.Drawing.Point(13, 111);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(78, 20);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Materia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.CalendarForeColor = System.Drawing.Color.Cyan;
            this.dtDate.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dtDate.CalendarTitleBackColor = System.Drawing.Color.Lime;
            this.dtDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtDate.CalendarTrailingForeColor = System.Drawing.Color.Yellow;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(91, 243);
            this.dtDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtDate.MinimumSize = new System.Drawing.Size(114, 4);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(253, 27);
            this.dtDate.TabIndex = 3;
            this.dtDate.Value = new System.DateTime(2022, 11, 4, 9, 34, 25, 0);
            this.dtDate.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(363, 248);
            this.lblTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(78, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Horario:";
            // 
            // lblTenured
            // 
            this.lblTenured.AutoSize = true;
            this.lblTenured.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenured.ForeColor = System.Drawing.Color.White;
            this.lblTenured.Location = new System.Drawing.Point(13, 179);
            this.lblTenured.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenured.Name = "lblTenured";
            this.lblTenured.Size = new System.Drawing.Size(69, 20);
            this.lblTenured.TabIndex = 11;
            this.lblTenured.Text = "Titular:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(719, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "1er vocal:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(717, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "2do vocal:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(719, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "3er vocal:";
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteExam.ForeColor = System.Drawing.Color.White;
            this.btnDeleteExam.Image = global::GestIn.Properties.Resources.deleteIcon;
            this.btnDeleteExam.Location = new System.Drawing.Point(371, 5);
            this.btnDeleteExam.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(63, 35);
            this.btnDeleteExam.TabIndex = 20;
            this.btnDeleteExam.UseVisualStyleBackColor = false;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1007, 248);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Crear";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdateExam
            // 
            this.btnUpdateExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnUpdateExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateExam.ForeColor = System.Drawing.Color.White;
            this.btnUpdateExam.Location = new System.Drawing.Point(198, 5);
            this.btnUpdateExam.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateExam.Name = "btnUpdateExam";
            this.btnUpdateExam.Size = new System.Drawing.Size(165, 35);
            this.btnUpdateExam.TabIndex = 22;
            this.btnUpdateExam.Text = "Modificar";
            this.btnUpdateExam.UseVisualStyleBackColor = false;
            this.btnUpdateExam.Click += new System.EventHandler(this.btnUpdateExam_Click);
            // 
            // gbNewExam
            // 
            this.gbNewExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(87)))), ((int)(((byte)(93)))));
            this.gbNewExam.Controls.Add(this.lblExamCode);
            this.gbNewExam.Controls.Add(this.label6);
            this.gbNewExam.Controls.Add(this.btnSaveUpdate);
            this.gbNewExam.Controls.Add(this.lblShowThird);
            this.gbNewExam.Controls.Add(this.lblShowFirst);
            this.gbNewExam.Controls.Add(this.lblShowPlace);
            this.gbNewExam.Controls.Add(this.lblShowSec);
            this.gbNewExam.Controls.Add(this.lblShowTit);
            this.gbNewExam.Controls.Add(this.lblShowTime);
            this.gbNewExam.Controls.Add(this.lblShowDate);
            this.gbNewExam.Controls.Add(this.lblShowSubject);
            this.gbNewExam.Controls.Add(this.lblShowCareer);
            this.gbNewExam.Controls.Add(this.btnCancel);
            this.gbNewExam.Controls.Add(this.txtPlace);
            this.gbNewExam.Controls.Add(this.label2);
            this.gbNewExam.Controls.Add(this.dtTime);
            this.gbNewExam.Controls.Add(this.cbb3Vowel);
            this.gbNewExam.Controls.Add(this.cbb1Vowel);
            this.gbNewExam.Controls.Add(this.cbb2Vowel);
            this.gbNewExam.Controls.Add(this.cbbTitular);
            this.gbNewExam.Controls.Add(this.cbbSubject);
            this.gbNewExam.Controls.Add(this.cbbCarrer);
            this.gbNewExam.Controls.Add(this.lblCarrer);
            this.gbNewExam.Controls.Add(this.btnSave);
            this.gbNewExam.Controls.Add(this.lblSubject);
            this.gbNewExam.Controls.Add(this.label1);
            this.gbNewExam.Controls.Add(this.label5);
            this.gbNewExam.Controls.Add(this.dtDate);
            this.gbNewExam.Controls.Add(this.lblTime);
            this.gbNewExam.Controls.Add(this.label4);
            this.gbNewExam.Controls.Add(this.label3);
            this.gbNewExam.Controls.Add(this.lblTenured);
            this.gbNewExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbNewExam.ForeColor = System.Drawing.Color.White;
            this.gbNewExam.Location = new System.Drawing.Point(5, 484);
            this.gbNewExam.Margin = new System.Windows.Forms.Padding(5);
            this.gbNewExam.Name = "gbNewExam";
            this.gbNewExam.Padding = new System.Windows.Forms.Padding(5);
            this.gbNewExam.Size = new System.Drawing.Size(1371, 299);
            this.gbNewExam.TabIndex = 23;
            this.gbNewExam.TabStop = false;
            // 
            // lblExamCode
            // 
            this.lblExamCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExamCode.AutoSize = true;
            this.lblExamCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExamCode.ForeColor = System.Drawing.Color.White;
            this.lblExamCode.Location = new System.Drawing.Point(858, 261);
            this.lblExamCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblExamCode.Name = "lblExamCode";
            this.lblExamCode.Size = new System.Drawing.Size(39, 20);
            this.lblExamCode.TabIndex = 68;
            this.lblExamCode.Text = "-----";
            this.lblExamCode.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(775, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Codigo:";
            this.label6.Visible = false;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSaveUpdate.Location = new System.Drawing.Point(1007, 248);
            this.btnSaveUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(135, 35);
            this.btnSaveUpdate.TabIndex = 10;
            this.btnSaveUpdate.Text = "Actualizar";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Visible = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // lblShowThird
            // 
            this.lblShowThird.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblShowThird.AutoSize = true;
            this.lblShowThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowThird.ForeColor = System.Drawing.Color.White;
            this.lblShowThird.Location = new System.Drawing.Point(812, 205);
            this.lblShowThird.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowThird.Name = "lblShowThird";
            this.lblShowThird.Size = new System.Drawing.Size(39, 20);
            this.lblShowThird.TabIndex = 65;
            this.lblShowThird.Text = "-----";
            // 
            // lblShowFirst
            // 
            this.lblShowFirst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblShowFirst.AutoSize = true;
            this.lblShowFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowFirst.ForeColor = System.Drawing.Color.White;
            this.lblShowFirst.Location = new System.Drawing.Point(812, 71);
            this.lblShowFirst.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowFirst.Name = "lblShowFirst";
            this.lblShowFirst.Size = new System.Drawing.Size(39, 20);
            this.lblShowFirst.TabIndex = 64;
            this.lblShowFirst.Text = "-----";
            // 
            // lblShowPlace
            // 
            this.lblShowPlace.AutoSize = true;
            this.lblShowPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowPlace.ForeColor = System.Drawing.Color.White;
            this.lblShowPlace.Location = new System.Drawing.Point(551, 205);
            this.lblShowPlace.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowPlace.Name = "lblShowPlace";
            this.lblShowPlace.Size = new System.Drawing.Size(39, 20);
            this.lblShowPlace.TabIndex = 63;
            this.lblShowPlace.Text = "-----";
            // 
            // lblShowSec
            // 
            this.lblShowSec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblShowSec.AutoSize = true;
            this.lblShowSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowSec.ForeColor = System.Drawing.Color.White;
            this.lblShowSec.Location = new System.Drawing.Point(812, 138);
            this.lblShowSec.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowSec.Name = "lblShowSec";
            this.lblShowSec.Size = new System.Drawing.Size(39, 20);
            this.lblShowSec.TabIndex = 62;
            this.lblShowSec.Text = "-----";
            // 
            // lblShowTit
            // 
            this.lblShowTit.AutoSize = true;
            this.lblShowTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowTit.ForeColor = System.Drawing.Color.White;
            this.lblShowTit.Location = new System.Drawing.Point(95, 179);
            this.lblShowTit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowTit.Name = "lblShowTit";
            this.lblShowTit.Size = new System.Drawing.Size(39, 20);
            this.lblShowTit.TabIndex = 61;
            this.lblShowTit.Text = "-----";
            // 
            // lblShowTime
            // 
            this.lblShowTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowTime.ForeColor = System.Drawing.Color.White;
            this.lblShowTime.Location = new System.Drawing.Point(451, 248);
            this.lblShowTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(39, 20);
            this.lblShowTime.TabIndex = 60;
            this.lblShowTime.Text = "-----";
            // 
            // lblShowDate
            // 
            this.lblShowDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowDate.ForeColor = System.Drawing.Color.White;
            this.lblShowDate.Location = new System.Drawing.Point(95, 248);
            this.lblShowDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(39, 20);
            this.lblShowDate.TabIndex = 59;
            this.lblShowDate.Text = "-----";
            // 
            // lblShowSubject
            // 
            this.lblShowSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowSubject.AutoSize = true;
            this.lblShowSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowSubject.ForeColor = System.Drawing.Color.White;
            this.lblShowSubject.Location = new System.Drawing.Point(95, 111);
            this.lblShowSubject.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowSubject.Name = "lblShowSubject";
            this.lblShowSubject.Size = new System.Drawing.Size(39, 20);
            this.lblShowSubject.TabIndex = 58;
            this.lblShowSubject.Text = "-----";
            // 
            // lblShowCareer
            // 
            this.lblShowCareer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowCareer.AutoSize = true;
            this.lblShowCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowCareer.ForeColor = System.Drawing.Color.White;
            this.lblShowCareer.Location = new System.Drawing.Point(95, 41);
            this.lblShowCareer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShowCareer.Name = "lblShowCareer";
            this.lblShowCareer.Size = new System.Drawing.Size(39, 20);
            this.lblShowCareer.TabIndex = 57;
            this.lblShowCareer.Text = "-----";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1154, 248);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPlace
            // 
            this.txtPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtPlace.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlace.ForeColor = System.Drawing.Color.White;
            this.txtPlace.Location = new System.Drawing.Point(546, 200);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(150, 30);
            this.txtPlace.TabIndex = 7;
            this.txtPlace.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(478, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Lugar:";
            // 
            // dtTime
            // 
            this.dtTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtTime.CustomFormat = "HH:mm";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(449, 243);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(95, 27);
            this.dtTime.TabIndex = 4;
            this.dtTime.Visible = false;
            // 
            // cbb3Vowel
            // 
            this.cbb3Vowel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbb3Vowel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbb3Vowel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb3Vowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb3Vowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb3Vowel.ForeColor = System.Drawing.Color.White;
            this.cbb3Vowel.FormattingEnabled = true;
            this.cbb3Vowel.Location = new System.Drawing.Point(812, 199);
            this.cbb3Vowel.Margin = new System.Windows.Forms.Padding(5);
            this.cbb3Vowel.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbb3Vowel.Name = "cbb3Vowel";
            this.cbb3Vowel.Size = new System.Drawing.Size(500, 28);
            this.cbb3Vowel.Sorted = true;
            this.cbb3Vowel.TabIndex = 9;
            this.cbb3Vowel.Visible = false;
            // 
            // cbb1Vowel
            // 
            this.cbb1Vowel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbb1Vowel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbb1Vowel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb1Vowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb1Vowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb1Vowel.ForeColor = System.Drawing.Color.White;
            this.cbb1Vowel.FormattingEnabled = true;
            this.cbb1Vowel.Location = new System.Drawing.Point(812, 67);
            this.cbb1Vowel.Margin = new System.Windows.Forms.Padding(5);
            this.cbb1Vowel.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbb1Vowel.Name = "cbb1Vowel";
            this.cbb1Vowel.Size = new System.Drawing.Size(500, 28);
            this.cbb1Vowel.Sorted = true;
            this.cbb1Vowel.TabIndex = 8;
            this.cbb1Vowel.Visible = false;
            // 
            // cbb2Vowel
            // 
            this.cbb2Vowel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb2Vowel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbb2Vowel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb2Vowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb2Vowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb2Vowel.ForeColor = System.Drawing.Color.White;
            this.cbb2Vowel.FormattingEnabled = true;
            this.cbb2Vowel.Location = new System.Drawing.Point(812, 133);
            this.cbb2Vowel.Margin = new System.Windows.Forms.Padding(5);
            this.cbb2Vowel.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbb2Vowel.Name = "cbb2Vowel";
            this.cbb2Vowel.Size = new System.Drawing.Size(500, 28);
            this.cbb2Vowel.Sorted = true;
            this.cbb2Vowel.TabIndex = 6;
            this.cbb2Vowel.Visible = false;
            // 
            // cbbTitular
            // 
            this.cbbTitular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbTitular.ForeColor = System.Drawing.Color.White;
            this.cbbTitular.FormattingEnabled = true;
            this.cbbTitular.IntegralHeight = false;
            this.cbbTitular.Location = new System.Drawing.Point(95, 175);
            this.cbbTitular.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTitular.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbbTitular.Name = "cbbTitular";
            this.cbbTitular.Size = new System.Drawing.Size(366, 28);
            this.cbbTitular.Sorted = true;
            this.cbbTitular.TabIndex = 5;
            this.cbbTitular.Visible = false;
            // 
            // cbbSubject
            // 
            this.cbbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbSubject.ForeColor = System.Drawing.Color.White;
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(95, 108);
            this.cbbSubject.Margin = new System.Windows.Forms.Padding(5);
            this.cbbSubject.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(556, 28);
            this.cbbSubject.Sorted = true;
            this.cbbSubject.TabIndex = 2;
            this.cbbSubject.Visible = false;
            this.cbbSubject.SelectedValueChanged += new System.EventHandler(this.cbbSubject_SelectedValueChanged);
            // 
            // cbbCarrer
            // 
            this.cbbCarrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCarrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbCarrer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCarrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCarrer.ForeColor = System.Drawing.Color.White;
            this.cbbCarrer.FormattingEnabled = true;
            this.cbbCarrer.Location = new System.Drawing.Point(95, 41);
            this.cbbCarrer.Margin = new System.Windows.Forms.Padding(5);
            this.cbbCarrer.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbbCarrer.Name = "cbbCarrer";
            this.cbbCarrer.Size = new System.Drawing.Size(556, 28);
            this.cbbCarrer.Sorted = true;
            this.cbbCarrer.TabIndex = 1;
            this.cbbCarrer.Visible = false;
            this.cbbCarrer.SelectedValueChanged += new System.EventHandler(this.cbbCarrer_SelectedValueChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblError.Image = global::GestIn.Properties.Resources.Error;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(449, 8);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(140, 23);
            this.lblError.TabIndex = 55;
            this.lblError.Text = "          --Error--";
            this.lblError.Visible = false;
            // 
            // btnNewExam
            // 
            this.btnNewExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnNewExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewExam.ForeColor = System.Drawing.Color.White;
            this.btnNewExam.Location = new System.Drawing.Point(25, 5);
            this.btnNewExam.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewExam.Name = "btnNewExam";
            this.btnNewExam.Size = new System.Drawing.Size(165, 35);
            this.btnNewExam.TabIndex = 25;
            this.btnNewExam.Text = "Nuevo";
            this.btnNewExam.UseVisualStyleBackColor = false;
            this.btnNewExam.Click += new System.EventHandler(this.btnNewExam_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.lblMode);
            this.panel1.Controls.Add(this.btnNewExam);
            this.panel1.Controls.Add(this.btnDeleteExam);
            this.panel1.Controls.Add(this.btnUpdateExam);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 43);
            this.panel1.TabIndex = 26;
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(1309, 3);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(5);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(50, 35);
            this.btnOptions.TabIndex = 27;
            this.btnOptions.Text = "+";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(926, 4);
            this.lblMode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(115, 29);
            this.lblMode.TabIndex = 26;
            this.lblMode.Text = "--Mode--";
            this.lblMode.Visible = false;
            // 
            // panelOptions
            // 
            this.panelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOptions.Controls.Add(this.btnGenerateActaVolante);
            this.panelOptions.Controls.Add(this.btnGenerateExams);
            this.panelOptions.Location = new System.Drawing.Point(1109, 248);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Padding = new System.Windows.Forms.Padding(5);
            this.panelOptions.Size = new System.Drawing.Size(250, 125);
            this.panelOptions.TabIndex = 28;
            this.panelOptions.Visible = false;
            // 
            // btnGenerateActaVolante
            // 
            this.btnGenerateActaVolante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnGenerateActaVolante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateActaVolante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateActaVolante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateActaVolante.ForeColor = System.Drawing.Color.White;
            this.btnGenerateActaVolante.Location = new System.Drawing.Point(5, 40);
            this.btnGenerateActaVolante.Margin = new System.Windows.Forms.Padding(5, 13, 5, 5);
            this.btnGenerateActaVolante.Name = "btnGenerateActaVolante";
            this.btnGenerateActaVolante.Size = new System.Drawing.Size(240, 35);
            this.btnGenerateActaVolante.TabIndex = 24;
            this.btnGenerateActaVolante.Text = "Generar acta volante";
            this.btnGenerateActaVolante.UseVisualStyleBackColor = false;
            this.btnGenerateActaVolante.Click += new System.EventHandler(this.btnGenerateActaVolante_Click);
            // 
            // btnGenerateExams
            // 
            this.btnGenerateExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnGenerateExams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateExams.ForeColor = System.Drawing.Color.White;
            this.btnGenerateExams.Location = new System.Drawing.Point(5, 5);
            this.btnGenerateExams.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerateExams.Name = "btnGenerateExams";
            this.btnGenerateExams.Size = new System.Drawing.Size(240, 35);
            this.btnGenerateExams.TabIndex = 23;
            this.btnGenerateExams.Text = "Generar multiples examenes";
            this.btnGenerateExams.UseVisualStyleBackColor = false;
            this.btnGenerateExams.Click += new System.EventHandler(this.btnGenerateExams_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.dtSearchDate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSearchExam);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtSearchCode);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.toggDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 57);
            this.panel2.TabIndex = 29;
            // 
            // dtSearchDate
            // 
            this.dtSearchDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtSearchDate.Enabled = false;
            this.dtSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSearchDate.Location = new System.Drawing.Point(984, 9);
            this.dtSearchDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtSearchDate.Name = "dtSearchDate";
            this.dtSearchDate.Size = new System.Drawing.Size(158, 27);
            this.dtSearchDate.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(911, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Fecha:";
            // 
            // btnSearchExam
            // 
            this.btnSearchExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSearchExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchExam.ForeColor = System.Drawing.Color.White;
            this.btnSearchExam.Location = new System.Drawing.Point(1194, 5);
            this.btnSearchExam.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchExam.Name = "btnSearchExam";
            this.btnSearchExam.Size = new System.Drawing.Size(165, 31);
            this.btnSearchExam.TabIndex = 23;
            this.btnSearchExam.Text = "Buscar";
            this.btnSearchExam.UseVisualStyleBackColor = false;
            this.btnSearchExam.Click += new System.EventHandler(this.btnSearchExam_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(455, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cualquier fecha";
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtSearchCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchCode.ForeColor = System.Drawing.Color.White;
            this.txtSearchCode.Location = new System.Drawing.Point(752, 9);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(150, 27);
            this.txtSearchCode.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(676, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Codigo:";
            // 
            // toggDate
            // 
            this.toggDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggDate.AutoSize = true;
            this.toggDate.Checked = true;
            this.toggDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggDate.Location = new System.Drawing.Point(602, 9);
            this.toggDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toggDate.MinimumSize = new System.Drawing.Size(51, 29);
            this.toggDate.Name = "toggDate";
            this.toggDate.OffBackColor = System.Drawing.Color.Gray;
            this.toggDate.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggDate.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggDate.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggDate.Size = new System.Drawing.Size(51, 29);
            this.toggDate.TabIndex = 0;
            this.toggDate.UseVisualStyleBackColor = true;
            this.toggDate.CheckedChanged += new System.EventHandler(this.toggDate_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.panelOptions);
            this.panel3.Controls.Add(this.dgvExams);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1371, 379);
            this.panel3.TabIndex = 30;
            // 
<<<<<<< HEAD
            // id
            // 
            this.id.FillWeight = 8F;
            this.id.HeaderText = "Código";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // carrer
            // 
            this.carrer.FillWeight = 67.15193F;
            this.carrer.HeaderText = "Carrera";
            this.carrer.MinimumWidth = 6;
            this.carrer.Name = "carrer";
            this.carrer.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.FillWeight = 67.15193F;
            this.subject.HeaderText = "Materia";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // date
            // 
            this.date.FillWeight = 20.14558F;
            this.date.HeaderText = "Fecha";
            this.date.MinimumWidth = 10;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // enrollments
            // 
            this.enrollments.FillWeight = 3.357596F;
            this.enrollments.HeaderText = "Inscriptos";
            this.enrollments.MinimumWidth = 100;
            this.enrollments.Name = "enrollments";
            this.enrollments.ReadOnly = true;
            // 
            // SubjectId
            // 
            this.SubjectId.FillWeight = 1F;
            this.SubjectId.HeaderText = "SubectId";
            this.SubjectId.MinimumWidth = 6;
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            this.SubjectId.Visible = false;
            // 
            // CareerId
            // 
            this.CareerId.FillWeight = 1F;
            this.CareerId.HeaderText = "CarrerId";
            this.CareerId.MinimumWidth = 6;
            this.CareerId.Name = "CareerId";
            this.CareerId.ReadOnly = true;
            this.CareerId.Visible = false;
=======
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 56;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
>>>>>>> 6631b5b6d17632583f5edda7d0760b64a44a9f2c
            // 
            // FormExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1381, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbNewExam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormExams";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Exámenes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.gbNewExam.ResumeLayout(false);
            this.gbNewExam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Label lblCarrer;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTenured;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnUpdateExam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbNewExam;
        private System.Windows.Forms.Button btnNewExam;
        private Panel panel1;
        private ComboBox cbb3Vowel;
        private ComboBox cbb1Vowel;
        private ComboBox cbb2Vowel;
        private ComboBox cbbTitular;
        private ComboBox cbbSubject;
        private ComboBox cbbCarrer;
        private DateTimePicker dtTime;
        private Label label2;
        private TextBox txtPlace;
        private Label lblError;
        private Label lblMode;
        private Button btnCancel;
        private Label lblShowThird;
        private Label lblShowFirst;
        private Label lblShowPlace;
        private Label lblShowSec;
        private Label lblShowTit;
        private Label lblShowTime;
        private Label lblShowDate;
        private Label lblShowSubject;
        private Label lblShowCareer;
        private Button btnSaveUpdate;
        private Label lblExamCode;
        private Label label6;
        private Button btnOptions;
        private Panel panelOptions;
        private Button btnGenerateExams;
        private Panel panel2;
        private Panel panel3;
        private controls.ToggleButton toggDate;
        private DateTimePicker dtSearchDate;
        private Label label9;
        private Button btnSearchExam;
        private Label label8;
        private TextBox txtSearchCode;
        private Label label7;
        private Button btnGenerateActaVolante;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn carrer;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn enrollments;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn CareerId;
        private Button button1;
    }
}