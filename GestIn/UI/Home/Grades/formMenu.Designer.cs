namespace GestIn.UI.Home.Grades
{
    partial class formMenu
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddCareer = new System.Windows.Forms.Button();
            this.addGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(35, 108);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(247, 29);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Agregar estudiante";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddCareer
            // 
            this.btnAddCareer.Location = new System.Drawing.Point(35, 180);
            this.btnAddCareer.Name = "btnAddCareer";
            this.btnAddCareer.Size = new System.Drawing.Size(247, 29);
            this.btnAddCareer.TabIndex = 1;
            this.btnAddCareer.Text = "Agregar carrera/materia";
            this.btnAddCareer.UseVisualStyleBackColor = true;
            this.btnAddCareer.Click += new System.EventHandler(this.btnAddCareer_Click);
            // 
            // addGrade
            // 
            this.addGrade.Location = new System.Drawing.Point(35, 256);
            this.addGrade.Name = "addGrade";
            this.addGrade.Size = new System.Drawing.Size(247, 29);
            this.addGrade.TabIndex = 2;
            this.addGrade.Text = "Agregar una nota";
            this.addGrade.UseVisualStyleBackColor = true;
            this.addGrade.Click += new System.EventHandler(this.addGrade_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.addGrade);
            this.Controls.Add(this.btnAddCareer);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "formMenu";
            this.Text = "formMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddStudent;
        private Button btnAddCareer;
        private Button addGrade;
    }
}