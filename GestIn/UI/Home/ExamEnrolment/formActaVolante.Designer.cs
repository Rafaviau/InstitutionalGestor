namespace GestIn.UI.Home.ExamEnrolment
{
    partial class formActaVolante
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lblExam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBoxPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnUnrol = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ListBoxPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.bottomPanel);
            this.MainPanel.Controls.Add(this.ListBoxPanel);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MainPanel.Size = new System.Drawing.Size(1085, 682);
            this.MainPanel.TabIndex = 0;
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExam.Location = new System.Drawing.Point(400, 0);
            this.lblExam.Margin = new System.Windows.Forms.Padding(0);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(258, 31);
            this.lblExam.TabIndex = 0;
            this.lblExam.Text = "--Nombre del examen--";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lblExam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 37);
            this.panel1.TabIndex = 1;
            // 
            // ListBoxPanel
            // 
            this.ListBoxPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListBoxPanel.Controls.Add(this.lbStudents);
            this.ListBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBoxPanel.Location = new System.Drawing.Point(10, 47);
            this.ListBoxPanel.Name = "ListBoxPanel";
            this.ListBoxPanel.Padding = new System.Windows.Forms.Padding(15);
            this.ListBoxPanel.Size = new System.Drawing.Size(1065, 568);
            this.ListBoxPanel.TabIndex = 2;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.bottomPanel.Controls.Add(this.btnUnrol);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 610);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1065, 62);
            this.bottomPanel.TabIndex = 3;
            // 
            // lbStudents
            // 
            this.lbStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 20;
            this.lbStudents.Location = new System.Drawing.Point(15, 15);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(1035, 538);
            this.lbStudents.TabIndex = 0;
            // 
            // btnUnrol
            // 
            this.btnUnrol.Location = new System.Drawing.Point(431, 21);
            this.btnUnrol.Name = "btnUnrol";
            this.btnUnrol.Size = new System.Drawing.Size(181, 29);
            this.btnUnrol.TabIndex = 0;
            this.btnUnrol.Text = "Dar de baja";
            this.btnUnrol.UseVisualStyleBackColor = true;
            // 
            // formActaVolante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 682);
            this.Controls.Add(this.MainPanel);
            this.Name = "formActaVolante";
            this.Text = "formActaVolante";
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ListBoxPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Panel bottomPanel;
        private Button btnUnrol;
        private Panel ListBoxPanel;
        private ListBox lbStudents;
        private Panel panel1;
        private Label lblExam;
    }
}