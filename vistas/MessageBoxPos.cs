using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosDesktop.vistas
{
    public partial class MessageBoxPos : Form
    {
        Form1 formOrigin;
        public MessageBoxPos()
        {
            InitializeComponent();
            this.TopMost = true;  // Esto hará que tu formulario siempre esté al frente
        }

        public MessageBoxPos(Form1 formOrigin)
        {
            InitializeComponent();
            this.TopMost = true;  // Esto hará que tu formulario siempre esté al frente
            this.formOrigin = formOrigin;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void setTitulo(String titulo)
        {
            this.titulo.Text = titulo;
        }
        public void setMensaje(String mensaje)
        {
            this.mensaje.Text = mensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.formOrigin != null) {
                this.formOrigin.finalizarVenta();
            }
            this.Close();
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
