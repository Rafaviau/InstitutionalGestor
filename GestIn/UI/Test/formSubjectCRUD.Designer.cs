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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCargaHorariaTotal = new System.Windows.Forms.TextBox();
            this.txtAnioCarrera = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnioCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridViewMaterias = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCarreraMaterias = new System.Windows.Forms.BindingSource(this.components);
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnCronograma = new System.Windows.Forms.Button();
            this.btnCorrelativas = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(310, 129);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(52, 20);
            this.lblCarrera.TabIndex = 29;
            this.lblCarrera.Text = "Career";
            // 
            // cbbCarreraSelector
            // 
            this.cbbCarreraSelector.Enabled = false;
            this.cbbCarreraSelector.FormattingEnabled = true;
            this.cbbCarreraSelector.Location = new System.Drawing.Point(472, 121);
            this.cbbCarreraSelector.Name = "cbbCarreraSelector";
            this.cbbCarreraSelector.Size = new System.Drawing.Size(175, 28);
            this.cbbCarreraSelector.TabIndex = 28;
            this.cbbCarreraSelector.SelectedIndexChanged += new System.EventHandler(this.cbbCarreraSelector_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(472, 319);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 31);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(370, 319);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 31);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "Guardar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseClick);
            // 
            // txtCargaHorariaTotal
            // 
            this.txtCargaHorariaTotal.Enabled = false;
            this.txtCargaHorariaTotal.Location = new System.Drawing.Point(472, 242);
            this.txtCargaHorariaTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargaHorariaTotal.Name = "txtCargaHorariaTotal";
            this.txtCargaHorariaTotal.Size = new System.Drawing.Size(175, 27);
            this.txtCargaHorariaTotal.TabIndex = 24;
            // 
            // txtAnioCarrera
            // 
            this.txtAnioCarrera.Enabled = false;
            this.txtAnioCarrera.Location = new System.Drawing.Point(472, 201);
            this.txtAnioCarrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnioCarrera.Name = "txtAnioCarrera";
            this.txtAnioCarrera.Size = new System.Drawing.Size(175, 27);
            this.txtAnioCarrera.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(472, 160);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 27);
            this.txtNombre.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "CargaHorariaTotal";
            // 
            // lblAnioCarrera
            // 
            this.lblAnioCarrera.AutoSize = true;
            this.lblAnioCarrera.Location = new System.Drawing.Point(310, 208);
            this.lblAnioCarrera.Name = "lblAnioCarrera";
            this.lblAnioCarrera.Size = new System.Drawing.Size(88, 20);
            this.lblAnioCarrera.TabIndex = 20;
            this.lblAnioCarrera.Text = "AnioCarrera";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(310, 167);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // dataGridViewMaterias
            // 
            this.dataGridViewMaterias.AllowUserToAddRows = false;
            this.dataGridViewMaterias.AllowUserToDeleteRows = false;
            this.dataGridViewMaterias.AllowUserToResizeRows = false;
            this.dataGridViewMaterias.AutoGenerateColumns = false;
            this.dataGridViewMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewMaterias.DataSource = this.subjectBindingSource1;
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
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataSource = typeof(GestIn.Model.Subject);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(GestIn.Model.Subject);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 51);
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
            this.btnDocentes.Text = "Cargar Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnCronograma
            // 
            this.btnCronograma.Location = new System.Drawing.Point(827, 629);
            this.btnCronograma.Name = "btnCronograma";
            this.btnCronograma.Size = new System.Drawing.Size(107, 62);
            this.btnCronograma.TabIndex = 34;
            this.btnCronograma.Text = "Cargar Cronograma";
            this.btnCronograma.UseVisualStyleBackColor = true;
            // 
            // btnCorrelativas
            // 
            this.btnCorrelativas.Location = new System.Drawing.Point(827, 460);
            this.btnCorrelativas.Name = "btnCorrelativas";
            this.btnCorrelativas.Size = new System.Drawing.Size(107, 52);
            this.btnCorrelativas.TabIndex = 35;
            this.btnCorrelativas.Text = "Cargar Correlativas";
            this.btnCorrelativas.UseVisualStyleBackColor = true;
            this.btnCorrelativas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCorrelativas_MouseClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(709, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CareerId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CareerId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "YearInCareer";
            this.dataGridViewTextBoxColumn4.HeaderText = "YearInCareer";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AnnualHourlyLoad";
            this.dataGridViewTextBoxColumn5.HeaderText = "AnnualHourlyLoad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // formSubjectCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCorrelativas);
            this.Controls.Add(this.btnCronograma);
            this.Controls.Add(this.btnDocentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMaterias);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cbbCarreraSelector);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
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
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCarrera;
        private ComboBox cbbCarreraSelector;
        private Button btnUpdate;
        private Button btnInsert;
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
        private Button btnModificar;
        private BindingSource subjectBindingSource1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}