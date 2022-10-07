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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSubjectsRecord = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearInCarrer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolmentAprovalYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcreditationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbCarrer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCarrerResolution = new System.Windows.Forms.Label();
            this.btnEmitRegularStudentCertificate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelStudentInfoRead = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudentDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectsRecord)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLeftMenu.SuspendLayout();
            this.panelStudentInfoRead.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.dgvSubjectsRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjectsRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvSubjectsRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubjectsRecord.EnableHeadersVisualStyles = false;
            this.dgvSubjectsRecord.GridColor = System.Drawing.Color.White;
            this.dgvSubjectsRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvSubjectsRecord.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSubjectsRecord.Name = "dgvSubjectsRecord";
            this.dgvSubjectsRecord.RowHeadersWidth = 51;
            this.dgvSubjectsRecord.RowTemplate.Height = 24;
            this.dgvSubjectsRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjectsRecord.Size = new System.Drawing.Size(1043, 648);
            this.dgvSubjectsRecord.TabIndex = 0;
            this.dgvSubjectsRecord.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjectsRecord_CellContentDoubleClick);
            // 
            // id
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.NullValue = "Sin cursar";
            this.enrolmentAprovalYear.DefaultCellStyle = dataGridViewCellStyle3;
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
            // cbbCarrer
            // 
            this.cbbCarrer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCarrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbCarrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCarrer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCarrer.ForeColor = System.Drawing.Color.White;
            this.cbbCarrer.FormattingEnabled = true;
            this.cbbCarrer.Location = new System.Drawing.Point(0, 10);
            this.cbbCarrer.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCarrer.MinimumSize = new System.Drawing.Size(150, 0);
            this.cbbCarrer.Name = "cbbCarrer";
            this.cbbCarrer.Size = new System.Drawing.Size(568, 25);
            this.cbbCarrer.Sorted = true;
            this.cbbCarrer.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(960, -199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nº Resolución :";
            // 
            // lblCarrerResolution
            // 
            this.lblCarrerResolution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarrerResolution.AutoSize = true;
            this.lblCarrerResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrerResolution.ForeColor = System.Drawing.Color.White;
            this.lblCarrerResolution.Location = new System.Drawing.Point(960, -222);
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnEmitRegularStudentCertificate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
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
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(12, 11);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(228, 26);
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
            this.lblPersonalData.Location = new System.Drawing.Point(56, 13);
            this.lblPersonalData.Name = "lblPersonalData";
            this.lblPersonalData.Size = new System.Drawing.Size(136, 22);
            this.lblPersonalData.TabIndex = 27;
            this.lblPersonalData.Text = "Datos personales";
            this.lblPersonalData.Click += new System.EventHandler(this.lblPersonalData_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Documentación";
            // 
            // lbSearch
            // 
            this.lbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.FormattingEnabled = true;
            this.lbSearch.ItemHeight = 17;
            this.lbSearch.Location = new System.Drawing.Point(12, 38);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(229, 106);
            this.lbSearch.TabIndex = 32;
            this.lbSearch.Visible = false;
            this.lbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSearch_KeyDown);
            this.lbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSearch_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.cbPhotos);
            this.panel1.Controls.Add(this.cbCuil);
            this.panel1.Controls.Add(this.cbBirthCert);
            this.panel1.Controls.Add(this.cbDni);
            this.panel1.Controls.Add(this.cbMedicCerf);
            this.panel1.Controls.Add(this.cbAnalitic);
            this.panel1.Location = new System.Drawing.Point(15, 538);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 142);
            this.panel1.TabIndex = 33;
            // 
            // cbPhotos
            // 
            this.cbPhotos.AutoCheck = false;
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
            this.cbCuil.AutoCheck = false;
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
            this.cbBirthCert.AutoCheck = false;
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
            this.cbDni.AutoCheck = false;
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
            this.cbMedicCerf.AutoCheck = false;
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
            this.cbAnalitic.AutoCheck = false;
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
            // btnCreateStudent
            // 
            this.btnCreateStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnCreateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateStudent.Location = new System.Drawing.Point(110, 10);
            this.btnCreateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(111, 26);
            this.btnCreateStudent.TabIndex = 35;
            this.btnCreateStudent.Text = "Crear estudiante";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelLeftMenu.Controls.Add(this.panelStudentInfoRead);
            this.panelLeftMenu.Controls.Add(this.searchBox);
            this.panelLeftMenu.Controls.Add(this.lbSearch);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(282, 767);
            this.panelLeftMenu.TabIndex = 36;
            // 
            // panelStudentInfoRead
            // 
            this.panelStudentInfoRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelStudentInfoRead.Controls.Add(this.flowLayoutPanel1);
            this.panelStudentInfoRead.Controls.Add(this.panel1);
            this.panelStudentInfoRead.Controls.Add(this.lblPersonalData);
            this.panelStudentInfoRead.Controls.Add(this.label1);
            this.panelStudentInfoRead.Location = new System.Drawing.Point(0, 74);
            this.panelStudentInfoRead.Name = "panelStudentInfoRead";
            this.panelStudentInfoRead.Size = new System.Drawing.Size(255, 693);
            this.panelStudentInfoRead.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtStudent);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.txtStudentDni);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.txtStudentPhoneNumber);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.txtStudentEmail);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.txtBirthDate);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.txtBirthPlace);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.txtEmergencyContact);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.txtGender);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 55);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 457);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Apellido y nombre";
            // 
            // txtStudent
            // 
            this.txtStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudent.ForeColor = System.Drawing.Color.White;
            this.txtStudent.Location = new System.Drawing.Point(3, 15);
            this.txtStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.ReadOnly = true;
            this.txtStudent.Size = new System.Drawing.Size(222, 26);
            this.txtStudent.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dni :";
            // 
            // txtStudentDni
            // 
            this.txtStudentDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtStudentDni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentDni.ForeColor = System.Drawing.Color.White;
            this.txtStudentDni.Location = new System.Drawing.Point(3, 68);
            this.txtStudentDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentDni.Name = "txtStudentDni";
            this.txtStudentDni.ReadOnly = true;
            this.txtStudentDni.Size = new System.Drawing.Size(222, 26);
            this.txtStudentDni.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Teléfono :";
            // 
            // txtStudentPhoneNumber
            // 
            this.txtStudentPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtStudentPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtStudentPhoneNumber.Location = new System.Drawing.Point(3, 121);
            this.txtStudentPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            this.txtStudentPhoneNumber.ReadOnly = true;
            this.txtStudentPhoneNumber.Size = new System.Drawing.Size(221, 26);
            this.txtStudentPhoneNumber.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Correo electrónico";
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtStudentEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentEmail.ForeColor = System.Drawing.Color.White;
            this.txtStudentEmail.Location = new System.Drawing.Point(3, 174);
            this.txtStudentEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.ReadOnly = true;
            this.txtStudentEmail.Size = new System.Drawing.Size(221, 26);
            this.txtStudentEmail.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Fecha de nacimiento :";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtBirthDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthDate.ForeColor = System.Drawing.Color.White;
            this.txtBirthDate.Location = new System.Drawing.Point(3, 229);
            this.txtBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.ReadOnly = true;
            this.txtBirthDate.Size = new System.Drawing.Size(222, 26);
            this.txtBirthDate.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 267);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Lugar de nacimiento :";
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtBirthPlace.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthPlace.ForeColor = System.Drawing.Color.White;
            this.txtBirthPlace.Location = new System.Drawing.Point(3, 282);
            this.txtBirthPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.ReadOnly = true;
            this.txtBirthPlace.Size = new System.Drawing.Size(222, 26);
            this.txtBirthPlace.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 320);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Teléfono  de emergencia :";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtEmergencyContact.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmergencyContact.ForeColor = System.Drawing.Color.White;
            this.txtEmergencyContact.Location = new System.Drawing.Point(3, 335);
            this.txtEmergencyContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.ReadOnly = true;
            this.txtEmergencyContact.Size = new System.Drawing.Size(221, 26);
            this.txtEmergencyContact.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 373);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Género :";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGender.ForeColor = System.Drawing.Color.White;
            this.txtGender.Location = new System.Drawing.Point(3, 388);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(221, 26);
            this.txtGender.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbbCarrer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblCarrerResolution);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(282, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 40);
            this.panel2.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.btnCreateStudent);
            this.panel4.Controls.Add(this.btnAddGrade);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(636, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 40);
            this.panel4.TabIndex = 38;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddGrade.Location = new System.Drawing.Point(4, 11);
            this.btnAddGrade.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(98, 26);
            this.btnAddGrade.TabIndex = 34;
            this.btnAddGrade.Text = "Agregar nota";
            this.btnAddGrade.UseVisualStyleBackColor = false;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(282, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1073, 727);
            this.panel3.TabIndex = 36;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSubjectsRecord, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 648);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 648);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1073, 79);
            this.panel5.TabIndex = 20;
            // 
            // formAcademicRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1355, 767);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeftMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formAcademicRecord";
            this.Text = "Registro académico";
            this.Load += new System.EventHandler(this.FormAcademicRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectsRecord)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLeftMenu.PerformLayout();
            this.panelStudentInfoRead.ResumeLayout(false);
            this.panelStudentInfoRead.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubjectsRecord;
        private System.Windows.Forms.ComboBox cbbCarrer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCarrerResolution;
        private System.Windows.Forms.Button btnEmitRegularStudentCertificate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label lblPersonalData;
        private System.Windows.Forms.Label label1;
        private ListBox lbSearch;
        private Panel panel1;
        private CheckBox cbPhotos;
        private CheckBox cbCuil;
        private CheckBox cbBirthCert;
        private CheckBox cbDni;
        private CheckBox cbMedicCerf;
        private CheckBox cbAnalitic;
        private Button btnCreateStudent;
        private Panel panelLeftMenu;
        private Panel panel2;
        private Panel panel3;
        private Button btnAddGrade;
        private Panel panel4;
        private Panel panelStudentInfoRead;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private TextBox txtStudent;
        private Label label7;
        private TextBox txtStudentDni;
        private Label label8;
        private TextBox txtStudentPhoneNumber;
        private Label label9;
        private TextBox txtStudentEmail;
        private Label label10;
        private TextBox txtBirthDate;
        private Label label11;
        private TextBox txtBirthPlace;
        private Label label12;
        private TextBox txtEmergencyContact;
        private Label label13;
        private TextBox txtGender;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn yearInCarrer;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn enrolmentAprovalYear;
        private DataGridViewTextBoxColumn AcreditationType;
        private DataGridViewTextBoxColumn approvalDate;
        private DataGridViewTextBoxColumn grade;
        private DataGridViewTextBoxColumn bookRecord;
    }
}