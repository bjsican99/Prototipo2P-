namespace CapaVista.Formularios
{
    partial class frmMateriaPrima
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
            this.lblNombremp = new System.Windows.Forms.Label();
            this.lblDescripcionmp = new System.Windows.Forms.Label();
            this.lblMarcamp = new System.Windows.Forms.Label();
            this.lblCantidadmp = new System.Windows.Forms.Label();
            this.lblPreciomp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdmp = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombremp = new System.Windows.Forms.TextBox();
            this.txtDescripcionmp = new System.Windows.Forms.TextBox();
            this.txtMarcamp = new System.Windows.Forms.TextBox();
            this.txtCantidadmp = new System.Windows.Forms.TextBox();
            this.txtPreciomp = new System.Windows.Forms.TextBox();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.rbnDesactivadomp = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombremp
            // 
            this.lblNombremp.AutoSize = true;
            this.lblNombremp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombremp.Location = new System.Drawing.Point(24, 57);
            this.lblNombremp.Name = "lblNombremp";
            this.lblNombremp.Size = new System.Drawing.Size(187, 20);
            this.lblNombremp.TabIndex = 0;
            this.lblNombremp.Text = "Nombre Materia Prima";
            // 
            // lblDescripcionmp
            // 
            this.lblDescripcionmp.AutoSize = true;
            this.lblDescripcionmp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionmp.Location = new System.Drawing.Point(333, 57);
            this.lblDescripcionmp.Name = "lblDescripcionmp";
            this.lblDescripcionmp.Size = new System.Drawing.Size(218, 20);
            this.lblDescripcionmp.TabIndex = 1;
            this.lblDescripcionmp.Text = "Descripción Materia Prima";
            // 
            // lblMarcamp
            // 
            this.lblMarcamp.AutoSize = true;
            this.lblMarcamp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcamp.Location = new System.Drawing.Point(34, 98);
            this.lblMarcamp.Name = "lblMarcamp";
            this.lblMarcamp.Size = new System.Drawing.Size(172, 20);
            this.lblMarcamp.TabIndex = 2;
            this.lblMarcamp.Text = "Marca Materia Prima";
            // 
            // lblCantidadmp
            // 
            this.lblCantidadmp.AutoSize = true;
            this.lblCantidadmp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadmp.Location = new System.Drawing.Point(17, 130);
            this.lblCantidadmp.Name = "lblCantidadmp";
            this.lblCantidadmp.Size = new System.Drawing.Size(194, 20);
            this.lblCantidadmp.TabIndex = 3;
            this.lblCantidadmp.Text = "Cantidad Materia Prima";
            // 
            // lblPreciomp
            // 
            this.lblPreciomp.AutoSize = true;
            this.lblPreciomp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreciomp.Location = new System.Drawing.Point(35, 166);
            this.lblPreciomp.Name = "lblPreciomp";
            this.lblPreciomp.Size = new System.Drawing.Size(174, 20);
            this.lblPreciomp.TabIndex = 4;
            this.lblPreciomp.Text = "Precio Materia Prima";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnDesactivadomp);
            this.groupBox1.Controls.Add(this.rbnActivo);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(336, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblIdmp
            // 
            this.lblIdmp.AutoSize = true;
            this.lblIdmp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdmp.Location = new System.Drawing.Point(85, 21);
            this.lblIdmp.Name = "lblIdmp";
            this.lblIdmp.Size = new System.Drawing.Size(98, 20);
            this.lblIdmp.TabIndex = 6;
            this.lblIdmp.Text = "Codigo No.";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(189, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(57, 20);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "label1";
            // 
            // txtNombremp
            // 
            this.txtNombremp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombremp.Location = new System.Drawing.Point(217, 54);
            this.txtNombremp.Name = "txtNombremp";
            this.txtNombremp.Size = new System.Drawing.Size(100, 27);
            this.txtNombremp.TabIndex = 8;
            // 
            // txtDescripcionmp
            // 
            this.txtDescripcionmp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionmp.Location = new System.Drawing.Point(336, 76);
            this.txtDescripcionmp.Name = "txtDescripcionmp";
            this.txtDescripcionmp.Size = new System.Drawing.Size(263, 27);
            this.txtDescripcionmp.TabIndex = 9;
            // 
            // txtMarcamp
            // 
            this.txtMarcamp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcamp.Location = new System.Drawing.Point(217, 95);
            this.txtMarcamp.Name = "txtMarcamp";
            this.txtMarcamp.Size = new System.Drawing.Size(100, 27);
            this.txtMarcamp.TabIndex = 10;
            // 
            // txtCantidadmp
            // 
            this.txtCantidadmp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadmp.Location = new System.Drawing.Point(217, 127);
            this.txtCantidadmp.Name = "txtCantidadmp";
            this.txtCantidadmp.Size = new System.Drawing.Size(101, 27);
            this.txtCantidadmp.TabIndex = 11;
            // 
            // txtPreciomp
            // 
            this.txtPreciomp.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreciomp.Location = new System.Drawing.Point(217, 163);
            this.txtPreciomp.Name = "txtPreciomp";
            this.txtPreciomp.Size = new System.Drawing.Size(100, 27);
            this.txtPreciomp.TabIndex = 12;
            // 
            // rbnActivo
            // 
            this.rbnActivo.AutoSize = true;
            this.rbnActivo.Location = new System.Drawing.Point(46, 22);
            this.rbnActivo.Name = "rbnActivo";
            this.rbnActivo.Size = new System.Drawing.Size(77, 24);
            this.rbnActivo.TabIndex = 0;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "Activo";
            this.rbnActivo.UseVisualStyleBackColor = true;
            // 
            // rbnDesactivadomp
            // 
            this.rbnDesactivadomp.AutoSize = true;
            this.rbnDesactivadomp.Location = new System.Drawing.Point(46, 48);
            this.rbnDesactivadomp.Name = "rbnDesactivadomp";
            this.rbnDesactivadomp.Size = new System.Drawing.Size(123, 24);
            this.rbnDesactivadomp.TabIndex = 1;
            this.rbnDesactivadomp.TabStop = true;
            this.rbnDesactivadomp.Text = "Desactivado";
            this.rbnDesactivadomp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(164, 208);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(98, 35);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(268, 208);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 35);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(367, 208);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 35);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(614, 411);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPreciomp);
            this.Controls.Add(this.txtCantidadmp);
            this.Controls.Add(this.txtMarcamp);
            this.Controls.Add(this.txtDescripcionmp);
            this.Controls.Add(this.txtNombremp);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIdmp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPreciomp);
            this.Controls.Add(this.lblCantidadmp);
            this.Controls.Add(this.lblMarcamp);
            this.Controls.Add(this.lblDescripcionmp);
            this.Controls.Add(this.lblNombremp);
            this.Name = "frmMateriaPrima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMateriaPrima";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombremp;
        private System.Windows.Forms.Label lblDescripcionmp;
        private System.Windows.Forms.Label lblMarcamp;
        private System.Windows.Forms.Label lblCantidadmp;
        private System.Windows.Forms.Label lblPreciomp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnDesactivadomp;
        private System.Windows.Forms.RadioButton rbnActivo;
        private System.Windows.Forms.Label lblIdmp;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombremp;
        private System.Windows.Forms.TextBox txtDescripcionmp;
        private System.Windows.Forms.TextBox txtMarcamp;
        private System.Windows.Forms.TextBox txtCantidadmp;
        private System.Windows.Forms.TextBox txtPreciomp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}