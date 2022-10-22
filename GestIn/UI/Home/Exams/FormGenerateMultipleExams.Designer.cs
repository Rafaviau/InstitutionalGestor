namespace GestIn.UI.Home.Exams
{
    partial class FormGenerateMultipleExams
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbFail = new System.Windows.Forms.PictureBox();
            this.pbSuccess = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCarrer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 39);
            this.panel1.TabIndex = 52;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::GestIn.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(534, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pbFail);
            this.panel2.Controls.Add(this.pbSuccess);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtTime);
            this.panel2.Controls.Add(this.dtDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbCarrer);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 599);
            this.panel2.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 73;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pbFail
            // 
            this.pbFail.Image = global::GestIn.Properties.Resources.BigErrorIcon;
            this.pbFail.Location = new System.Drawing.Point(188, 225);
            this.pbFail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbFail.Name = "pbFail";
            this.pbFail.Size = new System.Drawing.Size(144, 144);
            this.pbFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFail.TabIndex = 71;
            this.pbFail.TabStop = false;
            this.pbFail.Visible = false;
            // 
            // pbSuccess
            // 
            this.pbSuccess.Image = global::GestIn.Properties.Resources.Done;
            this.pbSuccess.Location = new System.Drawing.Point(188, 225);
            this.pbSuccess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSuccess.Name = "pbSuccess";
            this.pbSuccess.Size = new System.Drawing.Size(144, 144);
            this.pbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSuccess.TabIndex = 70;
            this.pbSuccess.TabStop = false;
            this.pbSuccess.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.IndianRed;
            this.lblError.Image = global::GestIn.Properties.Resources.Error;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(188, 451);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(140, 23);
            this.lblError.TabIndex = 69;
            this.lblError.Text = "          --Error--";
            this.lblError.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(287, 516);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(165, 35);
            this.btnGenerate.TabIndex = 67;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "Horario:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 65;
            this.label2.Text = "Fecha:";
            // 
            // dtTime
            // 
            this.dtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTime.CustomFormat = "HH:mm";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(115, 382);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(95, 27);
            this.dtTime.TabIndex = 64;
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.CalendarForeColor = System.Drawing.Color.Cyan;
            this.dtDate.CalendarMonthBackground = System.Drawing.Color.Blue;
            this.dtDate.CalendarTitleBackColor = System.Drawing.Color.Lime;
            this.dtDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtDate.CalendarTrailingForeColor = System.Drawing.Color.Yellow;
            this.dtDate.Location = new System.Drawing.Point(115, 288);
            this.dtDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(292, 27);
            this.dtDate.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Carrera:";
            // 
            // cbbCarrer
            // 
            this.cbbCarrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCarrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.cbbCarrer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCarrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCarrer.ForeColor = System.Drawing.Color.White;
            this.cbbCarrer.FormattingEnabled = true;
            this.cbbCarrer.Location = new System.Drawing.Point(115, 196);
            this.cbbCarrer.Margin = new System.Windows.Forms.Padding(5);
            this.cbbCarrer.MinimumSize = new System.Drawing.Size(171, 0);
            this.cbbCarrer.Name = "cbbCarrer";
            this.cbbCarrer.Size = new System.Drawing.Size(384, 28);
            this.cbbCarrer.Sorted = true;
            this.cbbCarrer.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(532, 102);
            this.label7.TabIndex = 40;
            this.label7.Text = "Generar todos los examenes de una carrera";
            // 
            // FormGenerateMultipleExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(573, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGenerateMultipleExams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGenerateMultipleExams";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private Panel panel2;
        private Label label7;
        private Label label1;
        private ComboBox cbbCarrer;
        private Label label3;
        private Label label2;
        private DateTimePicker dtTime;
        private DateTimePicker dtDate;
        private Button btnGenerate;
        private Label lblError;
        private PictureBox pbFail;
        private PictureBox pbSuccess;
        private Button button2;
        private Button button1;
    }
}