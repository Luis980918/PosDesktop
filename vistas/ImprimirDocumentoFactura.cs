using PosDesktop;
using PosDesktop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturaC_
{
    public partial class ImprimirDocumentoFactura : Form
    {
        private PrintDocument PD = new PrintDocument();
        private PrintPreviewDialog PPD = new PrintPreviewDialog();
        private int longpaper;
        private int numero;
        Form1 formOrigin;
        public ImprimirDocumentoFactura(Despacho despacho, Form1 formOrigin)
        {
            this.formOrigin = formOrigin;
            formOrigin.Hide();
            InitializeComponent();
            PD.BeginPrint += new PrintEventHandler(PD_BeginPrint);
            PD.PrintPage += new PrintPageEventHandler(PD_PrintPage);
            DataGridView1.Columns[2].DefaultCellStyle.Format = "C0"; // Formato de moneda sin decimales
            DataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinear a la derecha

            numero = despacho.id;
            despacho.ventas.ForEach(e => {
                DataGridView1.Rows.Add("Item" + e.numeroItem, e.cantidad, e.precioUnitario);
            });
        }
        private void changelongpaper()
        {
            int rowcount = DataGridView1.Rows.Count;
            longpaper = rowcount * 15 + 240;
        }

        private void BTPRINT_Click(object sender, EventArgs e)
        {
            changelongpaper();
            PPD.Document = PD;
            PPD.ShowDialog();
            //PD.Print();
        }

        private void PD_BeginPrint(object sender, PrintEventArgs e)
        {
            PageSettings pagesetup = new PageSettings();
            pagesetup.PaperSize = new PaperSize("Custom", 250, longpaper);
            PD.DefaultPageSettings = pagesetup;
        }

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f8 = new Font("Calibri", 8, FontStyle.Regular);
            Font f10 = new Font("Calibri", 10, FontStyle.Regular);
            Font f10b = new Font("Calibri", 10, FontStyle.Bold);
            Font f14 = new Font("Calibri", 14, FontStyle.Bold);

            int leftmargin = PD.DefaultPageSettings.Margins.Left;
            int centermargin = PD.DefaultPageSettings.PaperSize.Width / 2;
            int rightmargin = PD.DefaultPageSettings.PaperSize.Width;

            StringFormat right = new StringFormat();
            StringFormat center = new StringFormat();
            right.Alignment = StringAlignment.Far;
            center.Alignment = StringAlignment.Center;

            string line = "****************************************************************";

            Image logoImage = PosDesktop.Properties.Resources.logo2;
            e.Graphics.DrawImage(logoImage, (e.PageBounds.Width - 100) / 2, 5, 100, 35);

            int startY = 40; // Posición inicial vertical del primer texto

            // Dibujar el nombre
            e.Graphics.DrawString("KELI MONSALVE", f10, Brushes.Black, centermargin, startY, center);
            startY += 15; // Ajuste vertical entre líneas

            // Dibujar la dirección
            e.Graphics.DrawString("CALLE 28 # 29-18", f10, Brushes.Black, centermargin, startY, center);
            startY += 15; // Ajuste vertical entre líneas

            // Dibujar el NIT
            e.Graphics.DrawString("NIT. 1.035.830.505-7", f10, Brushes.Black, centermargin, startY, center);
            startY += 25; // Ajuste vertical entre líneas



            e.Graphics.DrawString("Factura N", f8, Brushes.Black, 0, startY);
            e.Graphics.DrawString(":", f8, Brushes.Black, 50, startY);
            e.Graphics.DrawString(numero.ToString(), f8, Brushes.Black, 70, startY);
            startY += 15; // Ajuste vertical entre líneas


            e.Graphics.DrawString("Cajero", f8, Brushes.Black, 0, startY);
            e.Graphics.DrawString(":", f8, Brushes.Black, 50, startY);
            e.Graphics.DrawString("Keli Monsalve", f8, Brushes.Black, 70, startY);
            startY += 15; // Ajuste vertical entre líneas


            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToShortDateString() + " - Hora: " + DateTime.Now.ToShortTimeString(), f8, Brushes.Black, 0, startY);
            startY += 15; // Ajuste vertical entre líneas


            e.Graphics.DrawString("Cant.", f8, Brushes.Black, 0, startY);
            e.Graphics.DrawString("Descripción.", f8, Brushes.Black, 25, startY);
            //%
            //e.Graphics.DrawString("%", f8, Brushes.Black, 140, 110);

            e.Graphics.DrawString("Valor", f8, Brushes.Black, 180, startY, right);
            e.Graphics.DrawString("Total", f8, Brushes.Black, rightmargin, startY, right);
            startY += 15; // Ajuste vertical entre líneas


            e.Graphics.DrawString(line, f8, Brushes.Black, 0, startY);
            startY -= 10; // Ajuste vertical entre líneas


            int height = 0;
            decimal i;
            DataGridView1.AllowUserToAddRows = false;

            for (int row = 0; row < DataGridView1.RowCount; row++)
            {
                height += 15;
                e.Graphics.DrawString(DataGridView1.Rows[row].Cells[1].Value.ToString(), f8, Brushes.Black, 0, startY + height);
                e.Graphics.DrawString(DataGridView1.Rows[row].Cells[0].Value.ToString(), f8, Brushes.Black, 25, startY + height);
                i = Convert.ToDecimal(DataGridView1.Rows[row].Cells[2].Value);
                DataGridView1.Rows[row].Cells[2].Value = i.ToString("##,##0");

                //%
                //e.Graphics.DrawString("19", f8, Brushes.Black, 150, 115 + height, right);

                e.Graphics.DrawString(DataGridView1.Rows[row].Cells[2].Value.ToString(), f8, Brushes.Black, 180, startY + height, right);

                decimal totalprice = Convert.ToDecimal(DataGridView1.Rows[row].Cells[1].Value) * Convert.ToDecimal(DataGridView1.Rows[row].Cells[2].Value);
                e.Graphics.DrawString(totalprice.ToString("##,##0"), f8, Brushes.Black, rightmargin, startY + height, right);
            }

            int height2 = 155 + height;
            sumprice();

            e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2);
            e.Graphics.DrawString("Total: " + t_price.ToString("##,##0"), f10b, Brushes.Black, rightmargin, 10 + height2, right);
            e.Graphics.DrawString("Items: " + t_qty.ToString(), f10b, Brushes.Black, 0, 10 + height2);

            e.Graphics.DrawString("GRACIAS POR PREFERIRNOS", f10, Brushes.Black, centermargin, 70 + height2, center);
            e.Graphics.DrawString("Documento generado por: PosDesktop", f8, Brushes.Black, centermargin, 85 + height2, center);
        }

        private decimal t_price;
        private int t_qty;

        private void sumprice()
        {
            decimal countprice = 0;
            for (int rowitem = 0; rowitem < DataGridView1.RowCount; rowitem++)
            {
                countprice += Convert.ToDecimal(DataGridView1.Rows[rowitem].Cells[2].Value) * Convert.ToDecimal(DataGridView1.Rows[rowitem].Cells[1].Value);
            }
            t_price = countprice;

            int countqty = 0;
            for (int rowitem = 0; rowitem < DataGridView1.RowCount; rowitem++)
            {
                countqty += Convert.ToInt32(DataGridView1.Rows[rowitem].Cells[1].Value);
            }
            t_qty = countqty;
        }

        private void BTREFRESH_Click(object sender, EventArgs e)
        {
            DataGridView1.AllowUserToAddRows = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImprimirDocumentoFactura_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirDocumentoFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            formOrigin.reiniciarCheck();
            formOrigin.Show();
        }
    }
}
