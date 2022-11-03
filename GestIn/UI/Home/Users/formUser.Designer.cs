namespace GestIn.UI.Home.Users
{
    partial class formUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCUILL = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.Label();
            this.bindingSourceTeachers = new System.Windows.Forms.BindingSource(this.components);
            this.teacherPanel = new System.Windows.Forms.Panel();
            this.UserDateBirth = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUserBirthPlace = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUserEmergencyContact = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUserGender = new System.Windows.Forms.TextBox();
            this.bindingSourceStudents = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListBoxUserType = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.cbPhotos = new System.Windows.Forms.CheckBox();
            this.cbCuil = new System.Windows.Forms.CheckBox();
            this.cbBirthCert = new System.Windows.Forms.CheckBox();
            this.cbDni = new System.Windows.Forms.CheckBox();
            this.cbMedicCerf = new System.Windows.Forms.CheckBox();
            this.cbAnalitic = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.lblTeacherCount = new System.Windows.Forms.Label();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).BeginInit();
            this.teacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStudents)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(731, 685);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Guardar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(840, 685);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(88, 109);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(150, 27);
            this.txtTitle.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(953, 685);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Baja";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCUILL
            // 
            this.txtCUILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtCUILL.ForeColor = System.Drawing.Color.White;
            this.txtCUILL.Location = new System.Drawing.Point(88, 42);
            this.txtCUILL.Name = "txtCUILL";
            this.txtCUILL.Size = new System.Drawing.Size(150, 27);
            this.txtCUILL.TabIndex = 18;
            // 
            // txtDNI
            // 
            this.txtDNI.AutoSize = true;
            this.txtDNI.Location = new System.Drawing.Point(7, 49);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(34, 20);
            this.txtDNI.TabIndex = 19;
            this.txtDNI.Text = "Cuil";
            // 
            // teacherPanel
            // 
            this.teacherPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teacherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.teacherPanel.Controls.Add(this.txtCUILL);
            this.teacherPanel.Controls.Add(this.txtDNI);
            this.teacherPanel.Controls.Add(this.txtTitle);
            this.teacherPanel.Controls.Add(this.label2);
            this.teacherPanel.Location = new System.Drawing.Point(344, 312);
            this.teacherPanel.Name = "teacherPanel";
            this.teacherPanel.Size = new System.Drawing.Size(260, 189);
            this.teacherPanel.TabIndex = 35;
            // 
            // UserDateBirth
            // 
            this.UserDateBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.UserDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UserDateBirth.Location = new System.Drawing.Point(3, 333);
            this.UserDateBirth.Name = "UserDateBirth";
            this.UserDateBirth.Size = new System.Drawing.Size(252, 27);
            this.UserDateBirth.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 376);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Lugar de nacimiento :";
            // 
            // txtUserBirthPlace
            // 
            this.txtUserBirthPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtUserBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserBirthPlace.ForeColor = System.Drawing.Color.White;
            this.txtUserBirthPlace.Location = new System.Drawing.Point(3, 396);
            this.txtUserBirthPlace.Name = "txtUserBirthPlace";
            this.txtUserBirthPlace.Size = new System.Drawing.Size(253, 29);
            this.txtUserBirthPlace.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(3, 441);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "Teléfono  de emergencia :";
            // 
            // txtUserEmergencyContact
            // 
            this.txtUserEmergencyContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtUserEmergencyContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserEmergencyContact.ForeColor = System.Drawing.Color.White;
            this.txtUserEmergencyContact.Location = new System.Drawing.Point(3, 461);
            this.txtUserEmergencyContact.Name = "txtUserEmergencyContact";
            this.txtUserEmergencyContact.Size = new System.Drawing.Size(252, 29);
            this.txtUserEmergencyContact.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(3, 506);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "Género :";
            // 
            // txtUserGender
            // 
            this.txtUserGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtUserGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserGender.ForeColor = System.Drawing.Color.White;
            this.txtUserGender.Location = new System.Drawing.Point(3, 526);
            this.txtUserGender.Name = "txtUserGender";
            this.txtUserGender.Size = new System.Drawing.Size(252, 29);
            this.txtUserGender.TabIndex = 41;
            // 
            // checkedListBoxUserType
            // 
            this.checkedListBoxUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.checkedListBoxUserType.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxUserType.FormattingEnabled = true;
            this.checkedListBoxUserType.Items.AddRange(new object[] {
            "Estudiante",
            "Docente"});
            this.checkedListBoxUserType.Location = new System.Drawing.Point(38, 76);
            this.checkedListBoxUserType.Name = "checkedListBoxUserType";
            this.checkedListBoxUserType.Size = new System.Drawing.Size(253, 48);
            this.checkedListBoxUserType.TabIndex = 39;
            this.checkedListBoxUserType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxUserType_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tipo de Usuario";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label15);
            this.flowLayoutPanel1.Controls.Add(this.txtUserLastName);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtUserName);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.txtUserDni);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.txtUserPhoneNumber);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.txtUserEmail);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.UserDateBirth);
            this.flowLayoutPanel1.Controls.Add(this.label16);
            this.flowLayoutPanel1.Controls.Add(this.txtUserBirthPlace);
            this.flowLayoutPanel1.Controls.Add(this.label17);
            this.flowLayoutPanel1.Controls.Add(this.txtUserEmergencyContact);
            this.flowLayoutPanel1.Controls.Add(this.label18);
            this.flowLayoutPanel1.Controls.Add(this.txtUserGender);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 141);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 588);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 57;
            this.label15.Text = "Apellido :";
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserLastName.ForeColor = System.Drawing.Color.White;
            this.txtUserLastName.Location = new System.Drawing.Point(3, 20);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(253, 29);
            this.txtUserLastName.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre :";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(3, 72);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(253, 29);
            this.txtUserName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dni :";
            // 
            // txtUserDni
            // 
            this.txtUserDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtUserDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserDni.ForeColor = System.Drawing.Color.White;
            this.txtUserDni.Location = new System.Drawing.Point(3, 137);
            this.txtUserDni.Name = "txtUserDni";
            this.txtUserDni.Size = new System.Drawing.Size(253, 29);
            this.txtUserDni.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Teléfono :";
            // 
            // txtUserPhoneNumber
            // 
            this.txtUserPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtUserPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtUserPhoneNumber.Location = new System.Drawing.Point(3, 202);
            this.txtUserPhoneNumber.Name = "txtUserPhoneNumber";
            this.txtUserPhoneNumber.Size = new System.Drawing.Size(252, 29);
            this.txtUserPhoneNumber.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Correo electrónico";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserEmail.ForeColor = System.Drawing.Color.White;
            this.txtUserEmail.Location = new System.Drawing.Point(3, 267);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(252, 29);
            this.txtUserEmail.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 312);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Fecha de nacimiento :";
            // 
            // studentPanel
            // 
            this.studentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.studentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.studentPanel.Controls.Add(this.cbPhotos);
            this.studentPanel.Controls.Add(this.cbCuil);
            this.studentPanel.Controls.Add(this.cbBirthCert);
            this.studentPanel.Controls.Add(this.cbDni);
            this.studentPanel.Controls.Add(this.cbMedicCerf);
            this.studentPanel.Controls.Add(this.cbAnalitic);
            this.studentPanel.Location = new System.Drawing.Point(341, 540);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(263, 189);
            this.studentPanel.TabIndex = 44;
            // 
            // cbPhotos
            // 
            this.cbPhotos.AutoCheck = false;
            this.cbPhotos.AutoSize = true;
            this.cbPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPhotos.ForeColor = System.Drawing.Color.White;
            this.cbPhotos.Location = new System.Drawing.Point(17, 132);
            this.cbPhotos.Name = "cbPhotos";
            this.cbPhotos.Size = new System.Drawing.Size(65, 21);
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
            this.cbCuil.Location = new System.Drawing.Point(17, 159);
            this.cbCuil.Name = "cbCuil";
            this.cbCuil.Size = new System.Drawing.Size(60, 21);
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
            this.cbBirthCert.Location = new System.Drawing.Point(17, 72);
            this.cbBirthCert.Name = "cbBirthCert";
            this.cbBirthCert.Size = new System.Drawing.Size(189, 21);
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
            this.cbDni.Location = new System.Drawing.Point(17, 43);
            this.cbDni.Name = "cbDni";
            this.cbDni.Size = new System.Drawing.Size(53, 21);
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
            this.cbMedicCerf.Location = new System.Drawing.Point(17, 101);
            this.cbMedicCerf.Name = "cbMedicCerf";
            this.cbMedicCerf.Size = new System.Drawing.Size(160, 21);
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
            this.cbAnalitic.Location = new System.Drawing.Point(17, 12);
            this.cbAnalitic.Name = "cbAnalitic";
            this.cbAnalitic.Size = new System.Drawing.Size(157, 21);
            this.cbAnalitic.TabIndex = 0;
            this.cbAnalitic.Text = "Analitico secundario";
            this.cbAnalitic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(369, -70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 43;
            this.label3.Text = "Documentación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Usuarios Totales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Estudiantes Totales:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(783, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Docentes Totales:";
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lblStudentCount.ForeColor = System.Drawing.Color.White;
            this.lblStudentCount.Location = new System.Drawing.Point(977, 555);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(13, 20);
            this.lblStudentCount.TabIndex = 48;
            this.lblStudentCount.Text = " ";
            // 
            // lblTeacherCount
            // 
            this.lblTeacherCount.AutoSize = true;
            this.lblTeacherCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lblTeacherCount.Location = new System.Drawing.Point(977, 588);
            this.lblTeacherCount.Name = "lblTeacherCount";
            this.lblTeacherCount.Size = new System.Drawing.Size(13, 20);
            this.lblTeacherCount.TabIndex = 49;
            this.lblTeacherCount.Text = " ";
            // 
            // lblUserCount
            // 
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lblUserCount.ForeColor = System.Drawing.Color.White;
            this.lblUserCount.Location = new System.Drawing.Point(977, 621);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(13, 20);
            this.lblUserCount.TabIndex = 50;
            this.lblUserCount.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Seleccione tipo de usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(534, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Tipo de usuario seleccionado:";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(591, 85);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(13, 20);
            this.lblUserType.TabIndex = 53;
            this.lblUserType.Text = " ";
            // 
            // formUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1093, 909);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblUserCount);
            this.Controls.Add(this.lblTeacherCount);
            this.Controls.Add(this.lblStudentCount);
            this.Controls.Add(this.teacherPanel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxUserType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "formUser";
            this.Text = "formUser";
            this.Load += new System.EventHandler(this.formTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).EndInit();
            this.teacherPanel.ResumeLayout(false);
            this.teacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStudents)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button btnInsert;
        private Button btnUpdate;
        private TextBox txtTitle;
        private Button btnDelete;
        private TextBox txtCUILL;
        private Label txtDNI;
        private BindingSource bindingSourceTeachers;
        private Panel teacherPanel;
        private BindingSource bindingSourceStudents;
        private BindingSource userBindingSource;
        private DateTimePicker UserDateBirth;
        private Label label16;
        private TextBox txtUserBirthPlace;
        private Label label17;
        private TextBox txtUserEmergencyContact;
        private Label label18;
        private TextBox txtUserGender;
        private CheckedListBox checkedListBoxUserType;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private TextBox txtUserName;
        private Label label7;
        private TextBox txtUserDni;
        private Label label8;
        private TextBox txtUserPhoneNumber;
        private Label label9;
        private TextBox txtUserEmail;
        private Label label10;
        private Panel studentPanel;
        private CheckBox cbPhotos;
        private CheckBox cbCuil;
        private CheckBox cbBirthCert;
        private CheckBox cbDni;
        private CheckBox cbMedicCerf;
        private CheckBox cbAnalitic;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label11;
        private Label lblStudentCount;
        private Label lblTeacherCount;
        private Label lblUserCount;
        private Label label12;
        private Label label13;
        private Label lblUserType;
        private Label label15;
        private TextBox txtUserLastName;
    }
}