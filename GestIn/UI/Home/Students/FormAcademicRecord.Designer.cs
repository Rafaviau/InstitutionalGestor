namespace GestIn.UI.Home.Students
{
    partial class formAcademicRecord
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
            this.dgvSubjectsRecord = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearInCarrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolmentAprovalYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcreditationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.txtStudentDni = new System.Windows.Forms.TextBox();
            this.lblCarrer = new System.Windows.Forms.Label();
            this.cbbCarrer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarrerResolution = new System.Windows.Forms.Label();
            this.btnEmitRegularStudentCertificate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.flpPersonalData = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStudent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtPlaceOfBirth = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lblPersonalData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPhotos = new System.Windows.Forms.CheckBox();
            this.cbCuil = new System.Windows.Forms.CheckBox();
            this.cbBirthCert = new System.Windows.Forms.CheckBox();
            this.cbDni = new System.Windows.Forms.CheckBox();
            this.cbMedicCerf = new System.Windows.Forms.CheckBox();
            this.cbAnalitic = new System.Windows.Forms.CheckBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectsRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flpPersonalData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubjectsRecord
            // 
            this.dgvSubjectsRecord.AllowUserToAddRows = false;
            this.dgvSubjectsRecord.AllowUserToDeleteRows = false;
            this.dgvSubjectsRecord.AllowUserToResizeRows = false;
            this.dgvSubjectsRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjectsRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.dgvSubjectsRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubjectsRecord.ColumnHeadersHeight = 29;
            this.dgvSubjectsRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.yearInCarrer,
            this.subject,
            this.enrolmentAprovalYear,
            this.AcreditationType,
            this.approvalDate,
            this.grade,
            this.bookRecord});
            this.dgvSubjectsRecord.GridColor = System.Drawing.Color.White;
            this.dgvSubjectsRecord.Location = new System.Drawing.Point(248, 59);
            this.dgvSubjectsRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSubjectsRecord.Name = "dgvSubjectsRecord";
            this.dgvSubjectsRecord.RowHeadersWidth = 51;
            this.dgvSubjectsRecord.RowTemplate.Height = 24;
            this.dgvSubjectsRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjectsRecord.Size = new System.Drawing.Size(856, 576);
            this.dgvSubjectsRecord.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Código";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // yearInCarrer
            // 
            this.yearInCarrer.HeaderText = "Año";
            this.yearInCarrer.MinimumWidth = 6;
            this.yearInCarrer.Name = "yearInCarrer";
            this.yearInCarrer.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.HeaderText = "Materia";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // enrolmentAprovalYear
            // 
            dataGridViewCellStyle1.NullValue = "Sin cursar";
            this.enrolmentAprovalYear.DefaultCellStyle = dataGridViewCellStyle1;
            this.enrolmentAprovalYear.HeaderText = "Cursada arpobada en";
            this.enrolmentAprovalYear.MinimumWidth = 6;
            this.enrolmentAprovalYear.Name = "enrolmentAprovalYear";
            this.enrolmentAprovalYear.ReadOnly = true;
            // 
            // AcreditationType
            // 
            this.AcreditationType.HeaderText = "Origen de acreditación";
            this.AcreditationType.MinimumWidth = 6;
            this.AcreditationType.Name = "AcreditationType";
            this.AcreditationType.ReadOnly = true;
            // 
            // approvalDate
            // 
            this.approvalDate.HeaderText = "Fecha de acreditación";
            this.approvalDate.MinimumWidth = 6;
            this.approvalDate.Name = "approvalDate";
            this.approvalDate.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.HeaderText = "Calificación final";
            this.grade.MinimumWidth = 6;
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // bookRecord
            // 
            this.bookRecord.HeaderText = "Nº de acta";
            this.bookRecord.MinimumWidth = 6;
            this.bookRecord.Name = "bookRecord";
            this.bookRecord.ReadOnly = true;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(3, 40);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "Dni :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 80);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(55, 13);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Teléfono :";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(3, 15);
            this.txtStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.ReadOnly = true;
            this.txtStudent.Size = new System.Drawing.Size(288, 23);
            this.txtStudent.TabIndex = 10;
            // 
            // txtStudentDni
            // 
            this.txtStudentDni.Location = new System.Drawing.Point(3, 55);
            this.txtStudentDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentDni.Name = "txtStudentDni";
            this.txtStudentDni.ReadOnly = true;
            this.txtStudentDni.Size = new System.Drawing.Size(288, 23);
            this.txtStudentDni.TabIndex = 11;
            // 
            // lblCarrer
            // 
            this.lblCarrer.AutoSize = true;
            this.lblCarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrer.ForeColor = System.Drawing.Color.White;
            this.lblCarrer.Location = new System.Drawing.Point(634, 9);
            this.lblCarrer.Name = "lblCarrer";
            this.lblCarrer.Size = new System.Drawing.Size(48, 15);
            this.lblCarrer.TabIndex = 13;
            this.lblCarrer.Text = "Carrera";
            // 
            // cbbCarrer
            // 
            this.cbbCarrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCarrer.FormattingEnabled = true;
            this.cbbCarrer.Location = new System.Drawing.Point(634, 30);
            this.cbbCarrer.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCarrer.Name = "cbbCarrer";
            this.cbbCarrer.Size = new System.Drawing.Size(554, 23);
            this.cbbCarrer.Sorted = true;
            this.cbbCarrer.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1245, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nº Resolución :";
            // 
            // lblCarrerResolution
            // 
            this.lblCarrerResolution.AutoSize = true;
            this.lblCarrerResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrerResolution.ForeColor = System.Drawing.Color.White;
            this.lblCarrerResolution.Location = new System.Drawing.Point(1245, 39);
            this.lblCarrerResolution.Name = "lblCarrerResolution";
            this.lblCarrerResolution.Size = new System.Drawing.Size(32, 13);
            this.lblCarrerResolution.TabIndex = 16;
            this.lblCarrerResolution.Text = "Res :";
            // 
            // btnEmitRegularStudentCertificate
            // 
            this.btnEmitRegularStudentCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnEmitRegularStudentCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitRegularStudentCertificate.ForeColor = System.Drawing.Color.Black;
            this.btnEmitRegularStudentCertificate.Location = new System.Drawing.Point(7, 22);
            this.btnEmitRegularStudentCertificate.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmitRegularStudentCertificate.Name = "btnEmitRegularStudentCertificate";
            this.btnEmitRegularStudentCertificate.Size = new System.Drawing.Size(113, 26);
            this.btnEmitRegularStudentCertificate.TabIndex = 17;
            this.btnEmitRegularStudentCertificate.Text = "Alumno regular";
            this.btnEmitRegularStudentCertificate.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(127, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Analìtico";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnEmitRegularStudentCertificate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(312, 650);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(606, 62);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emisión de certificados";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(396, 22);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 26);
            this.button3.TabIndex = 20;
            this.button3.Text = "Asistencia a mesa de examen";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(248, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 26);
            this.button2.TabIndex = 19;
            this.button2.Text = "Asistencia a práctica";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(3, 135);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.ReadOnly = true;
            this.txtStudentEmail.Size = new System.Drawing.Size(287, 23);
            this.txtStudentEmail.TabIndex = 21;
            // 
            // txtStudentPhoneNumber
            // 
            this.txtStudentPhoneNumber.Location = new System.Drawing.Point(3, 95);
            this.txtStudentPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            this.txtStudentPhoneNumber.ReadOnly = true;
            this.txtStudentPhoneNumber.Size = new System.Drawing.Size(287, 23);
            this.txtStudentPhoneNumber.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(3, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Correo electrónico";
            // 
            // flpPersonalData
            // 
            this.flpPersonalData.Controls.Add(this.lblStudent);
            this.flpPersonalData.Controls.Add(this.txtStudent);
            this.flpPersonalData.Controls.Add(this.lblDni);
            this.flpPersonalData.Controls.Add(this.txtStudentDni);
            this.flpPersonalData.Controls.Add(this.lblPhoneNumber);
            this.flpPersonalData.Controls.Add(this.txtStudentPhoneNumber);
            this.flpPersonalData.Controls.Add(this.lblEmail);
            this.flpPersonalData.Controls.Add(this.txtStudentEmail);
            this.flpPersonalData.Controls.Add(this.label3);
            this.flpPersonalData.Controls.Add(this.txtBirthDate);
            this.flpPersonalData.Controls.Add(this.txtPlaceOfBirth);
            this.flpPersonalData.Controls.Add(this.txtBirthPlace);
            this.flpPersonalData.Controls.Add(this.label4);
            this.flpPersonalData.Controls.Add(this.txtEmergencyContact);
            this.flpPersonalData.Controls.Add(this.label5);
            this.flpPersonalData.Controls.Add(this.txtGender);
            this.flpPersonalData.Location = new System.Drawing.Point(11, 152);
            this.flpPersonalData.Margin = new System.Windows.Forms.Padding(4);
            this.flpPersonalData.Name = "flpPersonalData";
            this.flpPersonalData.Size = new System.Drawing.Size(225, 331);
            this.flpPersonalData.TabIndex = 25;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudent.ForeColor = System.Drawing.Color.White;
            this.lblStudent.Location = new System.Drawing.Point(3, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(90, 13);
            this.lblStudent.TabIndex = 26;
            this.lblStudent.Text = "Apellido y nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha de nacimiento :";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(3, 177);
            this.txtBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.ReadOnly = true;
            this.txtBirthDate.Size = new System.Drawing.Size(288, 23);
            this.txtBirthDate.TabIndex = 27;
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.AutoSize = true;
            this.txtPlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlaceOfBirth.ForeColor = System.Drawing.Color.White;
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(3, 202);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(109, 13);
            this.txtPlaceOfBirth.TabIndex = 33;
            this.txtPlaceOfBirth.Text = "Lugar de nacimiento :";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(3, 217);
            this.txtBirthPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.ReadOnly = true;
            this.txtBirthPlace.Size = new System.Drawing.Size(288, 23);
            this.txtBirthPlace.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Teléfono  de emergencia :";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Location = new System.Drawing.Point(3, 257);
            this.txtEmergencyContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.ReadOnly = true;
            this.txtEmergencyContact.Size = new System.Drawing.Size(287, 23);
            this.txtEmergencyContact.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Género :";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(3, 297);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(287, 23);
            this.txtGender.TabIndex = 35;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 30);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(228, 23);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // lblPersonalData
            // 
            this.lblPersonalData.AutoSize = true;
            this.lblPersonalData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lblPersonalData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPersonalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPersonalData.ForeColor = System.Drawing.Color.White;
            this.lblPersonalData.Location = new System.Drawing.Point(14, 118);
            this.lblPersonalData.Name = "lblPersonalData";
            this.lblPersonalData.Size = new System.Drawing.Size(136, 22);
            this.lblPersonalData.TabIndex = 27;
            this.lblPersonalData.Text = "Datos personales";
            this.lblPersonalData.Click += new System.EventHandler(this.lblPersonalData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Documentación";
            // 
            // lbSearch
            // 
            this.lbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.FormattingEnabled = true;
            this.lbSearch.ItemHeight = 17;
            this.lbSearch.Location = new System.Drawing.Point(14, 55);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(224, 106);
            this.lbSearch.TabIndex = 32;
            this.lbSearch.Visible = false;
            this.lbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSearch_KeyDown);
            this.lbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSearch_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.cbPhotos);
            this.panel1.Controls.Add(this.cbCuil);
            this.panel1.Controls.Add(this.cbBirthCert);
            this.panel1.Controls.Add(this.cbDni);
            this.panel1.Controls.Add(this.cbMedicCerf);
            this.panel1.Controls.Add(this.cbAnalitic);
            this.panel1.Location = new System.Drawing.Point(14, 569);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 142);
            this.panel1.TabIndex = 33;
            // 
            // cbPhotos
            // 
            this.cbPhotos.AutoSize = true;
            this.cbPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPhotos.ForeColor = System.Drawing.Color.White;
            this.cbPhotos.Location = new System.Drawing.Point(15, 99);
            this.cbPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPhotos.Name = "cbPhotos";
            this.cbPhotos.Size = new System.Drawing.Size(52, 17);
            this.cbPhotos.TabIndex = 5;
            this.cbPhotos.Text = "Fotos";
            this.cbPhotos.UseVisualStyleBackColor = true;
            // 
            // cbCuil
            // 
            this.cbCuil.AutoSize = true;
            this.cbCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCuil.ForeColor = System.Drawing.Color.White;
            this.cbCuil.Location = new System.Drawing.Point(15, 119);
            this.cbCuil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCuil.Name = "cbCuil";
            this.cbCuil.Size = new System.Drawing.Size(50, 17);
            this.cbCuil.TabIndex = 4;
            this.cbCuil.Text = "CUIL";
            this.cbCuil.UseVisualStyleBackColor = true;
            // 
            // cbBirthCert
            // 
            this.cbBirthCert.AutoSize = true;
            this.cbBirthCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBirthCert.ForeColor = System.Drawing.Color.White;
            this.cbBirthCert.Location = new System.Drawing.Point(15, 54);
            this.cbBirthCert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBirthCert.Name = "cbBirthCert";
            this.cbBirthCert.Size = new System.Drawing.Size(145, 17);
            this.cbBirthCert.TabIndex = 3;
            this.cbBirthCert.Text = "Certificado de nacimiento";
            this.cbBirthCert.UseVisualStyleBackColor = true;
            // 
            // cbDni
            // 
            this.cbDni.AutoSize = true;
            this.cbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDni.ForeColor = System.Drawing.Color.White;
            this.cbDni.Location = new System.Drawing.Point(15, 32);
            this.cbDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDni.Name = "cbDni";
            this.cbDni.Size = new System.Drawing.Size(45, 17);
            this.cbDni.TabIndex = 2;
            this.cbDni.Text = "DNI";
            this.cbDni.UseVisualStyleBackColor = true;
            // 
            // cbMedicCerf
            // 
            this.cbMedicCerf.AutoSize = true;
            this.cbMedicCerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMedicCerf.ForeColor = System.Drawing.Color.White;
            this.cbMedicCerf.Location = new System.Drawing.Point(15, 76);
            this.cbMedicCerf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMedicCerf.Name = "cbMedicCerf";
            this.cbMedicCerf.Size = new System.Drawing.Size(123, 17);
            this.cbMedicCerf.TabIndex = 1;
            this.cbMedicCerf.Text = "Certificados medicos";
            this.cbMedicCerf.UseVisualStyleBackColor = true;
            // 
            // cbAnalitic
            // 
            this.cbAnalitic.AutoSize = true;
            this.cbAnalitic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAnalitic.ForeColor = System.Drawing.Color.White;
            this.cbAnalitic.Location = new System.Drawing.Point(15, 9);
            this.cbAnalitic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAnalitic.Name = "cbAnalitic";
            this.cbAnalitic.Size = new System.Drawing.Size(121, 17);
            this.cbAnalitic.TabIndex = 0;
            this.cbAnalitic.Text = "Analitico secundario";
            this.cbAnalitic.UseVisualStyleBackColor = true;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddGrade.Location = new System.Drawing.Point(312, 27);
            this.btnAddGrade.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(94, 26);
            this.btnAddGrade.TabIndex = 34;
            this.btnAddGrade.Text = "Agregar nota";
            this.btnAddGrade.UseVisualStyleBackColor = false;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnCreateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateStudent.Location = new System.Drawing.Point(414, 27);
            this.btnCreateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(111, 26);
            this.btnCreateStudent.TabIndex = 35;
            this.btnCreateStudent.Text = "Crear estudiante";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // formAcademicRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1194, 562);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPersonalData);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.flpPersonalData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCarrerResolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCarrer);
            this.Controls.Add(this.lblCarrer);
            this.Controls.Add(this.dgvSubjectsRecord);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formAcademicRecord";
            this.Text = "Registro académico";
            this.Load += new System.EventHandler(this.FormAcademicRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectsRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flpPersonalData.ResumeLayout(false);
            this.flpPersonalData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubjectsRecord;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.TextBox txtStudentDni;
        private System.Windows.Forms.Label lblCarrer;
        private System.Windows.Forms.ComboBox cbbCarrer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCarrerResolution;
        private System.Windows.Forms.Button btnEmitRegularStudentCertificate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearInCarrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrolmentAprovalYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcreditationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.FlowLayoutPanel flpPersonalData;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label lblPersonalData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label txtPlaceOfBirth;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGender;
        private ListBox lbSearch;
        private Panel panel1;
        private CheckBox cbPhotos;
        private CheckBox cbCuil;
        private CheckBox cbBirthCert;
        private CheckBox cbDni;
        private CheckBox cbMedicCerf;
        private CheckBox cbAnalitic;
        private Button btnAddGrade;
        private Button btnCreateStudent;
    }
}