using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.CSharp.RuntimeBinder;
using System.Web;
using System.Drawing.Printing;


namespace turno
{
    public partial class inicial : Form
    {
        dynamic servis;
        public inicial()
        {
           
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parametros.Accion = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtempre.Text != "")
            {
                parametros.Accion = true;
                char delimitador = '-';
                string[] valores = txtempre.Text.Split(delimitador);
                parametros.Id = valores[0].ToString();
                Close();
            }
        }
        private async void llamarEmpresa()
        {
            try
            {
                int axu = 0;
                string url = config.Default.conexionapi + "organizacion/view";
                //MessageBox.Show(url);
                using (HttpClient cliente = new HttpClient())
                {
                    var respuesta = await cliente.GetAsync(url);
                    if (respuesta.IsSuccessStatusCode)
                    {
                        var data1 = await respuesta.Content.ReadAsStringAsync();
                        servis = JsonConvert.DeserializeObject(data1);


                    }
                    else
                    {
                        MessageBox.Show("ERROR EN LA PETICIÓN, REVISE LA CONFIGURACIÓN");
                        axu = 1;
                    }

                    foreach (var data in servis)
                    {
                        txtempre.Items.Add(data.id + "-" + data.nombre);
                    }


                }
            }
            catch { MessageBox.Show("❌ ERROR EN LA PETICIÓN, REVISE SU CONFIGURACIÓN"); }
        }

            private void inicial_Load(object sender, EventArgs e)
        {
            llamarEmpresa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            configuraciones llamar = new configuraciones();
            llamar.ShowDialog();
        }
    }
}
