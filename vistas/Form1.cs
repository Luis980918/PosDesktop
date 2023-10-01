using PosDesktop.context;
using PosDesktop.controller;
using PosDesktop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosDesktop
{
    public partial class Form1 : Form
    {
        Venta venta = new Venta();
        int cantidadArticulos = 0;
        decimal totalPagar = 0;
        int rowSelect = 0;
        List<Venta> detalleVentas = new List<Venta>();
        Despacho despacho = new Despacho();
        VentaController ventaController = new VentaController();
        DespachoController despachoController = new DespachoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModelVentas db = new ModelVentas();
            var despachos = db.Despachos.ToList();
            var ventas = db.Ventas.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                agregarValor();
                agregarCantidad();
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (textBox1.Text != ""))
            {
                textBox2.Focus();
                textBox2.Text = "1";
                venta.cantidad = 1;
                textBox2.SelectAll();
            }
        }

        private void agregarValor()
        {
            // El usuario presionó la tecla Enter
            // Ahora, guarda la información del TextBox en la variable valorDecimal

            string texto = textBox1.Text;
            decimal valorArticulo = 0;
            if (decimal.TryParse(texto, out valorArticulo))
            {
                venta.precioUnitario = valorArticulo;
            }
            else
            {
                MessageBox.Show("Entrada no válida. Ingrese un número decimal válido.");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (textBox1.Text != "" && textBox2.Text != ""))
            {
                agregarValor();
                agregarCantidad();
            }
        }

        private void agregarCantidad()
        {
            // El usuario presionó la tecla Enter
            // Ahora, guarda la información del TextBox en la variable valorDecimal

            string texto = textBox2.Text;
            int cantidad = 0;
            if (int.TryParse(texto, out cantidad))
            {
                venta.cantidad = cantidad;
                int i = items.Rows.Add();
                cantidadArticulos++;
                decimal precioArticulo = 0;
                decimal.TryParse(textBox1.Text, out precioArticulo);
                items.Rows[i].Cells[0].Value = "Item " + (cantidadArticulos);
                items.Rows[i].Cells[1].Value = precioArticulo.ToString("N0");
                items.Rows[i].Cells[2].Value = textBox2.Text;
                items.Rows[i].Cells[3].Value = venta.precioTotal.ToString("N0");
                totalPagar = venta.precioTotal + totalPagar;
                label2.Text = "$" + totalPagar.ToString("N0");
                if (totalPagar != 0)
                {
                    btnPagar.Enabled = true;
                }
                detalleVentas.Add(venta);
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Entrada no válida. Ingrese un número decimal válido.");
            }
        }

        private void limpiarCampos()
        {
            textBox1.ResetText();
            textBox2.ResetText();
            venta = new Venta();
            textBox1.Focus();
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            rowSelect = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rowSelect != -1)
            {
                if (items.Rows[rowSelect].Cells["valorTotal"].Value != null)
                {
                    String valorEliminar = items.Rows[rowSelect].Cells["valorTotal"].Value.ToString();
                    if (valorEliminar != null)
                    {
                        totalPagar = totalPagar - decimal.Parse(valorEliminar);
                        label2.Text = "$" + totalPagar.ToString("N0");
                        if (totalPagar == 0)
                        {
                            btnPagar.Enabled = false;
                        }
                    }
                    items.Rows.RemoveAt(rowSelect);
                }
            }
        }

        private void items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal valorDevolver = 0;
            string input = Microsoft.VisualBasic.Interaction.InputBox("¿Cuanto dinero recibiste?", "Total", "0");
            /*MyForm myForm = new MyForm();
            myForm.ShowDialog();*/
            if (input != "0" && decimal.TryParse(input, out valorDevolver))
            {
                decimal devuelta = valorDevolver - totalPagar;
                MessageBox.Show("Devuelta: " + devuelta);
                despacho.pagoTotal = totalPagar;
                despacho.fechaMovimiento = DateTime.Now;
                despacho.totalRecibido = valorDevolver;
                despacho.totalDevuelto = devuelta;
                despacho.ventas = detalleVentas;
                despachoController.Create(despacho);
                limpiarCampos();
                limpiarTodo();
            }
        }

        private void limpiarTodo()
        {
            items.Rows.Clear();
            label2.Text = "$0";
            totalPagar = 0;
            cantidadArticulos = 0;
            detalleVentas = new List<Venta>();
            despacho = new Despacho();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cierre_Click(object sender, EventArgs e)
        {

        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void movimientos_Click(object sender, EventArgs e)
        {
            panelMovimientos.Visible = true;
            panelGeneral.Visible = false;
            despachoBindingSource.DataSource = despachoController.GetDespachos();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ventas_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = true;
            panelMovimientos.Visible = false;
        }

        private void items_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void panelMovimientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarMovs_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = fechaInicio.Value;
            DateTime fechaFinal = fechaFin.Value;
            if (fechaInicial > fechaFinal)
            {
                MessageBox.Show("La fecha inicial debe ser menor o igual que la fecha final");
            } else
            {
                despachoBindingSource.DataSource = despachoController.Search(fechaInicial.Date, fechaFinal.Date.AddDays(1));

            }
        }
    }
}
