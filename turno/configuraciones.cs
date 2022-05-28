using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace turno
{
    public partial class configuraciones : Form
    {
        public configuraciones()
        {
            InitializeComponent();
        }

        private void configuraciones_Load(object sender, EventArgs e)

        {
            try
            {
                checkImprime.Checked = config.Default.imprime;
                if (checkImprime.Checked)
                {
                    checkImprime.Text = "IMPRESIÓN";
                }
                else
                {
                    checkImprime.Text = "SIN IMPRESION";
                }
            }
            catch { }
            txtimpresoras.Items.Clear();
            PrinterSettings impresora = new PrinterSettings();
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                impresora.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();

               
                txtimpresoras.Items.Add(PrinterSettings.InstalledPrinters[i].ToString());
                
            }

            txtconexionapi.Text = config.Default.conexionapi;
            txtimpresoras.Text = config.Default.print;
            txturlwebsocker.Text = config.Default.wsurl;
            txtname.Text = config.Default.name;
        }

        



        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config.Default.wsurl = txturlwebsocker.Text;
            config.Default.name = txtname.Text;
            config.Default.conexionapi = txtconexionapi.Text;
            config.Default.print = txtimpresoras.Text;
            config.Default.imprime = checkImprime.Checked;
            config.Default.Save();
            Close();
        }

        private void checkImprime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkImprime.Checked)
            {
                checkImprime.Text = "IMPRESIÓN";
            }
            else
            {
                checkImprime.Text = "SIN IMPRESION";
            }
        }
    }
}
