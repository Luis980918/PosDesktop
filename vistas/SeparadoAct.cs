using PosDesktop.controller;
using PosDesktop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PosDesktop.vistas
{
    public partial class SeparadoAct : Form
    {
        SeparadoController separadoController = new SeparadoController();
        DespachoController despachoController = new DespachoController();

        Separado separado = null;
        int idSeparado;
        Boolean crear = true;
        Form1 form1;
        decimal valorRestante = 0;
        decimal VALOR_MINIMO_SEPARADO = 20000;

        public SeparadoAct(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
            fecha.Value = DateTime.Today;
        }
        public SeparadoAct(Form1 form1, int idSeparado)
        {
            InitializeComponent();

            this.form1 = form1;
            fecha.Value = DateTime.Today;
            this.idSeparado = idSeparado;

            setSeparado(idSeparado);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (!decimal.TryParse(txtValorTotal.Text, out valor))
            {
                MessageBox.Show("La columna valor total no posee un número decimal válido.");
            } else if (!decimal.TryParse(txtRestante.Text, out valor))
            {
                MessageBox.Show("La columna valor restante total no posee un número decimal válido.");
            }
            else if (!decimal.TryParse(txtAbono.Text, out valor))
            {
                btnGuardar.Enabled = false;
                MessageBox.Show("La columna abono no posee un número decimal válido.");
            }
            else if (decimal.TryParse(txtAbono.Text, out valor) && 
                (valor < VALOR_MINIMO_SEPARADO) && 
                crear == true)
            {
                btnGuardar.Enabled = false;
                MessageBox.Show("Debe abonar almenos $20.000");
            }
            else
            {
                if (txtCliente.Text != "" && txtArticulos.Text != "" &&
                fecha.Text != "" && txtAbono.Text != "" && txtRestante.Text != "" && 
                txtValorTotal.Text != "")
                {
                    decimal valorTotal = 0;
                    decimal valorRestante = 0;
                    decimal abono = 0;
                    decimal.TryParse(txtValorTotal.Text, out valorTotal);
                    decimal.TryParse(txtRestante.Text, out valorRestante);
                    decimal.TryParse(txtAbono.Text, out abono);



                    if (crear)
                    {
                        Abono abonoCrear = new Abono();
                        abonoCrear.fechaPago = DateTime.Now;
                        abonoCrear.valorAbono = abono;
                        separado = new Separado();

                        separado.cliente = txtCliente.Text;
                        separado.articulos = txtArticulos.Text;
                        separado.fecha = fecha.Value;
                        separado.costoTotal = valorTotal;
                        separado.restante = valorTotal - abono;
                        

                        Despacho despacho = new Despacho();
                        despacho.pagoTotal = abono;
                        despacho.fechaMovimiento = DateTime.Now;
                        despacho.totalRecibido = abono;
                        despacho.totalDevuelto = 0;

                        Venta venta = new Venta();
                        venta.numeroItem = 1;
                        venta.precioUnitario = abono;
                        venta.cantidad = 1;
                        List<Venta> ventas = new List<Venta>();
                        ventas.Add(venta);

                        List<Separado> separados = new List<Separado>();
                        separados.Add(separado);

                        List<Abono> abonos = new List<Abono>();
                        abonos.Add(abonoCrear);

                        separado.abonos = abonos;
                        despacho.ventas = ventas;
                        despacho.separados = separado;
                        separado.fecha = DateTime.Today;
                        Despacho despachoCrear = despachoController.Create(despacho);
                        if (despachoCrear != null)
                        {
                            MessageBoxPos messageBoxPos = new MessageBoxPos();
                            messageBoxPos.setTitulo("Aviso");
                            messageBoxPos.setMensaje("¡Separado creado exitosamente!");
                            messageBoxPos.Show();
                            this.form1.consultarSeparados();
                        }
                    } else
                    {
                        Abono abonoCrear = new Abono();
                        abonoCrear.fechaPago = DateTime.Now;
                        abonoCrear.valorAbono = abono;

                        if (this.separado.restante < abono)
                        {
                            this.separado.restante = 0;
                        } else
                        {
                            this.separado.restante = this.separado.restante - abono;
                        }


                        Despacho despacho = new Despacho();
                        despacho.pagoTotal = abono;
                        despacho.fechaMovimiento = DateTime.Now;
                        despacho.totalRecibido = abono;
                        despacho.totalDevuelto = 0;

                        Venta venta = new Venta();
                        venta.numeroItem = 1;
                        venta.precioUnitario = abono;
                        venta.cantidad = 1;
                        List<Venta> ventas = new List<Venta>();
                        ventas.Add(venta);

                        List<Separado> separados = new List<Separado>();
                        separados.Add(this.separado);

                        List<Abono> abonos = new List<Abono>();

                        abonos.Add(abonoCrear);

                        this.separado.abonos = abonos;
                        despacho.ventas = ventas;

                        List<Despacho> despachos = new List<Despacho>();
                        despachos.Add(despacho);

                        this.separado.despachos = despachos;
                        this.separado.fecha = DateTime.Today;
                        this.form1.actualizarSeparados(this.separado);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cierre, revise los datos");
                }
                Close();
            }
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRestante_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtRestante.Text, out decimal value))
            {
                txtRestante.Text = value.ToString("N0");
                txtRestante.SelectionStart = txtRestante.Text.Length;
            }
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            decimal valor = 0;
            if (decimal.TryParse(txtAbono.Text, out decimal value))
            {
                txtAbono.Text = value.ToString("N0");
                txtAbono.SelectionStart = txtAbono.Text.Length;
            } else if (txtValorTotal.Text == "" || txtValorTotal.Text == "0")
            {
                MessageBox.Show("La columna valor total debe tener un valor mayor que cero");
            } else if (!decimal.TryParse(txtValorTotal.Text, out valor))
            {
                MessageBox.Show("La columna valor total no posee un número decimal válido.");
            }
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        public void setSeparado(int id)
        {

            this.separado = separadoController.SearchById(id);
            txtArticulos.Text = this.separado.articulos.ToString();
            txtCliente.Text = this.separado.cliente.ToString();
            fecha.Value = this.separado.fecha;
            txtValorTotal.Text = separado.costoTotal.ToString();
            txtRestante.Text = separado.restante.ToString();

            txtArticulos.Enabled = false;
            txtCliente.Enabled = false;
            txtValorTotal.Enabled = false;
            txtRestante.Enabled = false;
            fecha.Enabled = false;
            this.crear = false;
            btnGuardar.Enabled = false;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (txtCliente.Text != ""))
            {
                txtArticulos.Focus();
            }
        }

        private void txtArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (fecha.Text != ""))
            {
                fecha.Focus();
            }
        }

        private void fecha_LocationChanged(object sender, EventArgs e)
        {
            txtValorTotal.Focus();
        }

        private void txtValorTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (txtValorTotal.Text != ""))
            {
                txtAbono.Focus();
            }
        }

        private void fecha_LocationChanged(object sender, KeyEventArgs e)
        {
            txtValorTotal.Focus();
        }

        private void SeparadoAct_Load(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValorTotal.Text, out decimal value))
            {
                txtValorTotal.Text = value.ToString("N0");
                txtValorTotal.SelectionStart = txtValorTotal.Text.Length;
            }
        }

        private void txtValorTotal_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (txtValorTotal.Text != ""))
            {
                txtAbono.Focus();
            }
        }

        private void txtAbono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && crear == true)
            {
                calcularValorRestante();
            } else if(e.KeyCode == Keys.Enter && crear == false)
            {
                calcularValorRestanteAct();
            }
        }

        public void calcularValorRestante()
        {
            decimal restante = 0;
            if (txtValorTotal.Text != "" && 
                txtAbono.Text != "" && 
                decimal.TryParse(txtValorTotal.Text, out decimal value) &&
                decimal.TryParse(txtAbono.Text, out decimal value2))
            {
                if (value >= value2)
                {
                    restante = value - value2;
                    txtRestante.Text = restante.ToString();
                    btnGuardar.Enabled = true;
                }
                else
                {
                    btnGuardar.Enabled = false;
                    MessageBox.Show("El valor total no puede ser menor que el valor abonado");
                }

            } else
            {
                btnGuardar.Enabled = false;
                MessageBox.Show("Deben haber valores validos en total y abono para calcular el restante");
            }
        }

        public void calcularValorRestanteAct()
        {
            decimal restante = 0;
            if (txtValorTotal.Text != "" && 
                txtAbono.Text != "" && 
                decimal.TryParse(txtValorTotal.Text, out decimal value) &&
                decimal.TryParse(txtAbono.Text, out decimal value2) && separado != null && 
                separado.restante != null)
            {
                 restante = separado.restante - value2;
                    if (restante > value2)
                    {
                        btnGuardar.Enabled = true;
                    } else
                    {
                        restante = 0;
                        decimal devuelta = value2 - separado.restante;
                        MessageBoxPos messageBoxPos = new MessageBoxPos();
                        messageBoxPos.setTitulo("Total a devolver:");
                        messageBoxPos.setMensaje(devuelta.ToString("C0"));
                        messageBoxPos.Show();
                        btnGuardar.Enabled = true;
                    }
                    txtRestante.Text = restante.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (crear == true)
            {
                calcularValorRestante();
            }
            else if (crear == false)
            {
                calcularValorRestanteAct();
            }
        }
    }
}
