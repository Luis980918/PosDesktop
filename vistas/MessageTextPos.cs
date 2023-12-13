using PosDesktop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PosDesktop.vistas
{
    public partial class MessageTextPos : Form
    {
        Form1 formOrigin;
        public MessageTextPos()
        {
            InitializeComponent();
        }

        public MessageTextPos(Form1 formOrigin)
        {
            InitializeComponent();
            this.formOrigin = formOrigin;
            this.txtDevolver.Select();
            this.txtDevolver.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void setTitulo(String mensaje)
        {
            this.titulo.Text = mensaje;
        }

        public void setTxtDevolver(String mensaje)
        {
            this.txtDevolver.Text = mensaje;
        }

        public string Result { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            continuarCompra();
        }

        public void continuarCompra()
        {
            if (this.formOrigin != null)
            {
                this.formOrigin.continuarCompra(txtDevolver.Text);
            }
            else
            {
                this.Result = txtDevolver.Text;
            }
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Result = null;
            this.Visible = false;
        }

        private void txtDevolver_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDevolver.Text, out decimal value))
            {
                txtDevolver.Text = value.ToString("N0");
                txtDevolver.SelectionStart = txtDevolver.Text.Length;
            }
        }

        private void continuarCompra(object sender, EventArgs e)
        {
            continuarCompra();
        }

        private void txtDevolver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                continuarCompra();
            }
        }
    }
}
