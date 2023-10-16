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

namespace PosDesktop
{
    public partial class CierreAct : Form
    {

        CierreController cierreController = new CierreController();
        Cierre cierreActualizar = null;

        public CierreAct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTrabajadoras.Text != "" && txtAhorro.Text != "" &&
                txtBase.Text != "" && txtTotalCierre.Text != "")
            {
                decimal totalTrabajadoras = 0;
                decimal totalAhorro = 0;
                decimal totalBase = 0;

                if (decimal.TryParse(txtTrabajadoras.Text, out totalTrabajadoras) &&
                    decimal.TryParse(txtAhorro.Text, out totalAhorro) &&
                    decimal.TryParse(txtBase.Text, out totalBase))
                {
                    cierreActualizar.pagoTrabajadoras = totalTrabajadoras;
                    cierreActualizar.ahorro = totalAhorro;
                    cierreActualizar.totalBase = totalBase;
                    cierreActualizar.totalEnCaja = cierreActualizar.totalCierre - (totalTrabajadoras + totalAhorro + totalBase);
                    cierreActualizar.fecha = DateTime.Today;
                    cierreController.Update(cierreActualizar);
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

        public void setCierre(int id)
        {
            this.cierreActualizar = cierreController.SearchById(id);
            txtTotalCierre.Text = cierreActualizar.totalCierre.ToString();
        }

        private void CierreAct_Load(object sender, EventArgs e)
        {

        }
    }
}
