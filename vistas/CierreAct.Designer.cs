namespace PosDesktop
{
    partial class CierreAct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CierreAct));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pagoTrabajadorasTextBox = new System.Windows.Forms.TextBox();
            this.ahorroTextBox = new System.Windows.Forms.TextBox();
            this.totalBaseTextBox = new System.Windows.Forms.TextBox();
            this.totalCierreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cierreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cierreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(62, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Base:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(62, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ahorro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(62, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Trabajadoras:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(62, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Total cierre:";
            // 
            // pagoTrabajadorasTextBox
            // 
            this.pagoTrabajadorasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cierreBindingSource, "pagoTrabajadoras", true));
            this.pagoTrabajadorasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTrabajadorasTextBox.Location = new System.Drawing.Point(191, 125);
            this.pagoTrabajadorasTextBox.Name = "pagoTrabajadorasTextBox";
            this.pagoTrabajadorasTextBox.Size = new System.Drawing.Size(143, 24);
            this.pagoTrabajadorasTextBox.TabIndex = 44;
            this.pagoTrabajadorasTextBox.TextChanged += new System.EventHandler(this.pagoTrabajadorasTextBox_TextChanged);
            this.pagoTrabajadorasTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pagoTrabajadorasTextBox_KeyDown);
            // 
            // ahorroTextBox
            // 
            this.ahorroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cierreBindingSource, "ahorro", true));
            this.ahorroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ahorroTextBox.Location = new System.Drawing.Point(191, 168);
            this.ahorroTextBox.Name = "ahorroTextBox";
            this.ahorroTextBox.Size = new System.Drawing.Size(143, 24);
            this.ahorroTextBox.TabIndex = 45;
            this.ahorroTextBox.TextChanged += new System.EventHandler(this.ahorroTextBox_TextChanged);
            this.ahorroTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ahorroTextBox_KeyDown);
            // 
            // totalBaseTextBox
            // 
            this.totalBaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cierreBindingSource, "totalBase", true));
            this.totalBaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBaseTextBox.Location = new System.Drawing.Point(191, 209);
            this.totalBaseTextBox.Name = "totalBaseTextBox";
            this.totalBaseTextBox.Size = new System.Drawing.Size(143, 24);
            this.totalBaseTextBox.TabIndex = 46;
            this.totalBaseTextBox.TextChanged += new System.EventHandler(this.totalBaseTextBox_TextChanged);
            // 
            // totalCierreTextBox
            // 
            this.totalCierreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cierreBindingSource, "totalCierre", true));
            this.totalCierreTextBox.Enabled = false;
            this.totalCierreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCierreTextBox.Location = new System.Drawing.Point(191, 249);
            this.totalCierreTextBox.Name = "totalCierreTextBox";
            this.totalCierreTextBox.ReadOnly = true;
            this.totalCierreTextBox.Size = new System.Drawing.Size(143, 24);
            this.totalCierreTextBox.TabIndex = 47;
            this.totalCierreTextBox.TextChanged += new System.EventHandler(this.totalCierreTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(66, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 53);
            this.button1.TabIndex = 42;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(34, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 111);
            this.label8.TabIndex = 41;
            this.label8.Text = "Cierre de caja";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cierreBindingSource
            // 
            this.cierreBindingSource.DataSource = typeof(PosDesktop.model.Cierre);
            // 
            // CierreAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 364);
            this.Controls.Add(this.totalCierreTextBox);
            this.Controls.Add(this.totalBaseTextBox);
            this.Controls.Add(this.ahorroTextBox);
            this.Controls.Add(this.pagoTrabajadorasTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CierreAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CierreAct";
            this.Load += new System.EventHandler(this.CierreAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cierreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource cierreBindingSource;
        private System.Windows.Forms.TextBox pagoTrabajadorasTextBox;
        private System.Windows.Forms.TextBox ahorroTextBox;
        private System.Windows.Forms.TextBox totalBaseTextBox;
        private System.Windows.Forms.TextBox totalCierreTextBox;
    }
}