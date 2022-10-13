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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCarrer = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTenured = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdateExam = new System.Windows.Forms.Button();
            this.gbNewExam = new System.Windows.Forms.GroupBox();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(652, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // lblCarrer
            // 
            this.lblCarrer.AutoSize = true;
            this.lblCarrer.Location = new System.Drawing.Point(25, 35);
            this.lblCarrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrer.Name = "lblCarrer";
            this.lblCarrer.Size = new System.Drawing.Size(57, 20);
            this.lblCarrer.TabIndex = 2;
            this.lblCarrer.Text = "Carrera";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(20, 82);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(63, 20);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Materia:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(88, 75);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(652, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(388, 127);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Horario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 123);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 27);
            this.textBox1.TabIndex = 8;
            // 
            // lblTenured
            // 
            this.lblTenured.AutoSize = true;
            this.lblTenured.Location = new System.Drawing.Point(787, 40);
            this.lblTenured.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenured.Name = "lblTenured";
            this.lblTenured.Size = new System.Drawing.Size(54, 20);
            this.lblTenured.TabIndex = 11;
            this.lblTenured.Text = "Titular:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(847, 35);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(285, 28);
            this.comboBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1156, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "1er vocal:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(1236, 35);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(285, 28);
            this.comboBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "2do vocal:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(847, 77);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(285, 28);
            this.comboBox5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1156, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "3er vocal:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(1236, 77);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(285, 28);
            this.comboBox6.TabIndex = 16;
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Location = new System.Drawing.Point(372, 5);
            this.btnDeleteExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(165, 35);
            this.btnDeleteExam.TabIndex = 20;
            this.btnDeleteExam.Text = "Eliminar";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1388, 128);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 35);
            this.button3.TabIndex = 20;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUpdateExam
            // 
            this.btnUpdateExam.Location = new System.Drawing.Point(198, 5);
            this.btnUpdateExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateExam.Name = "btnUpdateExam";
            this.btnUpdateExam.Size = new System.Drawing.Size(165, 35);
            this.btnUpdateExam.TabIndex = 22;
            this.btnUpdateExam.Text = "Modificar";
            this.btnUpdateExam.UseVisualStyleBackColor = true;
            // 
            // gbNewExam
            // 
            this.gbNewExam.Controls.Add(this.comboBox1);
            this.gbNewExam.Controls.Add(this.lblCarrer);
            this.gbNewExam.Controls.Add(this.button3);
            this.gbNewExam.Controls.Add(this.comboBox2);
            this.gbNewExam.Controls.Add(this.lblSubject);
            this.gbNewExam.Controls.Add(this.label1);
            this.gbNewExam.Controls.Add(this.label5);
            this.gbNewExam.Controls.Add(this.dateTimePicker1);
            this.gbNewExam.Controls.Add(this.comboBox6);
            this.gbNewExam.Controls.Add(this.lblTime);
            this.gbNewExam.Controls.Add(this.label4);
            this.gbNewExam.Controls.Add(this.textBox1);
            this.gbNewExam.Controls.Add(this.comboBox5);
            this.gbNewExam.Controls.Add(this.comboBox3);
            this.gbNewExam.Controls.Add(this.label3);
            this.gbNewExam.Controls.Add(this.lblTenured);
            this.gbNewExam.Controls.Add(this.comboBox4);
            this.gbNewExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbNewExam.Enabled = false;
            this.gbNewExam.Location = new System.Drawing.Point(5, 809);
            this.gbNewExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNewExam.Name = "gbNewExam";
            this.gbNewExam.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNewExam.Size = new System.Drawing.Size(1535, 172);
            this.gbNewExam.TabIndex = 23;
            this.gbNewExam.TabStop = false;
            // 
            // btnNewExam
            // 
            this.btnNewExam.Location = new System.Drawing.Point(25, 5);
            this.btnNewExam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewExam.Name = "btnNewExam";
            this.btnNewExam.Size = new System.Drawing.Size(165, 35);
            this.btnNewExam.TabIndex = 25;
            this.btnNewExam.Text = "Nuevo";
            this.btnNewExam.UseVisualStyleBackColor = true;
            this.btnNewExam.Click += new System.EventHandler(this.btnNewExam_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCarrer;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTenured;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox6;
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
    }
}