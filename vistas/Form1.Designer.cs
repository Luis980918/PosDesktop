using System.Windows.Forms;

namespace PosDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ventas = new System.Windows.Forms.Button();
            this.cierre = new System.Windows.Forms.Button();
            this.movimientos = new System.Windows.Forms.Button();
            this.panelPantalla = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMovimientos = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.panelMenu.Controls.Add(this.ventas);
            this.panelMenu.Controls.Add(this.cierre);
            this.panelMenu.Controls.Add(this.movimientos);
            this.panelMenu.Controls.Add(this.panelPantalla);
            this.panelMenu.Location = new System.Drawing.Point(-2, 82);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(153, 430);
            this.panelMenu.TabIndex = 10;
            // 
            // ventas
            // 
            this.ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ventas.FlatAppearance.BorderSize = 0;
            this.ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventas.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.ventas.ForeColor = System.Drawing.Color.Transparent;
            this.ventas.Image = ((System.Drawing.Image)(resources.GetObject("ventas.Image")));
            this.ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventas.Location = new System.Drawing.Point(3, 8);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(153, 39);
            this.ventas.TabIndex = 27;
            this.ventas.Text = "Ventas";
            this.ventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // cierre
            // 
            this.cierre.FlatAppearance.BorderSize = 0;
            this.cierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cierre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.cierre.ForeColor = System.Drawing.Color.Transparent;
            this.cierre.Image = ((System.Drawing.Image)(resources.GetObject("cierre.Image")));
            this.cierre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cierre.Location = new System.Drawing.Point(3, 54);
            this.cierre.Name = "cierre";
            this.cierre.Size = new System.Drawing.Size(147, 31);
            this.cierre.TabIndex = 26;
            this.cierre.Text = "Cierre caja";
            this.cierre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cierre.UseVisualStyleBackColor = true;
            this.cierre.Click += new System.EventHandler(this.cierre_Click);
            // 
            // movimientos
            // 
            this.movimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movimientos.FlatAppearance.BorderSize = 0;
            this.movimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movimientos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.movimientos.ForeColor = System.Drawing.Color.Transparent;
            this.movimientos.Image = ((System.Drawing.Image)(resources.GetObject("movimientos.Image")));
            this.movimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movimientos.Location = new System.Drawing.Point(3, 87);
            this.movimientos.Name = "movimientos";
            this.movimientos.Size = new System.Drawing.Size(153, 39);
            this.movimientos.TabIndex = 23;
            this.movimientos.Text = "Movimientos";
            this.movimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.movimientos.UseVisualStyleBackColor = true;
            this.movimientos.Click += new System.EventHandler(this.movimientos_Click);
            // 
            // panelPantalla
            // 
            this.panelPantalla.Location = new System.Drawing.Point(164, 3);
            this.panelPantalla.Name = "panelPantalla";
            this.panelPantalla.Size = new System.Drawing.Size(1065, 502);
            this.panelPantalla.TabIndex = 11;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkCyan;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.label5);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(1, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 84);
            this.panelLogo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "____________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.groupBox2);
            this.panelGeneral.Controls.Add(this.items);
            this.panelGeneral.Controls.Add(this.groupBox1);
            this.panelGeneral.Location = new System.Drawing.Point(174, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1050, 502);
            this.panelGeneral.TabIndex = 11;
            this.panelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGeneral_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Image = global::PosDesktop.Properties.Resources.demostracion_en_la_tienda2;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(47, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 57);
            this.label4.TabIndex = 22;
            this.label4.Text = "      Sistema de Ventas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Location = new System.Drawing.Point(51, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 83);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(256, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(259, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 29);
            this.textBox2.TabIndex = 7;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::PosDesktop.Properties.Resources.quitar_del_carrito;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(827, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 58);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Quitar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artículo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::PosDesktop.Properties.Resources.bolsa_de_la_compra;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(728, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 58);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // items
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.valorUnitario,
            this.cantidadArticulo,
            this.valorTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.items.DefaultCellStyle = dataGridViewCellStyle2;
            this.items.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.items.Location = new System.Drawing.Point(51, 236);
            this.items.Name = "items";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.items.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.items.Size = new System.Drawing.Size(593, 216);
            this.items.TabIndex = 20;
            // 
            // item
            // 
            this.item.HeaderText = "Artículo";
            this.item.Name = "item";
            this.item.Width = 150;
            // 
            // valorUnitario
            // 
            this.valorUnitario.HeaderText = "Valor unitario";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.Width = 150;
            // 
            // cantidadArticulo
            // 
            this.cantidadArticulo.HeaderText = "Cantidad";
            this.cantidadArticulo.Name = "cantidadArticulo";
            // 
            // valorTotal
            // 
            this.valorTotal.HeaderText = "Valor total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(696, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 174);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total venta";
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPagar.Image = global::PosDesktop.Properties.Resources.dinero2;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.Location = new System.Drawing.Point(56, 84);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(210, 75);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "$0";
            // 
            // panelMovimientos
            // 
            this.panelMovimientos.Controls.Add(this.label6);
            this.panelMovimientos.Location = new System.Drawing.Point(175, 0);
            this.panelMovimientos.Name = "panelMovimientos";
            this.panelMovimientos.Size = new System.Drawing.Size(1050, 499);
            this.panelMovimientos.TabIndex = 24;
            this.panelMovimientos.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(47, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 66);
            this.label6.TabIndex = 23;
            this.label6.Text = "Movimientos de caja";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1224, 505);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelMovimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sistema de ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMovimientos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelMenu;
        private Panel panelPantalla;
        private Panel panelLogo;
        private Panel panelGeneral;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button btnEliminar;
        private Label label1;
        private Button btnAgregar;
        private DataGridView items;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn valorUnitario;
        private DataGridViewTextBoxColumn cantidadArticulo;
        private DataGridViewTextBoxColumn valorTotal;
        private GroupBox groupBox1;
        private Button btnPagar;
        private Label label2;
        private PictureBox pictureBox1;
        private Button movimientos;
        private Label label5;
        private Button cierre;
        private Button ventas;
        private Panel panelMovimientos;
        private Label label6;
    }
}

