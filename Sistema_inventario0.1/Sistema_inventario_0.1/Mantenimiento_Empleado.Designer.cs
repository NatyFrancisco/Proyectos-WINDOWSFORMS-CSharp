
namespace Sistema_inventario_0._1
{
    partial class Mantenimiento_Empleado
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
            this.tFecha = new System.Windows.Forms.DateTimePicker();
            this.fecha_nacimiento = new System.Windows.Forms.Label();
            this.nuevo = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.registrar = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Direccion = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.tEdad = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.tCedula = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tFecha
            // 
            this.tFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tFecha.Location = new System.Drawing.Point(210, 392);
            this.tFecha.Name = "tFecha";
            this.tFecha.Size = new System.Drawing.Size(129, 22);
            this.tFecha.TabIndex = 100;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.AutoSize = true;
            this.fecha_nacimiento.Location = new System.Drawing.Point(61, 392);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(143, 17);
            this.fecha_nacimiento.TabIndex = 99;
            this.fecha_nacimiento.Text = "Fecha de nacimiento:";
            // 
            // nuevo
            // 
            this.nuevo.BackColor = System.Drawing.Color.LightPink;
            this.nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevo.Location = new System.Drawing.Point(368, 590);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(92, 28);
            this.nuevo.TabIndex = 98;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.LightPink;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.Location = new System.Drawing.Point(259, 590);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(92, 28);
            this.eliminar.TabIndex = 97;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.Color.LightPink;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Location = new System.Drawing.Point(144, 590);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(92, 28);
            this.modificar.TabIndex = 96;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.Color.LightPink;
            this.registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrar.Location = new System.Drawing.Point(40, 590);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(92, 28);
            this.registrar.TabIndex = 95;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(664, 45);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 17);
            this.linkLabel2.TabIndex = 93;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Inicio";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(591, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 17);
            this.linkLabel1.TabIndex = 92;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Acceso";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(61, 433);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(71, 17);
            this.Direccion.TabIndex = 91;
            this.Direccion.Text = "Direccion:";
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(144, 428);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(242, 22);
            this.tDireccion.TabIndex = 90;
            // 
            // tEdad
            // 
            this.tEdad.Location = new System.Drawing.Point(144, 347);
            this.tEdad.Name = "tEdad";
            this.tEdad.Size = new System.Drawing.Size(150, 22);
            this.tEdad.TabIndex = 89;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(144, 474);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(242, 22);
            this.tEmail.TabIndex = 88;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(60, 479);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 17);
            this.email.TabIndex = 87;
            this.email.Text = "E-mail:";
            // 
            // tCedula
            // 
            this.tCedula.Location = new System.Drawing.Point(144, 299);
            this.tCedula.Name = "tCedula";
            this.tCedula.Size = new System.Drawing.Size(150, 22);
            this.tCedula.TabIndex = 86;
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(144, 257);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(242, 22);
            this.tApellido.TabIndex = 85;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(144, 206);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(242, 22);
            this.tNombre.TabIndex = 84;
            // 
            // cedula
            // 
            this.cedula.AutoSize = true;
            this.cedula.Location = new System.Drawing.Point(60, 304);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(56, 17);
            this.cedula.TabIndex = 83;
            this.cedula.Text = "Cedula:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(55, 206);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(69, 17);
            this.nombre.TabIndex = 82;
            this.nombre.Text = "Nombres:";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(55, 257);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(69, 17);
            this.apellido.TabIndex = 81;
            this.apellido.Text = "Apellidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Edad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label15.Location = new System.Drawing.Point(53, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(286, 29);
            this.label15.TabIndex = 78;
            this.label15.Text = "Registro de empleados";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(752, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 110;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(12, 45);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(43, 17);
            this.lblfecha.TabIndex = 116;
            this.lblfecha.Text = "fecha";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(12, 18);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(37, 17);
            this.lblhora.TabIndex = 115;
            this.lblhora.Text = "hora";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Sistema_inventario_0._1.Properties.Resources.Blanco;
            this.pictureBox2.Location = new System.Drawing.Point(667, 544);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(475, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 28);
            this.button2.TabIndex = 117;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mantenimiento_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 720);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tFecha);
            this.Controls.Add(this.fecha_nacimiento);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.tEdad);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.tCedula);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label15);
            this.Name = "Mantenimiento_Empleado";
            this.Text = "Mantenimiento_Empleado";
            this.Load += new System.EventHandler(this.Mantenimiento_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tFecha;
        private System.Windows.Forms.Label fecha_nacimiento;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.TextBox tEdad;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox tCedula;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label cedula;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Button button2;
    }
}