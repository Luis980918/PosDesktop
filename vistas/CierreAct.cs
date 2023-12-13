using PosDesktop.controller;
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

namespace PosDesktop
{
    public partial class CierreAct : Form
    {

        CierreController cierreController = new CierreController();
        DespachoController despachoController = new DespachoController();
        Cierre cierreActualizar = null;
        Form1 form1;

        public CierreAct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pagoTrabajadorasTextBox.Text != "" && ahorroTextBox.Text != "" &&
                totalBaseTextBox.Text != "" && totalCierreTextBox.Text != "")
            {
                decimal totalTrabajadoras = 0;
                decimal totalAhorro = 0;
                decimal totalBase = 0;

                if (decimal.TryParse(pagoTrabajadorasTextBox.Text, out totalTrabajadoras) &&
                    decimal.TryParse(ahorroTextBox.Text, out totalAhorro) &&
                    decimal.TryParse(totalBaseTextBox.Text, out totalBase))
                {
                    cierreActualizar.pagoTrabajadoras = totalTrabajadoras;
                    cierreActualizar.ahorro = totalAhorro;
                    cierreActualizar.totalBase = totalBase;
                    cierreActualizar.totalEnCaja = cierreActualizar.totalCierre - (totalTrabajadoras + totalAhorro + totalBase);
                    cierreActualizar.fecha = DateTime.Today;
                    form1.actualizar(cierreActualizar);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cierre, revise los datos");
                }
            } else
            {
                MessageBox.Show("No se pudo actualizar el cierre, revise los datos");
            }
            Close();
        }

        public void setCierre(int id, Form1 form1)
        {
            List<Despacho> movimientosDia = despachoController.Search(DateTime.Today, DateTime.Today.AddDays(1));
            Decimal pagoTotal = movimientosDia.Select(mov => mov.pagoTotal).DefaultIfEmpty().Sum();

            this.cierreActualizar = cierreController.SearchById(id);
            this.cierreActualizar.totalCierre = pagoTotal;
            totalBaseTextBox.Text = this.cierreActualizar.totalBase.ToString();
            pagoTrabajadorasTextBox.Text = this.cierreActualizar.pagoTrabajadoras.ToString();
            ahorroTextBox.Text = this.cierreActualizar.ahorro.ToString();
            totalCierreTextBox.Text = pagoTotal.ToString();
            this.form1 = form1;
        }

        private void CierreAct_Load(object sender, EventArgs e)
        {

        }

        private void totalBaseTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(totalBaseTextBox.Text, out decimal value))
            {
                totalBaseTextBox.Text = value.ToString("N0");
                totalBaseTextBox.SelectionStart = totalBaseTextBox.Text.Length;
            }
        }

        private void pagoTrabajadorasTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(pagoTrabajadorasTextBox.Text, out decimal value))
            {
                pagoTrabajadorasTextBox.Text = value.ToString("N0");
                pagoTrabajadorasTextBox.SelectionStart = pagoTrabajadorasTextBox.Text.Length;
            }
        }

        private void ahorroTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(ahorroTextBox.Text, out decimal value))
            {
                ahorroTextBox.Text = value.ToString("N0");
                ahorroTextBox.SelectionStart = ahorroTextBox.Text.Length;
            }
        }

        private void totalCierreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(totalCierreTextBox.Text, out decimal value))
            {
                totalCierreTextBox.Text = value.ToString("N0");
                totalCierreTextBox.SelectionStart = totalCierreTextBox.Text.Length;
            }
        }

        private void pagoTrabajadorasTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (pagoTrabajadorasTextBox.Text != ""))
            {
                ahorroTextBox.Focus();
            }
        }

        private void ahorroTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (ahorroTextBox.Text != ""))
            {
                totalBaseTextBox.Focus();
            }
        }
    }
}
