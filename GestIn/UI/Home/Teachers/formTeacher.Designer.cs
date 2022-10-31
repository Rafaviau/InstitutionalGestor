namespace GestIn.UI.Home.Teachers
{
    partial class formTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDNII = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPlaceBirth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCUILL = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.Label();
            this.bindingSourceTeachers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(398, 38);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.RowHeadersWidth = 51;
            this.dataGridViewTeachers.RowTemplate.Height = 29;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(712, 447);
            this.dataGridViewTeachers.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(27, 428);
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
            this.btnUpdate.Location = new System.Drawing.Point(135, 428);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDNII
            // 
            this.txtDNII.Location = new System.Drawing.Point(190, 298);
            this.txtDNII.Name = "txtDNII";
            this.txtDNII.Size = new System.Drawing.Size(125, 27);
            this.txtDNII.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(190, 340);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 27);
            this.txtTitle.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(245, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(190, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 27);
            this.txtLastName.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 10;
            // 
            // dateTimePickerDateBirth
            // 
            this.dateTimePickerDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateBirth.Location = new System.Drawing.Point(190, 164);
            this.dateTimePickerDateBirth.Name = "dateTimePickerDateBirth";
            this.dateTimePickerDateBirth.Size = new System.Drawing.Size(125, 27);
            this.dateTimePickerDateBirth.TabIndex = 12;
            // 
            // txtPlaceBirth
            // 
            this.txtPlaceBirth.Location = new System.Drawing.Point(190, 206);
            this.txtPlaceBirth.Name = "txtPlaceBirth";
            this.txtPlaceBirth.Size = new System.Drawing.Size(125, 27);
            this.txtPlaceBirth.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "PlaceOfBirth";
            // 
            // txtCUILL
            // 
            this.txtCUILL.Location = new System.Drawing.Point(190, 250);
            this.txtCUILL.Name = "txtCUILL";
            this.txtCUILL.Size = new System.Drawing.Size(125, 27);
            this.txtCUILL.TabIndex = 18;
            this.txtCUILL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.AutoSize = true;
            this.txtDNI.Location = new System.Drawing.Point(27, 257);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(34, 20);
            this.txtDNI.TabIndex = 19;
            this.txtDNI.Text = "Cuil";
            // 
            // formTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1161, 519);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtCUILL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaceBirth);
            this.Controls.Add(this.dateTimePickerDateBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDNII);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "formTeacher";
            this.Text = "formTeacher";
            this.Load += new System.EventHandler(this.formTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewTeachers;
        private Button btnInsert;
        private Button btnUpdate;
        private TextBox txtDNII;
        private TextBox txtTitle;
        private Button btnDelete;
        private TextBox txtLastName;
        private TextBox txtName;
        private DateTimePicker dateTimePickerDateBirth;
        private TextBox txtPlaceBirth;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCUILL;
        private Label txtDNI;
        private BindingSource bindingSourceTeachers;
    }
}