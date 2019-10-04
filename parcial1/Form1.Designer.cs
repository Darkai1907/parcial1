namespace parcial1
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
            this.dgtvparcial = new System.Windows.Forms.DataGridView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.txtfechanacimiento = new System.Windows.Forms.TextBox();
            this.lblfechanacimiento = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbledad = new System.Windows.Forms.Label();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lblParcial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvparcial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtvparcial
            // 
            this.dgtvparcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvparcial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.Edad,
            this.sexo,
            this.Estado});
            this.dgtvparcial.Location = new System.Drawing.Point(-1, 238);
            this.dgtvparcial.Name = "dgtvparcial";
            this.dgtvparcial.Size = new System.Drawing.Size(763, 252);
            this.dgtvparcial.TabIndex = 0;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(22, 78);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(89, 75);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(89, 123);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 4;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(22, 127);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 3;
            this.lblapellido.Text = "Apellido";
            // 
            // txtfechanacimiento
            // 
            this.txtfechanacimiento.Location = new System.Drawing.Point(323, 75);
            this.txtfechanacimiento.Name = "txtfechanacimiento";
            this.txtfechanacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtfechanacimiento.TabIndex = 6;
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.Location = new System.Drawing.Point(212, 78);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblfechanacimiento.TabIndex = 5;
            this.lblfechanacimiento.Text = "Fecha Nacimiento";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(323, 124);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 8;
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(231, 126);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 7;
            this.lbledad.Text = "Edad";
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(495, 75);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(100, 20);
            this.txtsexo.TabIndex = 10;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(451, 78);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 9;
            this.lblsexo.Text = "Sexo";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(495, 124);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(100, 20);
            this.txtestado.TabIndex = 12;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(442, 127);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 11;
            this.lblestado.Text = "Estado";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(155, 191);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(395, 191);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Location = new System.Drawing.Point(281, 24);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(52, 13);
            this.lblParcial.TabIndex = 15;
            this.lblParcial.Text = "PARCIAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(633, 435);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.txtfechanacimiento);
            this.Controls.Add(this.lblfechanacimiento);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.dgtvparcial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "forma";
            ((System.ComponentModel.ISupportInitialize)(this.dgtvparcial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtvparcial;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox txtfechanacimiento;
        private System.Windows.Forms.Label lblfechanacimiento;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lblParcial;
    }
}

