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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTenured = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdateExam = new System.Windows.Forms.Button();
            this.gbNewExam = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.dgvExams.Size = new System.Drawing.Size(1535, 761);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Cyan;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Lime;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(467, 127);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Horario:";
            // 
            // lblTenured
            // 
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
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1156, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "1er vocal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(763, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "2do vocal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1156, 82);
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1388, 128);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 35);
            this.button3.TabIndex = 20;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
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
            this.gbNewExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.gbNewExam.Controls.Add(this.dateTimePicker2);
            this.gbNewExam.Controls.Add(this.comboBox5);
            this.gbNewExam.Controls.Add(this.comboBox4);
            this.gbNewExam.Controls.Add(this.comboBox3);
            this.gbNewExam.Controls.Add(this.comboBox2);
            this.gbNewExam.Controls.Add(this.comboBox1);
            this.gbNewExam.Controls.Add(this.cbbCarrer);
            this.gbNewExam.Controls.Add(this.lblCarrer);
            this.gbNewExam.Controls.Add(this.button3);
            this.gbNewExam.Controls.Add(this.lblSubject);
            this.gbNewExam.Controls.Add(this.label1);
            this.gbNewExam.Controls.Add(this.label5);
            this.gbNewExam.Controls.Add(this.dateTimePicker1);
            this.gbNewExam.Controls.Add(this.lblTime);
            this.gbNewExam.Controls.Add(this.label4);
            this.gbNewExam.Controls.Add(this.label3);
            this.gbNewExam.Controls.Add(this.lblTenured);
            this.gbNewExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbNewExam.Enabled = false;
            this.gbNewExam.ForeColor = System.Drawing.Color.White;
            this.gbNewExam.Location = new System.Drawing.Point(5, 809);
            this.gbNewExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNewExam.Name = "gbNewExam";
            this.gbNewExam.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNewExam.Size = new System.Drawing.Size(1535, 172);
            this.gbNewExam.TabIndex = 23;
            this.gbNewExam.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(544, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 27);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox5.ForeColor = System.Drawing.Color.White;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(1236, 77);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox5.MinimumSize = new System.Drawing.Size(171, 0);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(285, 28);
            this.comboBox5.Sorted = true;
            this.comboBox5.TabIndex = 26;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox4.ForeColor = System.Drawing.Color.White;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(1236, 35);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox4.MinimumSize = new System.Drawing.Size(171, 0);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(285, 28);
            this.comboBox4.Sorted = true;
            this.comboBox4.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(847, 77);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox3.MinimumSize = new System.Drawing.Size(171, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(285, 28);
            this.comboBox3.Sorted = true;
            this.comboBox3.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(847, 39);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox2.MinimumSize = new System.Drawing.Size(171, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(285, 28);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.MinimumSize = new System.Drawing.Size(171, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(659, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 22;
            // 
            // cbbCarrer
            // 
            this.cbbCarrer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCarrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbCarrer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCarrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCarrer.ForeColor = System.Drawing.Color.White;
            this.cbbCarrer.FormattingEnabled = true;
            this.cbbCarrer.Location = new System.Drawing.Point(92, 30);
            this.cbbCarrer.Margin = new System.Windows.Forms.Padding(5);
            this.cbbCarrer.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbbCarrer.Name = "cbbCarrer";
            this.cbbCarrer.Size = new System.Drawing.Size(659, 28);
            this.cbbCarrer.Sorted = true;
            this.cbbCarrer.TabIndex = 21;
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
            this.panel1.Location = new System.Drawing.Point(5, 766);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTenured;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnUpdateExam;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollments;
        private System.Windows.Forms.GroupBox gbNewExam;
        private System.Windows.Forms.Button btnNewExam;
        private Panel panel1;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox cbbCarrer;
        private DateTimePicker dateTimePicker2;
    }
}