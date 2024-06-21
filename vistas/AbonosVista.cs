using PosDesktop.controller;
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
    public partial class AbonosVista : Form
    {
        AbonoController abonoController = new AbonoController();

        public AbonosVista()
        {
            InitializeComponent();
            inicializarGrid();
        }

        public void obtenerAbonos(int idSeparado)
        {
            abonosDataGridView.Refresh();
            abonosDataGridView.DataSource = null;
            abonosDataGridView.DataSource = abonoController.SearchBySeparadoId(idSeparado);
            abonosDataGridView.Refresh();
        }

        private void AbonosVista_Load(object sender, EventArgs e)
        {

        }

        public void inicializarGrid()
        {
            abonosDataGridView.Columns[1].DefaultCellStyle.Format = "C0"; // Formato de moneda sin decimales
            abonosDataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Alinear a la derecha

            abonosDataGridView.Columns[1].HeaderCell.Style.Font = new Font(abonosDataGridView.Font, FontStyle.Bold);
            abonosDataGridView.Columns[1].HeaderCell.Style.Font = new Font(abonosDataGridView.Font, FontStyle.Bold);
        }
    }
}
