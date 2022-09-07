namespace GestIn.UI.Test.Subject
{
    partial class formSubjectCRUD
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cbbCarreraSelector = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCargaHorariaTotal = new System.Windows.Forms.TextBox();
            this.txtAnioCarrera = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnioCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridViewMaterias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCarreraMaterias = new System.Windows.Forms.BindingSource(this.components);
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnCronograma = new System.Windows.Forms.Button();
            this.btnCorrelativas = new System.Windows.Forms.Button();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAREERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yEARINCAREERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNNUALHOURLYLOADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(196, 124);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(52, 20);
            this.lblCarrera.TabIndex = 29;
            this.lblCarrera.Text = "Career";
            // 
            // cbbCarreraSelector
            // 
            this.cbbCarreraSelector.FormattingEnabled = true;
            this.cbbCarreraSelector.Location = new System.Drawing.Point(479, 113);
            this.cbbCarreraSelector.Name = "cbbCarreraSelector";
            this.cbbCarreraSelector.Size = new System.Drawing.Size(175, 28);
            this.cbbCarreraSelector.TabIndex = 28;
            this.cbbCarreraSelector.SelectedIndexChanged += new System.EventHandler(this.cbbCarreraSelector_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(711, 378);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 31);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(606, 378);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 31);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseClick);
            // 
            // txtCargaHorariaTotal
            // 
            this.txtCargaHorariaTotal.Location = new System.Drawing.Point(481, 305);
            this.txtCargaHorariaTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargaHorariaTotal.Name = "txtCargaHorariaTotal";
            this.txtCargaHorariaTotal.Size = new System.Drawing.Size(175, 27);
            this.txtCargaHorariaTotal.TabIndex = 24;
            // 
            // txtAnioCarrera
            // 
            this.txtAnioCarrera.Location = new System.Drawing.Point(481, 238);
            this.txtAnioCarrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnioCarrera.Name = "txtAnioCarrera";
            this.txtAnioCarrera.Size = new System.Drawing.Size(175, 27);
            this.txtAnioCarrera.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(481, 171);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 27);
            this.txtNombre.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "CargaHorariaTotal";
            // 
            // lblAnioCarrera
            // 
            this.lblAnioCarrera.AutoSize = true;
            this.lblAnioCarrera.Location = new System.Drawing.Point(199, 249);
            this.lblAnioCarrera.Name = "lblAnioCarrera";
            this.lblAnioCarrera.Size = new System.Drawing.Size(88, 20);
            this.lblAnioCarrera.TabIndex = 20;
            this.lblAnioCarrera.Text = "AnioCarrera";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(199, 186);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // dataGridViewMaterias
            // 
            this.dataGridViewMaterias.AutoGenerateColumns = false;
            this.dataGridViewMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cAREERIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.yEARINCAREERDataGridViewTextBoxColumn,
            this.aNNUALHOURLYLOADDataGridViewTextBoxColumn});
            this.dataGridViewMaterias.DataSource = this.subjectBindingSource;
            this.dataGridViewMaterias.Location = new System.Drawing.Point(29, 416);
            this.dataGridViewMaterias.Name = "dataGridViewMaterias";
            this.dataGridViewMaterias.ReadOnly = true;
            this.dataGridViewMaterias.RowHeadersWidth = 51;
            this.dataGridViewMaterias.RowTemplate.Height = 29;
            this.dataGridViewMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterias.Size = new System.Drawing.Size(774, 319);
            this.dataGridViewMaterias.TabIndex = 30;
            this.dataGridViewMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "CRUD SUBJECT";
            // 
            // btnDocentes
            // 
            this.btnDocentes.Location = new System.Drawing.Point(827, 543);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(107, 51);
            this.btnDocentes.TabIndex = 33;
            this.btnDocentes.Text = "Agregar Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnCronograma
            // 
            this.btnCronograma.Location = new System.Drawing.Point(827, 632);
            this.btnCronograma.Name = "btnCronograma";
            this.btnCronograma.Size = new System.Drawing.Size(107, 62);
            this.btnCronograma.TabIndex = 34;
            this.btnCronograma.Text = "Agregar Cronograma";
            this.btnCronograma.UseVisualStyleBackColor = true;
            // 
            // btnCorrelativas
            // 
            this.btnCorrelativas.Location = new System.Drawing.Point(827, 460);
            this.btnCorrelativas.Name = "btnCorrelativas";
            this.btnCorrelativas.Size = new System.Drawing.Size(107, 52);
            this.btnCorrelativas.TabIndex = 35;
            this.btnCorrelativas.Text = "Agregar Correlativas";
            this.btnCorrelativas.UseVisualStyleBackColor = true;
            this.btnCorrelativas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCorrelativas_MouseClick);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(GestIn.Model.Subject);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cAREERIDDataGridViewTextBoxColumn
            // 
            this.cAREERIDDataGridViewTextBoxColumn.DataPropertyName = "CAREERID";
            this.cAREERIDDataGridViewTextBoxColumn.HeaderText = "CAREERID";
            this.cAREERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cAREERIDDataGridViewTextBoxColumn.Name = "cAREERIDDataGridViewTextBoxColumn";
            this.cAREERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cAREERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // yEARINCAREERDataGridViewTextBoxColumn
            // 
            this.yEARINCAREERDataGridViewTextBoxColumn.DataPropertyName = "YEARINCAREER";
            this.yEARINCAREERDataGridViewTextBoxColumn.HeaderText = "YEARINCAREER";
            this.yEARINCAREERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yEARINCAREERDataGridViewTextBoxColumn.Name = "yEARINCAREERDataGridViewTextBoxColumn";
            this.yEARINCAREERDataGridViewTextBoxColumn.ReadOnly = true;
            this.yEARINCAREERDataGridViewTextBoxColumn.Width = 125;
            // 
            // aNNUALHOURLYLOADDataGridViewTextBoxColumn
            // 
            this.aNNUALHOURLYLOADDataGridViewTextBoxColumn.DataPropertyName = "ANNUALHOURLYLOAD";
            this.aNNUALHOURLYLOADDataGridViewTextBoxColumn.HeaderText = "ANNUALHOURLYLOAD";
            this.aNNUALHOURLYLOADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aNNUALHOURLYLOADDataGridViewTextBoxColumn.Name = "aNNUALHOURLYLOADDataGridViewTextBoxColumn";
            this.aNNUALHOURLYLOADDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNNUALHOURLYLOADDataGridViewTextBoxColumn.Width = 125;
            // 
            // formSubjectCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnCorrelativas);
            this.Controls.Add(this.btnCronograma);
            this.Controls.Add(this.btnDocentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMaterias);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cbbCarreraSelector);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCargaHorariaTotal);
            this.Controls.Add(this.txtAnioCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAnioCarrera);
            this.Controls.Add(this.lblNombre);
            this.Name = "formSubjectCRUD";
            this.Text = "formSubjectCRUD";
            this.Load += new System.EventHandler(this.formSubjectCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCarrera;
        private ComboBox cbbCarreraSelector;
        private Button btnModificar;
        private Button btnGuardar;
        private TextBox txtCargaHorariaTotal;
        private TextBox txtAnioCarrera;
        private TextBox txtNombre;
        private Label label5;
        private Label lblAnioCarrera;
        private Label lblNombre;
        private DataGridView dataGridViewMaterias;
        private Label label1;
        private BindingSource bindingSourceCarreras;
        private BindingSource bindingSourceCarreraMaterias;
        private Button btnDocentes;
        private Button btnCronograma;
        private Button btnCorrelativas;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cAREERIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yEARINCAREERDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aNNUALHOURLYLOADDataGridViewTextBoxColumn;
        private BindingSource subjectBindingSource;
    }
}