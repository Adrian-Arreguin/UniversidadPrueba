
namespace UniversidadExamen.Presentation
{
    partial class Form1
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
            this.Nombre = new System.Windows.Forms.Label();
            this.ApellidoP = new System.Windows.Forms.Label();
            this.ApellidoM = new System.Windows.Forms.Label();
            this.Matricula = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(35, 9);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(58, 17);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // ApellidoP
            // 
            this.ApellidoP.AutoSize = true;
            this.ApellidoP.Location = new System.Drawing.Point(35, 42);
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.Size = new System.Drawing.Size(112, 17);
            this.ApellidoP.TabIndex = 1;
            this.ApellidoP.Text = "Apellido Paterno";
            // 
            // ApellidoM
            // 
            this.ApellidoM.AutoSize = true;
            this.ApellidoM.Location = new System.Drawing.Point(35, 81);
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.Size = new System.Drawing.Size(114, 17);
            this.ApellidoM.TabIndex = 2;
            this.ApellidoM.Text = "Apellido Materno";
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Location = new System.Drawing.Point(35, 122);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(65, 17);
            this.Matricula.TabIndex = 3;
            this.Matricula.Text = "Matricula";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(35, 166);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(98, 17);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fecha Ingreso";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(35, 205);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(35, 241);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(64, 17);
            this.Telefono.TabIndex = 6;
            this.Telefono.Text = "Telefono";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(153, 42);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(234, 22);
            this.txtP.TabIndex = 8;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(155, 78);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(234, 22);
            this.txtM.TabIndex = 9;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(106, 122);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(234, 22);
            this.txtMatricula.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(106, 241);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(234, 22);
            this.txtTel.TabIndex = 13;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(498, 282);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(198, 52);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "Guardar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 346);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.ApellidoM);
            this.Controls.Add(this.ApellidoP);
            this.Controls.Add(this.Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label ApellidoP;
        private System.Windows.Forms.Label ApellidoM;
        private System.Windows.Forms.Label Matricula;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.Button Button1;
    }
}