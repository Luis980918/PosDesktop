using facturaC_;
using PosDesktop.context;
using PosDesktop.controller;
using PosDesktop.model;
using PosDesktop.vistas;
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
        CierreController cierreController = new CierreController();
        SeparadoController separadoController = new SeparadoController();
        AbonoController abonoController = new AbonoController();

        List<Despacho> movimientosDia = new List<Despacho>();
        List<Separado> Separados = new List<Separado>();
        List<Cierre> cierresTotal = new List<Cierre>();

        public Form1()
        {
            InitializeComponent();
            inicializarGridCierre();
            inicializarGridMovimientos();
            inicializarGridSeparados();
        }

        public void inicializarGridCierre()
        {
            for (int i = 1; i < 6; i++) // Comienza desde la columna 1
            {
                cierreDataGridView.Columns[i].DefaultCellStyle.Format = "C0"; // Formato de moneda sin decimales
                cierreDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinear a la derecha
            }

            // Opcionalmente, para cambiar el formato de los encabezados de las columnas 2 a 6:
            for (int i = 1; i < 6; i++)
            {
                cierreDataGridView.Columns[i].HeaderCell.Style.Font = new Font(cierreDataGridView.Font, FontStyle.Bold);
            }
        }

        public void inicializarGridMovimientos()
        {
            for (int i = 1; i < 4; i++) // Comienza desde la columna 1
            {
                despachoDataGridView.Columns[i].DefaultCellStyle.Format = "C0"; // Formato de moneda sin decimales
                despachoDataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinear a la derecha
            }

            // Opcionalmente, para cambiar el formato de los encabezados de las columnas 2 a 6:
            for (int i = 1; i < 4; i++)
            {
                despachoDataGridView.Columns[i].HeaderCell.Style.Font = new Font(despachoDataGridView.Font, FontStyle.Bold);
            }
        }

        public void inicializarGridSeparados()
        {
            separadoDataGridView.Columns[3].DefaultCellStyle.Format = "C0"; // Formato de moneda sin decimales
            separadoDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinear a la derecha

            separadoDataGridView.Columns[4].DefaultCellStyle.Format = "C0"; // Formato de moneda sin decimales
            separadoDataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinear a la derecha

            separadoDataGridView.Columns[3].HeaderCell.Style.Font = new Font(separadoDataGridView.Font, FontStyle.Bold);
            separadoDataGridView.Columns[3].HeaderCell.Style.Font = new Font(separadoDataGridView.Font, FontStyle.Bold);
            separadoDataGridView.Columns[4].HeaderCell.Style.Font = new Font(separadoDataGridView.Font, FontStyle.Bold);
            separadoDataGridView.Columns[4].HeaderCell.Style.Font = new Font(separadoDataGridView.Font, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModelVentas db = new ModelVentas();
            var despachos = db.Despachos.ToList();
            var ventas = db.Ventas.ToList();
            var cierres = db.Cierres.ToList();
            var separados = db.Separados.ToList();

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
            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                realizarVenta();
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
            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                realizarVenta();
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
            realizarVenta();
        }

        private void realizarVenta()
        {
            if (totalPagar > 0)
            {
                MessageTextPos messageText = new MessageTextPos(this);
                messageText.setTitulo("¿Cuanto dinero recibiste?");
                messageText.setTxtDevolver("0");
                /*Microsoft.VisualBasic.Interaction.InputBox("¿Cuanto dinero recibiste?", "Total", "0");*/
                messageText.Show();
            } else
            {
                MessageBoxPos message = new MessageBoxPos();
                message.setTitulo("¡Alerta!");
                message.setMensaje("Debe haber por lo menos un\nartículo para realizar la venta");
                message.Show();
            }
        }

        public void continuarCompra(string input) {
            /*MyForm myForm = new MyForm();
            myForm.ShowDialog();*/
            decimal valorDevolver = 0;

            if (input != null && (input != "0" && decimal.TryParse(input, out valorDevolver)))
            {
                decimal devuelta = valorDevolver - totalPagar;
                despacho.pagoTotal = totalPagar;
                despacho.fechaMovimiento = DateTime.Now;
                despacho.totalRecibido = valorDevolver;
                despacho.totalDevuelto = devuelta;
                despacho.ventas = detalleVentas;
                Despacho despachoCreado = despachoController.Create(despacho);
                MessageBoxPos messageBoxPos = new MessageBoxPos(this);
                messageBoxPos.setTitulo("Total a devolver:");
                messageBoxPos.setMensaje(devuelta.ToString("C0"));
                messageBoxPos.Show();

            }
            else if (input == "0" && decimal.TryParse(input, out valorDevolver))
            {
                despacho.pagoTotal = totalPagar;
                despacho.fechaMovimiento = DateTime.Now;
                despacho.totalRecibido = totalPagar;
                despacho.totalDevuelto = 0;
                despacho.ventas = detalleVentas;
                Despacho despachoCreado = despachoController.Create(despacho);
                if (chkImprimirDocumento.Checked && despachoCreado != null)
                {
                    ImprimirDocumentoFactura imprimirDocumentoFactura = new ImprimirDocumentoFactura(despachoCreado, this);
                    imprimirDocumentoFactura.Show();
                }
                limpiarCampos();
                limpiarTodo();
            }
        }

        public void finalizarVenta()
        {
            limpiarCampos();
            limpiarTodo();
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
            panelGeneral.Visible = false;
            panelCierreCaja.Visible = true;
            panelMovimientos.Visible = false;
            panelPises.Visible = false;
            fechaInicialCierre.Value = DateTime.Today;
            fechaFinalCierre.Value = DateTime.Today;

            List<Cierre> cierresExistentes = cierreController.SearchByToday();

            if (cierresExistentes.Count > 0)
            {
                txtTrabajadoras.Enabled = false;
                txtAhorro.Enabled   = false;
                txtBase.Enabled = false;
                MessageBox.Show("Ya existe un cierre para el día de hoy, debe actualizar los datos si considera que hay una equivocación");
            }

            cierreDataGridView.Refresh();
            cierreBindingSource.DataSource = cierreController.GetCierres();
            cierreDataGridView.Refresh();
            movimientosDia = despachoController.Search(DateTime.Today, DateTime.Today.AddDays(1));


            Decimal pagoTotal = movimientosDia.Select(mov => mov.pagoTotal).DefaultIfEmpty().Sum();
            txtTotalCierre.Text = pagoTotal.ToString();
            txtTotalCierre.Enabled = false;
            cierreBindingSource.ResetBindings(false);
            
            cierreDataGridView.Refresh();
            cierreBindingSource.DataSource = cierreController.GetCierres();
            cierreBindingSource.ResetBindings(false);
            cierreDataGridView.Refresh();
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void movimientos_Click(object sender, EventArgs e)
        {
            panelMovimientos.Visible = true;
            panelGeneral.Visible = false;
            panelCierreCaja.Visible = false;
            panelPises.Visible = false;
            fechaInicio.Value = DateTime.Today;
            fechaFin.Value = DateTime.Today;
            DateTime fechaInicial = fechaInicio.Value;
            DateTime fechaFinal = fechaFin.Value;
            despachoBindingSource.DataSource = despachoController.Search(fechaInicial.Date, fechaFinal.Date.AddDays(1));
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal value))
            {
                textBox1.Text = value.ToString("N0");
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            panelGeneral.Visible = true;
            panelCierreCaja.Visible = false;
            panelMovimientos.Visible = false;
            panelPises.Visible = false;
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
            if (decimal.TryParse(textBox2.Text, out decimal value))
            {
                textBox2.Text = value.ToString("N0");
                textBox2.SelectionStart = textBox2.Text.Length;

            }
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

        private void cierreDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (txtTrabajadoras.Text != "" && txtAhorro.Text != "" && 
                txtBase.Text != "" && txtTotalCierre.Text != "") {
                decimal totalTrabajadoras = 0;
                decimal totalAhorro = 0;
                decimal totalBase = 0;
                decimal totalCierre = 0;
                if (decimal.TryParse(txtTrabajadoras.Text, out totalTrabajadoras) &&
                    decimal.TryParse(txtAhorro.Text, out totalAhorro) &&
                    decimal.TryParse(txtBase.Text, out totalBase) &&
                    decimal.TryParse(txtTotalCierre.Text, out totalCierre)) {
                    Cierre cierre = new Cierre();
                    cierre.pagoTrabajadoras = totalTrabajadoras;
                    cierre.ahorro = totalAhorro;
                    cierre.totalBase = totalBase;
                    cierre.totalEnCaja = totalCierre - (totalTrabajadoras + totalAhorro + totalBase); 
                    cierre.totalCierre = totalCierre;
                    cierre.fecha = DateTime.Today;
                    cierreController.Create(cierre);
                    
                    cierreBindingSource.DataSource = cierreController.GetCierres();
                    cierreDataGridView.Refresh();
                    txtTrabajadoras.Text = "";
                    txtAhorro.Text = "";
                    txtBase.Text = "";
                    txtTrabajadoras.Enabled = false;
                    txtAhorro.Enabled = false;
                    txtBase.Enabled = false;
                    }
            } else
            {
                MessageBox.Show("No se puede cerrar el día si falta algún dato o hay información errónea");
            }
        }

        public void actualizar(Cierre cierre)
        {
            cierreController.Update(cierre);
            cierreBindingSource.DataSource = cierreController.GetCierres();
            cierreDataGridView.Refresh();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string fecha = cierreDataGridView.CurrentRow.Cells[6].Value.ToString();
            DateTime fechaAct;

            if (DateTime.TryParse(fecha, out fechaAct))
            {
                fechaAct = fechaAct.Date; // Establecer la hora al inicio del día
                if ((cierreDataGridView.RowCount > 1) && DateTime.Today == fechaAct)
                {
                    CierreAct cierreAct = new CierreAct();
                    String id = cierreDataGridView.CurrentRow.Cells[0].Value.ToString();
                    int codigo = 0;
                    if (id != "" && int.TryParse(id, out codigo))
                    {
                        cierreAct.setCierre(codigo, this);
                        cierreAct.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra seleccionado ningún cierre");
                    }
                }
                else
                {
                    MessageBox.Show("Solo se puede actualizar un cierre si es del día actual");
                }
            }
            else
            {
                MessageBox.Show("La fecha no es válida.");
            }

        }

        private void txtTrabajadoras_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTrabajadoras.Text, out decimal value))
            {
                txtTrabajadoras.Text = value.ToString("N0");
                txtTrabajadoras.SelectionStart = txtTrabajadoras.Text.Length;

            }
        }

        private void txtAhorro_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAhorro.Text, out decimal value))
            {
                txtAhorro.Text = value.ToString("N0");
                txtAhorro.SelectionStart = txtAhorro.Text.Length;

            }
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBase.Text, out decimal value))
            {
                txtBase.Text = value.ToString("N0");
                txtBase.SelectionStart = txtBase.Text.Length;
            }
        }

        private void txtTotalCierre_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTotalCierre.Text, out decimal value))
            {
                txtTotalCierre.Text = value.ToString("N0");
                txtTotalCierre.SelectionStart = txtTotalCierre.Text.Length;
            }
        }

        private void panelCierreCaja_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTrabajadoras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (txtTrabajadoras.Text != ""))
            {
                txtAhorro.Focus();
            }
        }

        private void txtAhorro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (txtAhorro.Text != ""))
            {
                txtBase.Focus();
            }
        }

        private void txtBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (txtBase.Text != ""))
            {
                txtTotalCierre.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = fechaInicialCierre.Value.Date;
            DateTime fechaFinal = fechaFinalCierre.Value;
            if (fechaInicial > fechaFinal)
            {
                MessageBox.Show("La fecha inicial debe ser menor o igual que la fecha final");
            }
            else
            {
                cierresTotal = cierreController.Search(fechaInicial, fechaFinal);

                Decimal totalFecha = cierresTotal.Select(mov => mov.totalEnCaja).DefaultIfEmpty().Sum();
                MessageBoxPos mensaje = new MessageBoxPos();
                mensaje.setTitulo("Total: ");
                mensaje.setMensaje(totalFecha.ToString("C0"));
                mensaje.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            limpiarTodo();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelMovimientos.Visible = false;
            panelGeneral.Visible = false;
            panelCierreCaja.Visible = false;
            panelPises.Visible = true;

            consultarSeparados();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelPises_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            SeparadoAct separadoAct = new SeparadoAct(this);
            separadoAct.Show();
        }

        internal void consultarSeparados()
        {
            separadoDataGridView.Refresh();
            separadoBindingSource.DataSource = null;
            separadoBindingSource.DataSource = separadoController.GetSeparados();
            separadoDataGridView.Refresh();
            filtroFechaSeparado.Value = DateTime.Today;
        }

        public void actualizarSeparados(Separado separado)
        {
            abonoController.CreateList(separado.abonos);

            separadoController.Update(separado);
            separadoDataGridView.Refresh();
            generarMensaje(separado);
            consultarSeparados();
        }

        private void generarMensaje(Separado separado)
        {
            MessageBoxPos messageBoxPos = new MessageBoxPos();
            messageBoxPos.setTitulo("Aviso");
            if (separado.restante == 0)
            {
                messageBoxPos.setMensaje("¡Separado finalizado!");
            }
            else
            {
                messageBoxPos.setMensaje("¡Abonado exitosamente!");
            }
            messageBoxPos.Show();
        }

        private void separadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscarSeparados();
        }

        private void buscarSeparados()
        {
            separadoBindingSource.DataSource = separadoController.SearchByAllFilters(filtroFechaSeparado.Value, DateTime.UtcNow.AddDays(1), filtroClienteSeparado.Text);
            cierreDataGridView.Refresh();
        }

        private void filtroClienteSeparado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarSeparados();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (separadoDataGridView.RowCount > 1)
            {
                String id = separadoDataGridView.CurrentRow.Cells[0].Value.ToString();
                String restante = separadoDataGridView.CurrentRow.Cells[4].Value.ToString();
                int codigo = 0;
                decimal totalRestante = 0;
                if (decimal.TryParse(restante, out totalRestante) && totalRestante != 0)
                {
                    if (id != "" && int.TryParse(id, out codigo))
                    {
                        SeparadoAct separadoAct = new SeparadoAct(this, codigo);
                        separadoAct.Show();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un separado para ingresar un abono");
                    }
                }
                else
                {
                    MessageBox.Show("Solo puede realizar un abono cuando el separado tiene saldo pendiente");
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un separado para ingresar un abono");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (separadoDataGridView.RowCount > 1)
            {
                String id = separadoDataGridView.CurrentRow.Cells[0].Value.ToString();
                int codigo = 0;
                if (id != "" && int.TryParse(id, out codigo))
                {
                    AbonosVista abonos = new AbonosVista();
                    abonos.obtenerAbonos(codigo);
                    abonos.Show();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un separado para visualizar los abonos");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un separado para visualizar los abonos");
            }
        }

        private void chkImprimirDocumento_CheckedChanged(object sender, EventArgs e)
        {

        }

        internal void reiniciarCheck()
        {
            chkImprimirDocumento.Checked = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String id = despachoDataGridView.CurrentRow.Cells[0].Value.ToString();
            int codigo = 0;

            if (id != null && int.TryParse(id, out codigo))
            {
                Despacho despacho = despachoController.SearchById(codigo);
                List<Venta> ventas = ventaController.SearchByDespacho(codigo);
                despacho.ventas = ventas;
                if (despacho != null)
                {
                    ImprimirDocumentoFactura imprimirDocumentoFactura = new ImprimirDocumentoFactura(despacho, this);
                    imprimirDocumentoFactura.Show();
                }
            } else
            {
                MessageBoxPos message = new MessageBoxPos();
                message.setTitulo("¡Alerta!");
                message.setMensaje("Debe seleccionar una venta para continuar");
                message.Show();
            }
        }
    }
}
