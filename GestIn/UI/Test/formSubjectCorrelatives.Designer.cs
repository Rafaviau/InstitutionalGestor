namespace GestIn.UI.Test
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
            this.dataGridViewCorrelativas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrelativeSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativeFinalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.correlativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCorrelativas = new System.Windows.Forms.Button();
            this.cbbCorrelativas = new System.Windows.Forms.ComboBox();
            this.bindingSourceMateriaCorrelativas = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCorrelativasMenosMisma = new System.Windows.Forms.BindingSource(this.components);
            this.btnRemoveCorrelative = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmateriaName = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCorrelativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCorrelativasMenosMisma)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCorrelativas
            // 
            this.dataGridViewCorrelativas.AllowUserToAddRows = false;
            this.dataGridViewCorrelativas.AllowUserToDeleteRows = false;
            this.dataGridViewCorrelativas.AutoGenerateColumns = false;
            this.dataGridViewCorrelativas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCorrelativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCorrelativas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CorrelativeSubject,
            this.correlativeFinalDataGridViewCheckBoxColumn});
            this.dataGridViewCorrelativas.DataSource = this.correlativeBindingSource;
            this.dataGridViewCorrelativas.Location = new System.Drawing.Point(102, 289);
            this.dataGridViewCorrelativas.Name = "dataGridViewCorrelativas";
            this.dataGridViewCorrelativas.ReadOnly = true;
            this.dataGridViewCorrelativas.RowHeadersWidth = 51;
            this.dataGridViewCorrelativas.RowTemplate.Height = 29;
            this.dataGridViewCorrelativas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCorrelativas.Size = new System.Drawing.Size(481, 200);
            this.dataGridViewCorrelativas.TabIndex = 31;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CorrelativeSubject
            // 
            this.CorrelativeSubject.DataPropertyName = "CorrelativeSubject";
            this.CorrelativeSubject.HeaderText = "CorrelativeSubject";
            this.CorrelativeSubject.MinimumWidth = 6;
            this.CorrelativeSubject.Name = "CorrelativeSubject";
            this.CorrelativeSubject.ReadOnly = true;
            // 
            // correlativeFinalDataGridViewCheckBoxColumn
            // 
            this.correlativeFinalDataGridViewCheckBoxColumn.DataPropertyName = "CorrelativeFinal";
            this.correlativeFinalDataGridViewCheckBoxColumn.HeaderText = "CorrelativeFinal";
            this.correlativeFinalDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.correlativeFinalDataGridViewCheckBoxColumn.Name = "correlativeFinalDataGridViewCheckBoxColumn";
            this.correlativeFinalDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // correlativeBindingSource
            // 
            this.correlativeBindingSource.DataSource = typeof(GestIn.Model.Correlative);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Correlativas de la Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Correlativas";
            // 
            // btnAddCorrelativas
            // 
            this.btnAddCorrelativas.Location = new System.Drawing.Point(407, 149);
            this.btnAddCorrelativas.Name = "btnAddCorrelativas";
            this.btnAddCorrelativas.Size = new System.Drawing.Size(158, 38);
            this.btnAddCorrelativas.TabIndex = 44;
            this.btnAddCorrelativas.Text = "Agregar Correlativa";
            this.btnAddCorrelativas.UseVisualStyleBackColor = true;
            this.btnAddCorrelativas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCorrelativas_MouseClick);
            // 
            // cbbCorrelativas
            // 
            this.cbbCorrelativas.FormattingEnabled = true;
            this.cbbCorrelativas.Location = new System.Drawing.Point(102, 155);
            this.cbbCorrelativas.Name = "cbbCorrelativas";
            this.cbbCorrelativas.Size = new System.Drawing.Size(216, 28);
            this.cbbCorrelativas.TabIndex = 45;
            // 
            // btnRemoveCorrelative
            // 
            this.btnRemoveCorrelative.Location = new System.Drawing.Point(407, 203);
            this.btnRemoveCorrelative.Name = "btnRemoveCorrelative";
            this.btnRemoveCorrelative.Size = new System.Drawing.Size(158, 37);
            this.btnRemoveCorrelative.TabIndex = 46;
            this.btnRemoveCorrelative.Text = "Remover Correlativa";
            this.btnRemoveCorrelative.UseVisualStyleBackColor = true;
            this.btnRemoveCorrelative.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRemoveCorrelative_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Materia Seleccionada: ";
            // 
            // lblmateriaName
            // 
            this.lblmateriaName.AutoSize = true;
            this.lblmateriaName.Location = new System.Drawing.Point(372, 88);
            this.lblmateriaName.Name = "lblmateriaName";
            this.lblmateriaName.Size = new System.Drawing.Size(91, 20);
            this.lblmateriaName.TabIndex = 48;
            this.lblmateriaName.Text = "MateriaAqui";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(253, 207);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(62, 24);
            this.chkEstado.TabIndex = 49;
            this.chkEstado.Text = "Final";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Estado";
            // 
            // formSubjectCorrelatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(683, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.lblmateriaName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveCorrelative);
            this.Controls.Add(this.cbbCorrelativas);
            this.Controls.Add(this.btnAddCorrelativas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewCorrelativas);
            this.Name = "formSubjectCorrelatives";
            this.Text = "formSubjectCorrelatives";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSubjectCorrelatives_FormClosed);
            this.Load += new System.EventHandler(this.formSubjectCorrelatives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCorrelativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCorrelativasMenosMisma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridViewCorrelativas;
        private Label label7;
        private Label label2;
        private Button btnAddCorrelativas;
        private ComboBox cbbCorrelativas;
        private BindingSource bindingSourceMateriaCorrelativas;
        private BindingSource bindingSourceCorrelativasMenosMisma;
        private Button btnRemoveCorrelative;
        private Label label1;
        private Label lblmateriaName;
        private CheckBox chkEstado;
        private Label label3;
        private BindingSource correlativeBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CorrelativeSubject;
        private DataGridViewCheckBoxColumn correlativeFinalDataGridViewCheckBoxColumn;
    }
}