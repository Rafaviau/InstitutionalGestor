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
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollments = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblError = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.cbb3Vowel = new System.Windows.Forms.ComboBox();
            this.cbb1Vowel = new System.Windows.Forms.ComboBox();
            this.cbb2Vowel = new System.Windows.Forms.ComboBox();
            this.cbbTitular = new System.Windows.Forms.ComboBox();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.cbbCarrer = new System.Windows.Forms.ComboBox();
            this.btnNewExam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.gbNewExam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExams
            // 
            this.dgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.carrer,
            this.subject,
            this.date,
            this.enrollments});
            this.dgvExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExams.Location = new System.Drawing.Point(5, 5);
            this.dgvExams.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.ReadOnly = true;
            this.dgvExams.RowHeadersVisible = false;
            this.dgvExams.RowHeadersWidth = 51;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(1535, 723);
            this.dgvExams.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Código";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // carrer
            // 
            this.carrer.HeaderText = "Carrera";
            this.carrer.MinimumWidth = 6;
            this.carrer.Name = "carrer";
            this.carrer.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.HeaderText = "Materia";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Fecha";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // enrollments
            // 
            this.enrollments.HeaderText = "Inscriptos";
            this.enrollments.MinimumWidth = 6;
            this.enrollments.Name = "enrollments";
            this.enrollments.ReadOnly = true;
            // 
            // lblCarrer
            // 
            this.lblCarrer.AutoSize = true;
            this.lblCarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrer.ForeColor = System.Drawing.Color.White;
            this.lblCarrer.Location = new System.Drawing.Point(25, 35);
            this.lblCarrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrer.Name = "lblCarrer";
            this.lblCarrer.Size = new System.Drawing.Size(66, 20);
            this.lblCarrer.TabIndex = 2;
            this.lblCarrer.Text = "Carrera";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.Color.White;
            this.lblSubject.Location = new System.Drawing.Point(20, 82);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(70, 20);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Materia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.CalendarForeColor = System.Drawing.Color.Cyan;
            this.dtDate.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dtDate.CalendarTitleBackColor = System.Drawing.Color.Lime;
            this.dtDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtDate.CalendarTrailingForeColor = System.Drawing.Color.Yellow;
            this.dtDate.Enabled = false;
            this.dtDate.Location = new System.Drawing.Point(88, 141);
            this.dtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(292, 27);
            this.dtDate.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(467, 146);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Horario:";
            // 
            // lblTenured
            // 
            this.lblTenured.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenured.AutoSize = true;
            this.lblTenured.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenured.ForeColor = System.Drawing.Color.White;
            this.lblTenured.Location = new System.Drawing.Point(787, 40);
            this.lblTenured.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenured.Name = "lblTenured";
            this.lblTenured.Size = new System.Drawing.Size(61, 20);
            this.lblTenured.TabIndex = 11;
            this.lblTenured.Text = "Titular:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1156, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "1er vocal:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(763, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "2do vocal:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1156, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "3er vocal:";
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnDeleteExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteExam.ForeColor = System.Drawing.Color.White;
            this.btnDeleteExam.Location = new System.Drawing.Point(372, 5);
            this.btnDeleteExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(165, 35);
            this.btnDeleteExam.TabIndex = 20;
            this.btnDeleteExam.Text = "Eliminar";
            this.btnDeleteExam.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1388, 147);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 35);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdateExam
            // 
            this.btnUpdateExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnUpdateExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateExam.ForeColor = System.Drawing.Color.White;
            this.btnUpdateExam.Location = new System.Drawing.Point(198, 5);
            this.btnUpdateExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateExam.Name = "btnUpdateExam";
            this.btnUpdateExam.Size = new System.Drawing.Size(165, 35);
            this.btnUpdateExam.TabIndex = 22;
            this.btnUpdateExam.Text = "Modificar";
            this.btnUpdateExam.UseVisualStyleBackColor = false;
            // 
            // gbNewExam
            // 
            this.gbNewExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(87)))), ((int)(((byte)(93)))));
            this.gbNewExam.Controls.Add(this.lblError);
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
            this.gbNewExam.Location = new System.Drawing.Point(5, 771);
            this.gbNewExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNewExam.Name = "gbNewExam";
            this.gbNewExam.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNewExam.Size = new System.Drawing.Size(1535, 210);
            this.gbNewExam.TabIndex = 23;
            this.gbNewExam.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblError.Image = global::GestIn.Properties.Resources.Error;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(704, 182);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(140, 23);
            this.lblError.TabIndex = 55;
            this.lblError.Text = "          --Error--";
            this.lblError.Visible = false;
            // 
            // txtPlace
            // 
            this.txtPlace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtPlace.Enabled = false;
            this.txtPlace.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlace.ForeColor = System.Drawing.Color.White;
            this.txtPlace.Location = new System.Drawing.Point(847, 141);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(285, 30);
            this.txtPlace.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(787, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Lugar:";
            // 
            // dtTime
            // 
            this.dtTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtTime.CustomFormat = "HH:mm";
            this.dtTime.Enabled = false;
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(544, 141);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(95, 27);
            this.dtTime.TabIndex = 27;
            // 
            // cbb3Vowel
            // 
            this.cbb3Vowel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbb3Vowel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbb3Vowel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb3Vowel.Enabled = false;
            this.cbb3Vowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb3Vowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb3Vowel.ForeColor = System.Drawing.Color.White;
            this.cbb3Vowel.FormattingEnabled = true;
            this.cbb3Vowel.Location = new System.Drawing.Point(1236, 96);
            this.cbb3Vowel.Margin = new System.Windows.Forms.Padding(5);
            this.cbb3Vowel.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbb3Vowel.Name = "cbb3Vowel";
            this.cbb3Vowel.Size = new System.Drawing.Size(285, 28);
            this.cbb3Vowel.Sorted = true;
            this.cbb3Vowel.TabIndex = 26;
            // 
            // cbb1Vowel
            // 
            this.cbb1Vowel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbb1Vowel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbb1Vowel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb1Vowel.Enabled = false;
            this.cbb1Vowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb1Vowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb1Vowel.ForeColor = System.Drawing.Color.White;
            this.cbb1Vowel.FormattingEnabled = true;
            this.cbb1Vowel.Location = new System.Drawing.Point(1236, 54);
            this.cbb1Vowel.Margin = new System.Windows.Forms.Padding(5);
            this.cbb1Vowel.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbb1Vowel.Name = "cbb1Vowel";
            this.cbb1Vowel.Size = new System.Drawing.Size(285, 28);
            this.cbb1Vowel.Sorted = true;
            this.cbb1Vowel.TabIndex = 25;
            // 
            // cbb2Vowel
            // 
            this.cbb2Vowel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb2Vowel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbb2Vowel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb2Vowel.Enabled = false;
            this.cbb2Vowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb2Vowel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb2Vowel.ForeColor = System.Drawing.Color.White;
            this.cbb2Vowel.FormattingEnabled = true;
            this.cbb2Vowel.Location = new System.Drawing.Point(847, 96);
            this.cbb2Vowel.Margin = new System.Windows.Forms.Padding(5);
            this.cbb2Vowel.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbb2Vowel.Name = "cbb2Vowel";
            this.cbb2Vowel.Size = new System.Drawing.Size(285, 28);
            this.cbb2Vowel.Sorted = true;
            this.cbb2Vowel.TabIndex = 24;
            // 
            // cbbTitular
            // 
            this.cbbTitular.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbTitular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTitular.Enabled = false;
            this.cbbTitular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbTitular.ForeColor = System.Drawing.Color.White;
            this.cbbTitular.FormattingEnabled = true;
            this.cbbTitular.Location = new System.Drawing.Point(847, 58);
            this.cbbTitular.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTitular.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbbTitular.Name = "cbbTitular";
            this.cbbTitular.Size = new System.Drawing.Size(285, 28);
            this.cbbTitular.Sorted = true;
            this.cbbTitular.TabIndex = 23;
            // 
            // cbbSubject
            // 
            this.cbbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.Enabled = false;
            this.cbbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbSubject.ForeColor = System.Drawing.Color.White;
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(92, 97);
            this.cbbSubject.Margin = new System.Windows.Forms.Padding(5);
            this.cbbSubject.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(547, 28);
            this.cbbSubject.Sorted = true;
            this.cbbSubject.TabIndex = 22;
            // 
            // cbbCarrer
            // 
            this.cbbCarrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCarrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbCarrer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCarrer.Enabled = false;
            this.cbbCarrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCarrer.ForeColor = System.Drawing.Color.White;
            this.cbbCarrer.FormattingEnabled = true;
            this.cbbCarrer.Location = new System.Drawing.Point(92, 49);
            this.cbbCarrer.Margin = new System.Windows.Forms.Padding(5);
            this.cbbCarrer.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbbCarrer.Name = "cbbCarrer";
            this.cbbCarrer.Size = new System.Drawing.Size(547, 28);
            this.cbbCarrer.Sorted = true;
            this.cbbCarrer.TabIndex = 21;
            this.cbbCarrer.SelectedValueChanged += new System.EventHandler(this.cbbCarrer_SelectedValueChanged);
            // 
            // btnNewExam
            // 
            this.btnNewExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnNewExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewExam.ForeColor = System.Drawing.Color.White;
            this.btnNewExam.Location = new System.Drawing.Point(25, 5);
            this.btnNewExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.panel1.Controls.Add(this.btnNewExam);
            this.panel1.Controls.Add(this.btnDeleteExam);
            this.panel1.Controls.Add(this.btnUpdateExam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 728);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 43);
            this.panel1.TabIndex = 26;
            // 
            // FormExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1545, 986);
            this.Controls.Add(this.dgvExams);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbNewExam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormExams";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Exámenes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.gbNewExam.ResumeLayout(false);
            this.gbNewExam.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollments;
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
    }
}