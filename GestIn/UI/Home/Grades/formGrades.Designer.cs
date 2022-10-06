namespace GestIn.UI.Home.Grades
{
    partial class formGrades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCareer = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookRecord = new System.Windows.Forms.TextBox();
            this.txtAcreditationDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ccbPresential = new System.Windows.Forms.CheckBox();
            this.txtEntomentYear = new System.Windows.Forms.TextBox();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            this.lblAcreditationType = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.cbCareerEnrol = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCarrearEnrolYear = new System.Windows.Forms.TextBox();
            this.btnSaveEnrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dni del alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carreras";
            // 
            // cbCareer
            // 
            this.cbCareer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCareer.FormattingEnabled = true;
            this.cbCareer.Location = new System.Drawing.Point(401, 46);
            this.cbCareer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCareer.Name = "cbCareer";
            this.cbCareer.Size = new System.Drawing.Size(304, 23);
            this.cbCareer.TabIndex = 2;
            this.cbCareer.SelectedValueChanged += new System.EventHandler(this.cbCareer_SelectedValueChanged);
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(401, 76);
            this.cbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(304, 23);
            this.cbSubject.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(103, 46);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(133, 23);
            this.txtDni.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(581, 150);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(134, 23);
            this.txtGrade.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 261);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Acta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha de acreditacion";
            // 
            // txtBookRecord
            // 
            this.txtBookRecord.Location = new System.Drawing.Point(582, 181);
            this.txtBookRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookRecord.Name = "txtBookRecord";
            this.txtBookRecord.Size = new System.Drawing.Size(133, 23);
            this.txtBookRecord.TabIndex = 7;
            // 
            // txtAcreditationDate
            // 
            this.txtAcreditationDate.Location = new System.Drawing.Point(582, 210);
            this.txtAcreditationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcreditationDate.Name = "txtAcreditationDate";
            this.txtAcreditationDate.PlaceholderText = "DD/MM/AAAA";
            this.txtAcreditationDate.Size = new System.Drawing.Size(133, 23);
            this.txtAcreditationDate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(198, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cargar cursadas y examenes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(501, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Examen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(158, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cursada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Año de acreditacion de cursada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "¿Presencial?";
            // 
            // ccbPresential
            // 
            this.ccbPresential.AutoSize = true;
            this.ccbPresential.Checked = true;
            this.ccbPresential.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ccbPresential.Location = new System.Drawing.Point(188, 190);
            this.ccbPresential.Name = "ccbPresential";
            this.ccbPresential.Size = new System.Drawing.Size(15, 14);
            this.ccbPresential.TabIndex = 5;
            this.ccbPresential.UseVisualStyleBackColor = true;
            // 
            // txtEntomentYear
            // 
            this.txtEntomentYear.Location = new System.Drawing.Point(198, 153);
            this.txtEntomentYear.Name = "txtEntomentYear";
            this.txtEntomentYear.Size = new System.Drawing.Size(100, 23);
            this.txtEntomentYear.TabIndex = 4;
            // 
            // cbAccType
            // 
            this.cbAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Items.AddRange(new object[] {
            "Presencial",
            "Libre",
            "Equivalencia"});
            this.cbAccType.Location = new System.Drawing.Point(582, 235);
            this.cbAccType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(133, 23);
            this.cbAccType.TabIndex = 9;
            this.cbAccType.SelectedIndexChanged += new System.EventHandler(this.cbAccType_SelectedIndexChanged);
            // 
            // lblAcreditationType
            // 
            this.lblAcreditationType.AutoSize = true;
            this.lblAcreditationType.Location = new System.Drawing.Point(443, 237);
            this.lblAcreditationType.Name = "lblAcreditationType";
            this.lblAcreditationType.Size = new System.Drawing.Size(115, 15);
            this.lblAcreditationType.TabIndex = 17;
            this.lblAcreditationType.Text = "Tipo de acreditacion";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(153, 70);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(82, 22);
            this.btnSearchStudent.TabIndex = 18;
            this.btnSearchStudent.Text = "Buscar";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // cbCareerEnrol
            // 
            this.cbCareerEnrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCareerEnrol.FormattingEnabled = true;
            this.cbCareerEnrol.Location = new System.Drawing.Point(727, 46);
            this.cbCareerEnrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCareerEnrol.Name = "cbCareerEnrol";
            this.cbCareerEnrol.Size = new System.Drawing.Size(304, 23);
            this.cbCareerEnrol.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(825, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Inscribir a una carrera";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(727, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "año";
            // 
            // tbCarrearEnrolYear
            // 
            this.tbCarrearEnrolYear.Location = new System.Drawing.Point(772, 76);
            this.tbCarrearEnrolYear.Name = "tbCarrearEnrolYear";
            this.tbCarrearEnrolYear.Size = new System.Drawing.Size(100, 23);
            this.tbCarrearEnrolYear.TabIndex = 22;
            // 
            // btnSaveEnrol
            // 
            this.btnSaveEnrol.Location = new System.Drawing.Point(797, 108);
            this.btnSaveEnrol.Name = "btnSaveEnrol";
            this.btnSaveEnrol.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEnrol.TabIndex = 23;
            this.btnSaveEnrol.Text = "Guardar";
            this.btnSaveEnrol.UseVisualStyleBackColor = true;
            this.btnSaveEnrol.Click += new System.EventHandler(this.btnSaveEnrol_Click);
            // 
            // formGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 303);
            this.Controls.Add(this.btnSaveEnrol);
            this.Controls.Add(this.tbCarrearEnrolYear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbCareerEnrol);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.lblAcreditationType);
            this.Controls.Add(this.cbAccType);
            this.Controls.Add(this.txtEntomentYear);
            this.Controls.Add(this.ccbPresential);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAcreditationDate);
            this.Controls.Add(this.txtBookRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.cbCareer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formGrades";
            this.Text = "formGrades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbCareer;
        private ComboBox cbSubject;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtGrade;
        private Button btnSave;
        private Label label5;
        private Label label6;
        private TextBox txtBookRecord;
        private TextBox txtAcreditationDate;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private CheckBox ccbPresential;
        private TextBox txtEntomentYear;
        private ComboBox cbAccType;
        private Label lblAcreditationType;
        private Button btnSearchStudent;
        private ComboBox cbCareerEnrol;
        private Label label12;
        private Label label13;
        private TextBox tbCarrearEnrolYear;
        private Button btnSaveEnrol;
    }
}