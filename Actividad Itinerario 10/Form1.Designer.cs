namespace Actividad_Itinerario_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmpleados = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            label3 = new Label();
            txtSueldo = new TextBox();
            label4 = new Label();
            btnAgregar = new Button();
            btnConfirmarCambios = new Button();
            gpAgregar = new GroupBox();
            btnListar = new Button();
            label5 = new Label();
            txtCantidadEmpleadosLista = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            gpAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(235, 12);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(553, 335);
            dgvEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 54);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(66, 51);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(120, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(66, 80);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(120, 23);
            txtDNI.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 83);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "DNI:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(66, 109);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(120, 23);
            txtSueldo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Sueldo:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 138);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(180, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConfirmarCambios
            // 
            btnConfirmarCambios.Location = new Point(12, 236);
            btnConfirmarCambios.Name = "btnConfirmarCambios";
            btnConfirmarCambios.Size = new Size(195, 23);
            btnConfirmarCambios.TabIndex = 10;
            btnConfirmarCambios.Text = "Confirmar Cambios";
            btnConfirmarCambios.UseVisualStyleBackColor = true;
            btnConfirmarCambios.Click += btnConfirmarCambios_Click;
            // 
            // gpAgregar
            // 
            gpAgregar.Controls.Add(txtCantidadEmpleadosLista);
            gpAgregar.Controls.Add(label5);
            gpAgregar.Controls.Add(btnAgregar);
            gpAgregar.Controls.Add(label4);
            gpAgregar.Controls.Add(txtSueldo);
            gpAgregar.Controls.Add(label3);
            gpAgregar.Controls.Add(txtDNI);
            gpAgregar.Controls.Add(txtApellido);
            gpAgregar.Controls.Add(label2);
            gpAgregar.Controls.Add(txtNombre);
            gpAgregar.Controls.Add(label1);
            gpAgregar.Location = new Point(12, 12);
            gpAgregar.Name = "gpAgregar";
            gpAgregar.Size = new Size(195, 209);
            gpAgregar.TabIndex = 11;
            gpAgregar.TabStop = false;
            gpAgregar.Text = "Agregar Empleados";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(17, 278);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(195, 23);
            btnListar.TabIndex = 12;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 183);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 10;
            label5.Text = "Empleados en la lista:";
            // 
            // txtCantidadEmpleadosLista
            // 
            txtCantidadEmpleadosLista.Enabled = false;
            txtCantidadEmpleadosLista.Location = new Point(134, 180);
            txtCantidadEmpleadosLista.Name = "txtCantidadEmpleadosLista";
            txtCantidadEmpleadosLista.Size = new Size(55, 23);
            txtCantidadEmpleadosLista.TabIndex = 11;
            txtCantidadEmpleadosLista.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListar);
            Controls.Add(gpAgregar);
            Controls.Add(btnConfirmarCambios);
            Controls.Add(dgvEmpleados);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            gpAgregar.ResumeLayout(false);
            gpAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label label3;
        private TextBox txtSueldo;
        private Label label4;
        private Button btnAgregar;
        private Button btnConfirmarCambios;
        private GroupBox gpAgregar;
        private Button btnListar;
        private TextBox txtCantidadEmpleadosLista;
        private Label label5;
    }
}
