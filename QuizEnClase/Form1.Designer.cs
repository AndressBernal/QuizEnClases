namespace QuizEnClase
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCpturaDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.grbTipoPersona = new System.Windows.Forms.GroupBox();
            this.radProfesor = new System.Windows.Forms.RadioButton();
            this.radEstudiante = new System.Windows.Forms.RadioButton();
            this.gbrDatos = new System.Windows.Forms.GroupBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.dtgListaDatos = new System.Windows.Forms.DataGridView();
            this.grbTipoPersona.SuspendLayout();
            this.gbrDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCpturaDatos
            // 
            this.btnCpturaDatos.Location = new System.Drawing.Point(337, 269);
            this.btnCpturaDatos.Name = "btnCpturaDatos";
            this.btnCpturaDatos.Size = new System.Drawing.Size(95, 23);
            this.btnCpturaDatos.TabIndex = 0;
            this.btnCpturaDatos.Text = "Capturar Datos";
            this.btnCpturaDatos.UseVisualStyleBackColor = true;
            this.btnCpturaDatos.Click += new System.EventHandler(this.btnCpturaDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(633, 269);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(93, 23);
            this.btnMostrarDatos.TabIndex = 1;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // grbTipoPersona
            // 
            this.grbTipoPersona.Controls.Add(this.radProfesor);
            this.grbTipoPersona.Controls.Add(this.radEstudiante);
            this.grbTipoPersona.Location = new System.Drawing.Point(32, 28);
            this.grbTipoPersona.Name = "grbTipoPersona";
            this.grbTipoPersona.Size = new System.Drawing.Size(287, 122);
            this.grbTipoPersona.TabIndex = 2;
            this.grbTipoPersona.TabStop = false;
            this.grbTipoPersona.Text = "Tipo Persona";
            this.grbTipoPersona.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radProfesor
            // 
            this.radProfesor.AutoSize = true;
            this.radProfesor.Location = new System.Drawing.Point(52, 59);
            this.radProfesor.Name = "radProfesor";
            this.radProfesor.Size = new System.Drawing.Size(64, 17);
            this.radProfesor.TabIndex = 1;
            this.radProfesor.Text = "Profesor";
            this.radProfesor.UseVisualStyleBackColor = true;
            this.radProfesor.CheckedChanged += new System.EventHandler(this.radProfesor_CheckedChanged);
            // 
            // radEstudiante
            // 
            this.radEstudiante.AutoSize = true;
            this.radEstudiante.Checked = true;
            this.radEstudiante.Location = new System.Drawing.Point(52, 32);
            this.radEstudiante.Name = "radEstudiante";
            this.radEstudiante.Size = new System.Drawing.Size(75, 17);
            this.radEstudiante.TabIndex = 0;
            this.radEstudiante.TabStop = true;
            this.radEstudiante.Text = "Estudiante";
            this.radEstudiante.UseVisualStyleBackColor = true;
            this.radEstudiante.CheckedChanged += new System.EventHandler(this.radEstudiante_CheckedChanged);
            // 
            // gbrDatos
            // 
            this.gbrDatos.Controls.Add(this.txtCalificacion);
            this.gbrDatos.Controls.Add(this.txtSueldo);
            this.gbrDatos.Controls.Add(this.txtNombre);
            this.gbrDatos.Controls.Add(this.lblCalificacion);
            this.gbrDatos.Controls.Add(this.lblNombre);
            this.gbrDatos.Controls.Add(this.lblSueldo);
            this.gbrDatos.Location = new System.Drawing.Point(32, 156);
            this.gbrDatos.Name = "gbrDatos";
            this.gbrDatos.Size = new System.Drawing.Size(287, 136);
            this.gbrDatos.TabIndex = 3;
            this.gbrDatos.TabStop = false;
            this.gbrDatos.Text = "Datos de la persona";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(84, 77);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 8;
            this.txtCalificacion.TextChanged += new System.EventHandler(this.txtCalificacion_TextChanged);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(84, 51);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 7;
            this.txtSueldo.TextChanged += new System.EventHandler(this.textSueldo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(17, 83);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 6;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(17, 54);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 5;
            this.lblSueldo.Text = "Sueldo";
            // 
            // dtgListaDatos
            // 
            this.dtgListaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaDatos.Location = new System.Drawing.Point(337, 41);
            this.dtgListaDatos.Name = "dtgListaDatos";
            this.dtgListaDatos.Size = new System.Drawing.Size(389, 212);
            this.dtgListaDatos.TabIndex = 4;
            this.dtgListaDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 321);
            this.Controls.Add(this.dtgListaDatos);
            this.Controls.Add(this.gbrDatos);
            this.Controls.Add(this.grbTipoPersona);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCpturaDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbTipoPersona.ResumeLayout(false);
            this.grbTipoPersona.PerformLayout();
            this.gbrDatos.ResumeLayout(false);
            this.gbrDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCpturaDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.GroupBox grbTipoPersona;
        private System.Windows.Forms.RadioButton radProfesor;
        private System.Windows.Forms.RadioButton radEstudiante;
        private System.Windows.Forms.GroupBox gbrDatos;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.DataGridView dtgListaDatos;
    }
}

