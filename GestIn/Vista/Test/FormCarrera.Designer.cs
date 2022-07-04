namespace GestIn.Vista.Test
{
    partial class formCarrera
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
            this.txtNumResolucion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTurno = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFormMateria = new System.Windows.Forms.Button();
            this.dataGridViewCarreras = new System.Windows.Forms.DataGridView();
            this.BindingSourceCarreras = new System.Windows.Forms.BindingSource(this.components);
            this.btnTesteo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumResolucion
            // 
            this.txtNumResolucion.Location = new System.Drawing.Point(183, 68);
            this.txtNumResolucion.Name = "txtNumResolucion";
            this.txtNumResolucion.Size = new System.Drawing.Size(151, 27);
            this.txtNumResolucion.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Location = new System.Drawing.Point(183, 160);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(151, 27);
            this.txtNombreCorto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NumResolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "NombreCorto";
            // 
            // cbbTurno
            // 
            this.cbbTurno.FormattingEnabled = true;
            this.cbbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Vespertino"});
            this.cbbTurno.Location = new System.Drawing.Point(183, 209);
            this.cbbTurno.Name = "cbbTurno";
            this.cbbTurno.Size = new System.Drawing.Size(151, 28);
            this.cbbTurno.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(91, 212);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(47, 20);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Turno";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(55, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(169, 305);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(286, 305);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFormMateria
            // 
            this.btnFormMateria.Location = new System.Drawing.Point(879, 356);
            this.btnFormMateria.Name = "btnFormMateria";
            this.btnFormMateria.Size = new System.Drawing.Size(94, 29);
            this.btnFormMateria.TabIndex = 13;
            this.btnFormMateria.Text = "Materia";
            this.btnFormMateria.UseVisualStyleBackColor = true;
            this.btnFormMateria.Click += new System.EventHandler(this.btnFormMateria_Click);
            // 
            // dataGridViewCarreras
            // 
            this.dataGridViewCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarreras.Location = new System.Drawing.Point(426, 38);
            this.dataGridViewCarreras.Name = "dataGridViewCarreras";
            this.dataGridViewCarreras.RowHeadersWidth = 51;
            this.dataGridViewCarreras.RowTemplate.Height = 29;
            this.dataGridViewCarreras.Size = new System.Drawing.Size(550, 296);
            this.dataGridViewCarreras.TabIndex = 14;
            this.dataGridViewCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellClick);
            this.dataGridViewCarreras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarreras_CellDoubleClick);
            // 
            // btnTesteo
            // 
            this.btnTesteo.Location = new System.Drawing.Point(767, 356);
            this.btnTesteo.Name = "btnTesteo";
            this.btnTesteo.Size = new System.Drawing.Size(94, 29);
            this.btnTesteo.TabIndex = 15;
            this.btnTesteo.Text = "Testeo";
            this.btnTesteo.UseVisualStyleBackColor = true;
            this.btnTesteo.Click += new System.EventHandler(this.btnTesteo_Click);
            // 
            // formCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(993, 398);
            this.Controls.Add(this.btnTesteo);
            this.Controls.Add(this.dataGridViewCarreras);
            this.Controls.Add(this.btnFormMateria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cbbTurno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCorto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumResolucion);
            this.Name = "formCarrera";
            this.Text = "FormCarrera";
            this.Load += new System.EventHandler(this.formCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumResolucion;
        private TextBox txtNombre;
        private TextBox txtNombreCorto;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbTurno;
        private Label lbl4;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnFormMateria;
        private DataGridView dataGridViewCarreras;
        private BindingSource BindingSourceCarreras;
        private Button btnTesteo;
    }
}