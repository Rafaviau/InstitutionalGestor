namespace GestIn.Vista.Inicio.Carreras
{
    partial class formCarrerasView
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
            this.dataGridCarreras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCarreras
            // 
            this.dataGridCarreras.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridCarreras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarreras.ColumnHeadersVisible = false;
            this.dataGridCarreras.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridCarreras.Location = new System.Drawing.Point(12, 12);
            this.dataGridCarreras.MultiSelect = false;
            this.dataGridCarreras.Name = "dataGridCarreras";
            this.dataGridCarreras.ReadOnly = true;
            this.dataGridCarreras.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.dataGridCarreras.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCarreras.RowTemplate.Height = 29;
            this.dataGridCarreras.Size = new System.Drawing.Size(709, 456);
            this.dataGridCarreras.TabIndex = 13;
            // 
            // formCarrerasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 499);
            this.Controls.Add(this.dataGridCarreras);
            this.Name = "formCarrerasView";
            this.Text = "formCarrerasView";
            this.Controls.SetChildIndex(this.dataGridCarreras, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarreras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridCarreras;
    }
}