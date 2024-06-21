namespace PosDesktop.vistas
{
    partial class SeparadoAct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeparadoAct));
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtArticulos = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.costoTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.articulos = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.txtRestante = new System.Windows.Forms.TextBox();
            this.restante = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.abono = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(194, 265);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(143, 24);
            this.txtValorTotal.TabIndex = 56;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged_1);
            this.txtValorTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorTotal_KeyDown_1);
            // 
            // txtArticulos
            // 
            this.txtArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulos.Location = new System.Drawing.Point(194, 187);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(143, 24);
            this.txtArticulos.TabIndex = 54;
            this.txtArticulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulos_KeyDown);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(194, 144);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(143, 24);
            this.txtCliente.TabIndex = 53;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // costoTotal
            // 
            this.costoTotal.AutoSize = true;
            this.costoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoTotal.ForeColor = System.Drawing.Color.Blue;
            this.costoTotal.Location = new System.Drawing.Point(65, 264);
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.Size = new System.Drawing.Size(97, 20);
            this.costoTotal.TabIndex = 51;
            this.costoTotal.Text = "Valor total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(65, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Fecha:";
            // 
            // articulos
            // 
            this.articulos.AutoSize = true;
            this.articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulos.ForeColor = System.Drawing.Color.Blue;
            this.articulos.Location = new System.Drawing.Point(65, 188);
            this.articulos.Name = "articulos";
            this.articulos.Size = new System.Drawing.Size(84, 20);
            this.articulos.TabIndex = 49;
            this.articulos.Text = "Artículos:";
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.ForeColor = System.Drawing.Color.Blue;
            this.cliente.Location = new System.Drawing.Point(65, 143);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(70, 20);
            this.cliente.TabIndex = 48;
            this.cliente.Text = "Cliente:";
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(194, 228);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(143, 24);
            this.fecha.TabIndex = 57;
            this.fecha.Value = new System.DateTime(2023, 12, 11, 18, 42, 21, 0);
            this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
            this.fecha.LocationChanged += new System.EventHandler(this.fecha_LocationChanged);
            this.fecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fecha_LocationChanged);
            // 
            // txtRestante
            // 
            this.txtRestante.Enabled = false;
            this.txtRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestante.Location = new System.Drawing.Point(194, 345);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.Size = new System.Drawing.Size(143, 24);
            this.txtRestante.TabIndex = 59;
            this.txtRestante.TextChanged += new System.EventHandler(this.txtRestante_TextChanged);
            // 
            // restante
            // 
            this.restante.AutoSize = true;
            this.restante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restante.ForeColor = System.Drawing.Color.Blue;
            this.restante.Location = new System.Drawing.Point(65, 346);
            this.restante.Name = "restante";
            this.restante.Size = new System.Drawing.Size(88, 20);
            this.restante.TabIndex = 58;
            this.restante.Text = "Restante:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(69, 396);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(268, 53);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(82, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(243, 92);
            this.label17.TabIndex = 60;
            this.label17.Text = "Separados";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(194, 302);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(143, 24);
            this.txtAbono.TabIndex = 62;
            this.txtAbono.TextChanged += new System.EventHandler(this.txtAbono_TextChanged);
            this.txtAbono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAbono_KeyDown);
            // 
            // abono
            // 
            this.abono.AutoSize = true;
            this.abono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abono.ForeColor = System.Drawing.Color.Blue;
            this.abono.Location = new System.Drawing.Point(65, 303);
            this.abono.Name = "abono";
            this.abono.Size = new System.Drawing.Size(66, 20);
            this.abono.TabIndex = 61;
            this.abono.Text = "Abono:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(304, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 37);
            this.button2.TabIndex = 63;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SeparadoAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.abono);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRestante);
            this.Controls.Add(this.restante);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtArticulos);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.costoTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.articulos);
            this.Controls.Add(this.cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeparadoAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separados";
            this.Load += new System.EventHandler(this.SeparadoAct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtArticulos;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label costoTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label articulos;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox txtRestante;
        private System.Windows.Forms.Label restante;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label abono;
        private System.Windows.Forms.Button button2;
    }
}