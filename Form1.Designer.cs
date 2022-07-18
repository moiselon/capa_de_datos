namespace capa_de_acceso_a_datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.dgvcontactos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbgenero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbestado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcumpleaño = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE:";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(85, 15);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(160, 20);
            this.tbnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLDO(S):";
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(85, 55);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(160, 20);
            this.tbapellido.TabIndex = 3;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(85, 91);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(160, 20);
            this.tbtelefono.TabIndex = 4;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(85, 132);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(160, 20);
            this.tbemail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TELEFONO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-MAIL:";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(411, 45);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(103, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(547, 45);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(103, 23);
            this.btnborrar.TabIndex = 9;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(676, 45);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(103, 23);
            this.btngrabar.TabIndex = 10;
            this.btngrabar.Text = "Grabar Archivo";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // dgvcontactos
            // 
            this.dgvcontactos.AllowUserToAddRows = false;
            this.dgvcontactos.AllowUserToDeleteRows = false;
            this.dgvcontactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvcontactos.Location = new System.Drawing.Point(2, 373);
            this.dgvcontactos.Name = "dgvcontactos";
            this.dgvcontactos.ReadOnly = true;
            this.dgvcontactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcontactos.Size = new System.Drawing.Size(795, 175);
            this.dgvcontactos.TabIndex = 11;
            this.dgvcontactos.DoubleClick += new System.EventHandler(this.dgvcontactos_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "GENERO:";
            // 
            // tbgenero
            // 
            this.tbgenero.Location = new System.Drawing.Point(85, 177);
            this.tbgenero.Name = "tbgenero";
            this.tbgenero.Size = new System.Drawing.Size(160, 20);
            this.tbgenero.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DIRECCION:";
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(87, 214);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(160, 20);
            this.tbdireccion.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ESTADO:";
            // 
            // tbestado
            // 
            this.tbestado.Location = new System.Drawing.Point(85, 258);
            this.tbestado.Name = "tbestado";
            this.tbestado.Size = new System.Drawing.Size(160, 20);
            this.tbestado.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "FECHA DE NACIMIENTO:";
            // 
            // tbcumpleaño
            // 
            this.tbcumpleaño.Location = new System.Drawing.Point(151, 297);
            this.tbcumpleaño.Name = "tbcumpleaño";
            this.tbcumpleaño.Size = new System.Drawing.Size(160, 20);
            this.tbcumpleaño.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "DATOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbcumpleaño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbdireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbgenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvcontactos);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro Electronico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.DataGridView dgvcontactos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbgenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbcumpleaño;
        private System.Windows.Forms.Label label10;
    }
}

