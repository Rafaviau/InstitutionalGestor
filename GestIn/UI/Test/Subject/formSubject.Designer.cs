namespace GestIn.Vista.Test
{
    partial class formSubject
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAnioCarrera = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAnioCarrera = new System.Windows.Forms.TextBox();
            this.txtCargaHorariaTotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cbbCarreraSelector = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.dataGridViewMaterias = new System.Windows.Forms.DataGridView();
            this.bindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListCorrelativas = new System.Windows.Forms.CheckedListBox();
            this.bindingSourceCarreraMaterias = new System.Windows.Forms.BindingSource(this.components);
            this.txtHorarioDesde = new System.Windows.Forms.TextBox();
            this.cbbDia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCronograma = new System.Windows.Forms.DataGridView();
            this.btnGuardarHorario = new System.Windows.Forms.Button();
            this.cbbMateriaSelector = new System.Windows.Forms.ComboBox();
            this.bindingSourceMateriaCorrelativas = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCorrelativas = new System.Windows.Forms.DataGridView();
            this.bindingSourceMateriaCronograma = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDocente = new System.Windows.Forms.DataGridView();
            this.lblDocente = new System.Windows.Forms.Label();
            this.cbbDocentes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarDocente = new System.Windows.Forms.Button();
            this.bindingSourceDocentes = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceMateriaDocentes = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.bindingSourceCorrelativasMenosMisma = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCronograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCorrelativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelativas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCronograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCorrelativasMenosMisma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(54, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAnioCarrera
            // 
            this.lblAnioCarrera.AutoSize = true;
            this.lblAnioCarrera.Location = new System.Drawing.Point(54, 186);
            this.lblAnioCarrera.Name = "lblAnioCarrera";
            this.lblAnioCarrera.Size = new System.Drawing.Size(88, 20);
            this.lblAnioCarrera.TabIndex = 2;
            this.lblAnioCarrera.Text = "AnioCarrera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "CargaHorariaTotal";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(260, 108);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 27);
            this.txtNombre.TabIndex = 9;
            // 
            // txtAnioCarrera
            // 
            this.txtAnioCarrera.Location = new System.Drawing.Point(260, 175);
            this.txtAnioCarrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnioCarrera.Name = "txtAnioCarrera";
            this.txtAnioCarrera.Size = new System.Drawing.Size(175, 27);
            this.txtAnioCarrera.TabIndex = 10;
            // 
            // txtCargaHorariaTotal
            // 
            this.txtCargaHorariaTotal.Location = new System.Drawing.Point(260, 242);
            this.txtCargaHorariaTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargaHorariaTotal.Name = "txtCargaHorariaTotal";
            this.txtCargaHorariaTotal.Size = new System.Drawing.Size(175, 27);
            this.txtCargaHorariaTotal.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(54, 699);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 31);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(159, 699);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 31);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(264, 699);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(86, 31);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cbbCarreraSelector
            // 
            this.cbbCarreraSelector.FormattingEnabled = true;
            this.cbbCarreraSelector.Location = new System.Drawing.Point(258, 50);
            this.cbbCarreraSelector.Name = "cbbCarreraSelector";
            this.cbbCarreraSelector.Size = new System.Drawing.Size(175, 28);
            this.cbbCarreraSelector.TabIndex = 17;
            this.cbbCarreraSelector.SelectedIndexChanged += new System.EventHandler(this.cbbCarreras_SelectedIndexChanged);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(51, 61);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(52, 20);
            this.lblCarrera.TabIndex = 18;
            this.lblCarrera.Text = "Career";
            // 
            // dataGridViewMaterias
            // 
            this.dataGridViewMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterias.Location = new System.Drawing.Point(492, 50);
            this.dataGridViewMaterias.Name = "dataGridViewMaterias";
            this.dataGridViewMaterias.ReadOnly = true;
            this.dataGridViewMaterias.RowHeadersWidth = 51;
            this.dataGridViewMaterias.RowTemplate.Height = 29;
            this.dataGridViewMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterias.Size = new System.Drawing.Size(774, 319);
            this.dataGridViewMaterias.TabIndex = 19;
            this.dataGridViewMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_CellClick);
            this.dataGridViewMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_CellContentClick);
            this.dataGridViewMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaterias_CellDoubleClick);
            // 
            // checkedListCorrelativas
            // 
            this.checkedListCorrelativas.FormattingEnabled = true;
            this.checkedListCorrelativas.Location = new System.Drawing.Point(51, 355);
            this.checkedListCorrelativas.Name = "checkedListCorrelativas";
            this.checkedListCorrelativas.Size = new System.Drawing.Size(189, 268);
            this.checkedListCorrelativas.TabIndex = 21;
            // 
            // txtHorarioDesde
            // 
            this.txtHorarioDesde.Location = new System.Drawing.Point(1424, 99);
            this.txtHorarioDesde.Name = "txtHorarioDesde";
            this.txtHorarioDesde.Size = new System.Drawing.Size(125, 27);
            this.txtHorarioDesde.TabIndex = 23;
            // 
            // cbbDia
            // 
            this.cbbDia.FormattingEnabled = true;
            this.cbbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cbbDia.Location = new System.Drawing.Point(1424, 56);
            this.cbbDia.Name = "cbbDia";
            this.cbbDia.Size = new System.Drawing.Size(125, 28);
            this.cbbDia.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1302, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1293, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Horario Desde";
            // 
            // dataGridViewCronograma
            // 
            this.dataGridViewCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCronograma.Location = new System.Drawing.Point(814, 607);
            this.dataGridViewCronograma.Name = "dataGridViewCronograma";
            this.dataGridViewCronograma.ReadOnly = true;
            this.dataGridViewCronograma.RowHeadersWidth = 51;
            this.dataGridViewCronograma.RowTemplate.Height = 29;
            this.dataGridViewCronograma.Size = new System.Drawing.Size(300, 123);
            this.dataGridViewCronograma.TabIndex = 27;
            // 
            // btnGuardarHorario
            // 
            this.btnGuardarHorario.Location = new System.Drawing.Point(1584, 97);
            this.btnGuardarHorario.Name = "btnGuardarHorario";
            this.btnGuardarHorario.Size = new System.Drawing.Size(94, 29);
            this.btnGuardarHorario.TabIndex = 28;
            this.btnGuardarHorario.Text = "Guardar Horario";
            this.btnGuardarHorario.UseVisualStyleBackColor = true;
            this.btnGuardarHorario.Click += new System.EventHandler(this.btnGuardarHorario_Click);
            // 
            // cbbMateriaSelector
            // 
            this.cbbMateriaSelector.FormattingEnabled = true;
            this.cbbMateriaSelector.Location = new System.Drawing.Point(492, 375);
            this.cbbMateriaSelector.Name = "cbbMateriaSelector";
            this.cbbMateriaSelector.Size = new System.Drawing.Size(774, 28);
            this.cbbMateriaSelector.TabIndex = 29;
            this.cbbMateriaSelector.SelectedIndexChanged += new System.EventHandler(this.cbbMateriaSelector_SelectedIndexChanged);
            // 
            // bindingSourceMateriaCorrelativas
            // 
            this.bindingSourceMateriaCorrelativas.CurrentChanged += new System.EventHandler(this.bindingSourceMateriaCorrelativas_CurrentChanged);
            // 
            // dataGridViewCorrelativas
            // 
            this.dataGridViewCorrelativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCorrelativas.Location = new System.Drawing.Point(492, 609);
            this.dataGridViewCorrelativas.Name = "dataGridViewCorrelativas";
            this.dataGridViewCorrelativas.ReadOnly = true;
            this.dataGridViewCorrelativas.RowHeadersWidth = 51;
            this.dataGridViewCorrelativas.RowTemplate.Height = 29;
            this.dataGridViewCorrelativas.Size = new System.Drawing.Size(301, 121);
            this.dataGridViewCorrelativas.TabIndex = 30;
            this.dataGridViewCorrelativas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCorrelativas_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cronograma de Career";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Correlativas de Career";
            // 
            // dataGridViewDocente
            // 
            this.dataGridViewDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocente.Location = new System.Drawing.Point(1132, 607);
            this.dataGridViewDocente.Name = "dataGridViewDocente";
            this.dataGridViewDocente.ReadOnly = true;
            this.dataGridViewDocente.RowHeadersWidth = 51;
            this.dataGridViewDocente.RowTemplate.Height = 29;
            this.dataGridViewDocente.Size = new System.Drawing.Size(308, 123);
            this.dataGridViewDocente.TabIndex = 33;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(1296, 258);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(65, 20);
            this.lblDocente.TabIndex = 34;
            this.lblDocente.Text = "Docente";
            // 
            // cbbDocentes
            // 
            this.cbbDocentes.FormattingEnabled = true;
            this.cbbDocentes.Location = new System.Drawing.Point(1424, 250);
            this.cbbDocentes.Name = "cbbDocentes";
            this.cbbDocentes.Size = new System.Drawing.Size(125, 28);
            this.cbbDocentes.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1132, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Docentes de la Career";
            // 
            // btnGuardarDocente
            // 
            this.btnGuardarDocente.Location = new System.Drawing.Point(1584, 249);
            this.btnGuardarDocente.Name = "btnGuardarDocente";
            this.btnGuardarDocente.Size = new System.Drawing.Size(94, 29);
            this.btnGuardarDocente.TabIndex = 37;
            this.btnGuardarDocente.Text = "Guardar";
            this.btnGuardarDocente.UseVisualStyleBackColor = true;
            this.btnGuardarDocente.Click += new System.EventHandler(this.btnGuardarDocente_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Final",
            "Cursada"});
            this.checkedListBox1.Location = new System.Drawing.Point(246, 355);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(134, 48);
            this.checkedListBox1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Correlativas";
            // 
            // formSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1690, 771);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnGuardarDocente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbDocentes);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.dataGridViewDocente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewCorrelativas);
            this.Controls.Add(this.cbbMateriaSelector);
            this.Controls.Add(this.btnGuardarHorario);
            this.Controls.Add(this.dataGridViewCronograma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbDia);
            this.Controls.Add(this.txtHorarioDesde);
            this.Controls.Add(this.checkedListCorrelativas);
            this.Controls.Add(this.dataGridViewMaterias);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cbbCarreraSelector);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCargaHorariaTotal);
            this.Controls.Add(this.txtAnioCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAnioCarrera);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formSubject";
            this.Text = "FormMateria";
            this.Load += new System.EventHandler(this.formMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCarreraMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCronograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCorrelativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelativas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaCronograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMateriaDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCorrelativasMenosMisma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblNombre;
        private Label lblAnioCarrera;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtAnioCarrera;
        private TextBox txtCargaHorariaTotal;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnBorrar;
        private ComboBox cbbCarreraSelector;
        private Label lblCarrera;
        private DataGridView dataGridViewMaterias;
        private BindingSource bindingSourceCarreras;
        private CheckedListBox checkedListCorrelativas;
        private BindingSource bindingSourceCarreraMaterias;
        private TextBox txtHorarioDesde;
        private ComboBox cbbDia;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewCronograma;
        private Button btnGuardarHorario;
        private ComboBox cbbMateriaSelector;
        private BindingSource bindingSourceMateriaCorrelativas;
        private DataGridView dataGridViewCorrelativas;
        private BindingSource bindingSourceMateriaCronograma;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewDocente;
        private Label lblDocente;
        private ComboBox cbbDocentes;
        private Label label6;
        private Button btnGuardarDocente;
        private BindingSource bindingSourceDocentes;
        private BindingSource bindingSourceMateriaDocentes;
        private CheckedListBox checkedListBox1;
        private BindingSource bindingSourceCorrelativasMenosMisma;
        private Label label7;
    }
}