﻿namespace GestIn
{
    partial class test
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
            this.btnLoadCareer = new System.Windows.Forms.Button();
            this.btnLoadSubjects = new System.Windows.Forms.Button();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadCareer
            // 
            this.btnLoadCareer.Location = new System.Drawing.Point(51, 38);
            this.btnLoadCareer.Name = "btnLoadCareer";
            this.btnLoadCareer.Size = new System.Drawing.Size(185, 29);
            this.btnLoadCareer.TabIndex = 0;
            this.btnLoadCareer.Text = "Cargar carreras";
            this.btnLoadCareer.UseVisualStyleBackColor = true;
            this.btnLoadCareer.Click += new System.EventHandler(this.btnLoadCareer_Click);
            // 
            // btnLoadSubjects
            // 
            this.btnLoadSubjects.Location = new System.Drawing.Point(51, 86);
            this.btnLoadSubjects.Name = "btnLoadSubjects";
            this.btnLoadSubjects.Size = new System.Drawing.Size(185, 29);
            this.btnLoadSubjects.TabIndex = 1;
            this.btnLoadSubjects.Text = "Cargar materias";
            this.btnLoadSubjects.UseVisualStyleBackColor = true;
            this.btnLoadSubjects.Click += new System.EventHandler(this.btnLoadSubjects_Click);
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(51, 135);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(185, 29);
            this.btnLoadStudents.TabIndex = 2;
            this.btnLoadStudents.Text = "Cargar alumnos";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadStudents);
            this.Controls.Add(this.btnLoadSubjects);
            this.Controls.Add(this.btnLoadCareer);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLoadCareer;
        private Button btnLoadSubjects;
        private Button btnLoadStudents;
    }
}