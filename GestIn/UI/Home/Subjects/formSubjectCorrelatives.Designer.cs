namespace GestIn.UI.Home.Subjects
{
    partial class formSubjectCorrelatives
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCorrelativas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativeSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrelativeFinal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.correlativeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.correlativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correlativeFinalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddCorrelativas = new System.Windows.Forms.Button();
            this.cbbCorrelativas = new System.Windows.Forms.ComboBox();
            this.bindingSourceMateriaCorrelativas = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCorrelativasMenosMisma = new System.Windows.Forms.BindingSource(this.components);
            this.btnRemoveCorrelative = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmateriaName = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.checkBoxEspecial = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCorrelativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCorrelativasMenosMisma)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCorrelativas
            // 
            this.dataGridViewCorrelativas.AllowUserToAddRows = false;
            this.dataGridViewCorrelativas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.dataGridViewCorrelativas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCorrelativas.AutoGenerateColumns = false;
            this.dataGridViewCorrelativas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCorrelativas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridViewCorrelativas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCorrelativas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCorrelativas.ColumnHeadersHeight = 54;
            this.dataGridViewCorrelativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCorrelativas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.correlativeSubjectDataGridViewTextBoxColumn,
            this.CorrelativeFinal});
            this.dataGridViewCorrelativas.DataSource = this.correlativeBindingSource1;
            this.dataGridViewCorrelativas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCorrelativas.EnableHeadersVisualStyles = false;
            this.dataGridViewCorrelativas.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridViewCorrelativas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCorrelativas.MultiSelect = false;
            this.dataGridViewCorrelativas.Name = "dataGridViewCorrelativas";
            this.dataGridViewCorrelativas.ReadOnly = true;
            this.dataGridViewCorrelativas.RowHeadersVisible = false;
            this.dataGridViewCorrelativas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dataGridViewCorrelativas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCorrelativas.RowTemplate.Height = 29;
            this.dataGridViewCorrelativas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCorrelativas.Size = new System.Drawing.Size(1159, 403);
            this.dataGridViewCorrelativas.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // correlativeSubjectDataGridViewTextBoxColumn
            // 
            this.correlativeSubjectDataGridViewTextBoxColumn.DataPropertyName = "CorrelativeSubject";
            this.correlativeSubjectDataGridViewTextBoxColumn.HeaderText = "Materia Correlativa";
            this.correlativeSubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correlativeSubjectDataGridViewTextBoxColumn.Name = "correlativeSubjectDataGridViewTextBoxColumn";
            this.correlativeSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CorrelativeFinal
            // 
            this.CorrelativeFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CorrelativeFinal.DataPropertyName = "CorrelativeFinal";
            this.CorrelativeFinal.HeaderText = "Requiere final";
            this.CorrelativeFinal.MinimumWidth = 6;
            this.CorrelativeFinal.Name = "CorrelativeFinal";
            this.CorrelativeFinal.ReadOnly = true;
            this.CorrelativeFinal.Width = 121;
            // 
            // correlativeBindingSource1
            // 
            this.correlativeBindingSource1.DataSource = typeof(GestIn.Model.Correlative);
            // 
            // correlativeFinalDataGridViewCheckBoxColumn
            // 
            this.correlativeFinalDataGridViewCheckBoxColumn.DataPropertyName = "CorrelativeFinal";
            this.correlativeFinalDataGridViewCheckBoxColumn.HeaderText = "CorrelativeFinal";
            this.correlativeFinalDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.correlativeFinalDataGridViewCheckBoxColumn.Name = "correlativeFinalDataGridViewCheckBoxColumn";
            this.correlativeFinalDataGridViewCheckBoxColumn.Width = 143;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 31);
            this.label7.TabIndex = 41;
            this.label7.Text = "Correlativas de la Materia";
            // 
            // btnAddCorrelativas
            // 
            this.btnAddCorrelativas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnAddCorrelativas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCorrelativas.ForeColor = System.Drawing.Color.White;
            this.btnAddCorrelativas.Location = new System.Drawing.Point(966, 55);
            this.btnAddCorrelativas.Name = "btnAddCorrelativas";
            this.btnAddCorrelativas.Size = new System.Drawing.Size(170, 49);
            this.btnAddCorrelativas.TabIndex = 4;
            this.btnAddCorrelativas.Text = "Agregar Correlativa";
            this.btnAddCorrelativas.UseVisualStyleBackColor = false;
            this.btnAddCorrelativas.Click += new System.EventHandler(this.btnAddCorrelativas_Click);
            // 
            // cbbCorrelativas
            // 
            this.cbbCorrelativas.BackColor = System.Drawing.Color.White;
            this.cbbCorrelativas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCorrelativas.ForeColor = System.Drawing.Color.Black;
            this.cbbCorrelativas.FormattingEnabled = true;
            this.cbbCorrelativas.Location = new System.Drawing.Point(19, 100);
            this.cbbCorrelativas.Name = "cbbCorrelativas";
            this.cbbCorrelativas.Size = new System.Drawing.Size(817, 28);
            this.cbbCorrelativas.TabIndex = 1;
            // 
            // btnRemoveCorrelative
            // 
            this.btnRemoveCorrelative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnRemoveCorrelative.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCorrelative.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCorrelative.Location = new System.Drawing.Point(966, 129);
            this.btnRemoveCorrelative.Name = "btnRemoveCorrelative";
            this.btnRemoveCorrelative.Size = new System.Drawing.Size(170, 49);
            this.btnRemoveCorrelative.TabIndex = 5;
            this.btnRemoveCorrelative.Text = "Remover Correlativa";
            this.btnRemoveCorrelative.UseVisualStyleBackColor = false;
            this.btnRemoveCorrelative.Click += new System.EventHandler(this.btnRemoveCorrelative_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Agregando correlatividades a: ";
            // 
            // lblmateriaName
            // 
            this.lblmateriaName.AutoSize = true;
            this.lblmateriaName.ForeColor = System.Drawing.Color.White;
            this.lblmateriaName.Location = new System.Drawing.Point(342, 28);
            this.lblmateriaName.Name = "lblmateriaName";
            this.lblmateriaName.Size = new System.Drawing.Size(91, 20);
            this.lblmateriaName.TabIndex = 48;
            this.lblmateriaName.Text = "MateriaAqui";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.ForeColor = System.Drawing.Color.White;
            this.chkEstado.Location = new System.Drawing.Point(19, 142);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(200, 24);
            this.chkEstado.TabIndex = 2;
            this.chkEstado.Text = "Requiere final para cursar";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // checkBoxEspecial
            // 
            this.checkBoxEspecial.AutoSize = true;
            this.checkBoxEspecial.Location = new System.Drawing.Point(225, 142);
            this.checkBoxEspecial.Name = "checkBoxEspecial";
            this.checkBoxEspecial.Size = new System.Drawing.Size(246, 24);
            this.checkBoxEspecial.TabIndex = 3;
            this.checkBoxEspecial.Text = "Mostrar materias del mismo año";
            this.checkBoxEspecial.UseVisualStyleBackColor = true;
            this.checkBoxEspecial.CheckStateChanged += new System.EventHandler(this.checkBoxEspecial_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Seleccione una materia correlativa:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRemoveCorrelative);
            this.panel1.Controls.Add(this.checkBoxEspecial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblmateriaName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddCorrelativas);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chkEstado);
            this.panel1.Controls.Add(this.cbbCorrelativas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 251);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCorrelativas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 403);
            this.panel2.TabIndex = 54;
            // 
            // formSubjectCorrelatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1159, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "formSubjectCorrelatives";
            this.Text = "Gestin - Correlativas Materia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSubjectCorrelatives_FormClosing);
            this.Load += new System.EventHandler(this.formSubjectCorrelatives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCorrelativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCorrelativasMenosMisma)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridViewCorrelativas;
        private Label label7;
        private Button btnAddCorrelativas;
        private ComboBox cbbCorrelativas;
        private BindingSource bindingSourceMateriaCorrelativas;
        private BindingSource bindingSourceCorrelativasMenosMisma;
        private Button btnRemoveCorrelative;
        private Label label1;
        private Label lblmateriaName;
        private CheckBox chkEstado;
        private BindingSource correlativeBindingSource;
        private DataGridViewCheckBoxColumn correlativeFinalDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn CorrelativeSubject;
        private BindingSource correlativeBindingSource1;
        private CheckBox checkBoxEspecial;
        private Label label3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn correlativeSubjectDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn CorrelativeFinal;
        private Panel panel1;
        private Panel panel2;
    }
}