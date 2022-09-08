﻿namespace GestIn.UI.Test
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
            this.correlativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativeSubjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativeFinalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModificationByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativeSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCorrelativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCorrelativasMenosMisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCorrelativas
            // 
            this.dataGridViewCorrelativas.AutoGenerateColumns = false;
            this.dataGridViewCorrelativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCorrelativas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.subjectIdDataGridViewTextBoxColumn,
            this.correlativeSubjectIdDataGridViewTextBoxColumn,
            this.correlativeFinalDataGridViewCheckBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn,
            this.deletedAtDataGridViewTextBoxColumn,
            this.lastModificationByDataGridViewTextBoxColumn,
            this.correlativeSubjectDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dataGridViewCorrelativas.DataSource = this.correlativeBindingSource;
            this.dataGridViewCorrelativas.Location = new System.Drawing.Point(102, 289);
            this.dataGridViewCorrelativas.Name = "dataGridViewCorrelativas";
            this.dataGridViewCorrelativas.ReadOnly = true;
            this.dataGridViewCorrelativas.RowHeadersWidth = 51;
            this.dataGridViewCorrelativas.RowTemplate.Height = 29;
            this.dataGridViewCorrelativas.Size = new System.Drawing.Size(463, 200);
            this.dataGridViewCorrelativas.TabIndex = 31;
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
            this.btnAddCorrelativas.Text = "Add Correlative";
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
            this.cbbCorrelativas.SelectedIndexChanged += new System.EventHandler(this.cbbCorrelativas_SelectedIndexChanged);
            // 
            // btnRemoveCorrelative
            // 
            this.btnRemoveCorrelative.Location = new System.Drawing.Point(404, 203);
            this.btnRemoveCorrelative.Name = "btnRemoveCorrelative";
            this.btnRemoveCorrelative.Size = new System.Drawing.Size(161, 37);
            this.btnRemoveCorrelative.TabIndex = 46;
            this.btnRemoveCorrelative.Text = "Remove Correlative";
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
            // correlativeBindingSource
            // 
            this.correlativeBindingSource.DataSource = typeof(GestIn.Model.Correlative);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            this.subjectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // correlativeSubjectIdDataGridViewTextBoxColumn
            // 
            this.correlativeSubjectIdDataGridViewTextBoxColumn.DataPropertyName = "CorrelativeSubjectId";
            this.correlativeSubjectIdDataGridViewTextBoxColumn.HeaderText = "CorrelativeSubjectId";
            this.correlativeSubjectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correlativeSubjectIdDataGridViewTextBoxColumn.Name = "correlativeSubjectIdDataGridViewTextBoxColumn";
            this.correlativeSubjectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.correlativeSubjectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // correlativeFinalDataGridViewCheckBoxColumn
            // 
            this.correlativeFinalDataGridViewCheckBoxColumn.DataPropertyName = "CorrelativeFinal";
            this.correlativeFinalDataGridViewCheckBoxColumn.HeaderText = "CorrelativeFinal";
            this.correlativeFinalDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.correlativeFinalDataGridViewCheckBoxColumn.Name = "correlativeFinalDataGridViewCheckBoxColumn";
            this.correlativeFinalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.correlativeFinalDataGridViewCheckBoxColumn.Width = 125;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletedAtDataGridViewTextBoxColumn
            // 
            this.deletedAtDataGridViewTextBoxColumn.DataPropertyName = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.HeaderText = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedAtDataGridViewTextBoxColumn.Name = "deletedAtDataGridViewTextBoxColumn";
            this.deletedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastModificationByDataGridViewTextBoxColumn
            // 
            this.lastModificationByDataGridViewTextBoxColumn.DataPropertyName = "LastModificationBy";
            this.lastModificationByDataGridViewTextBoxColumn.HeaderText = "LastModificationBy";
            this.lastModificationByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastModificationByDataGridViewTextBoxColumn.Name = "lastModificationByDataGridViewTextBoxColumn";
            this.lastModificationByDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastModificationByDataGridViewTextBoxColumn.Width = 125;
            // 
            // correlativeSubjectDataGridViewTextBoxColumn
            // 
            this.correlativeSubjectDataGridViewTextBoxColumn.DataPropertyName = "CorrelativeSubject";
            this.correlativeSubjectDataGridViewTextBoxColumn.HeaderText = "CorrelativeSubject";
            this.correlativeSubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correlativeSubjectDataGridViewTextBoxColumn.Name = "correlativeSubjectDataGridViewTextBoxColumn";
            this.correlativeSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.correlativeSubjectDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectDataGridViewTextBoxColumn.Width = 125;
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
            this.Load += new System.EventHandler(this.formSubjectCorrelatives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCorrelativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCorrelativasMenosMisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correlativeBindingSource)).EndInit();
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correlativeSubjectIdDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn correlativeFinalDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deletedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastModificationByDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correlativeSubjectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private BindingSource correlativeBindingSource;
    }
}