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
using System.Net;
using System.Net.Sockets;
using H.Socket.IO;
using Quobject.SocketIoClientDotNet.Client;










namespace turno
{


    public partial class Form1 : Form
    {

        public Button[] b = new Button[1];
        int columnas = 0;
        int contador = 0;
        int filas = 0;
        int con = 0;
        dynamic servis;
        dynamic turnoGenerado;
        Boolean preferencial = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                inicial llamar = new inicial();
                llamar.ShowDialog();
                if(parametros.Accion == false)
                {
                    Close();

                }
            }
            catch { }
            
            try
            {
                this.Text = "TURNERO - " + config.Default.name;
            }
            catch { }
            preferencialopt.Checked = false;
            llamarServicios();

        }


        private async void llamarServicios()
        {
            try
            {
                cargando.Visible = true;
                string textoservicio = "";
                int axu = 0;
               // string url = config.Default.conexionapi + "servicios/1";
                string url = config.Default.conexionapi + "servicios/"+ parametros.Id;
                //MessageBox.Show(url);
                using (HttpClient cliente = new HttpClient())
                {
                    var respuesta = await cliente.GetAsync(url);
                    if (respuesta.IsSuccessStatusCode)
                    {
                        var data1 = await respuesta.Content.ReadAsStringAsync();
                        servis = JsonConvert.DeserializeObject(data1);
                        Console.WriteLine(servis);
                        cargando.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("ERROR EN LA PETICIÓN, REVISE LA CONFIGURACIÓN");
                        axu = 1;
                    }
                }
                if (axu == 0)
                {
                    int i = 0;
                    foreach (var data in servis[0].orgservicio)
                    {
                        if (contador == 4)
                        {
                            filas = filas + 150;
                            columnas = 0;
                            contador = 0;
                        }
                        contador++;
                        Array.Resize(ref b, con + 2);
                        b[con] = new Button();
                        b[con].Height = 150;
                        b[con].Width = 250;
                        textoservicio = data.servicio;
                        b[con].Location = new System.Drawing.Point(columnas, filas);
                        b[con].Left = columnas;
                        b[con].Name = data.inicial;
                        b[con].TabIndex = data.id;
                        b[con].Tag = i;
                        b[con].Text = textoservicio.ToUpper();
                        b[con].ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                        b[con].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        b[con].UseVisualStyleBackColor = false;
                        b[con].BackColor = System.Drawing.Color.SlateGray;
                        b[con].ForeColor = System.Drawing.Color.White;
                        b[con].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        b[con].Cursor = System.Windows.Forms.Cursors.Hand;
                        b[con].Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        panel44.Controls.Add(b[con]);
                        b[con].Click += new System.EventHandler(clic_objetos_prouctos);
                        con++;
                        columnas = columnas + 250;
                        i++;
                    }
                }
            }
            catch(Exception eee) {  }





              
            }

        private async void generaTurno(int idServicio)
        {
            string url = config.Default.conexionapi +  "turno";
            string json = $"{{\"idEstado\":\"2\",\"ServicioId\":\"{idServicio}\",\"preferencial\":\"{preferencial}\"}}";
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpClient cliente = new HttpClient())
            {
                var respuesta = await cliente.PostAsync(url, stringContent);
                if (respuesta.IsSuccessStatusCode)
                {
                    var data = await respuesta.Content.ReadAsStringAsync();
                    turnoGenerado = JsonConvert.DeserializeObject(data);
                }
                else
                {
                    MessageBox.Show("ERROR EN LA PETICIÓN, REVISE LA CONFIGURACIÓN");
                    
                }
            }
            if (config.Default.imprime)
            {
                imprimir();
            }
            preferencialopt.Checked = false;




        }

        void clic_objetos_prouctos(Object sender, EventArgs e)
        {
            try
            {
                Int16 cuentatag = Convert.ToInt16(((System.Windows.Forms.Button)sender).Tag);
                int idServicio = int.Parse(b[cuentatag].TabIndex.ToString());
                TXTINICIAL.Text = b[cuentatag].Name.ToString();
                txtservicio.Text = b[cuentatag].Text.ToString();

                generaTurno(idServicio);
                Notifica(idServicio);

            }
            catch { }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            configuraciones llamar = new configuraciones();
            llamar.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            
        }

        void imprimir()
        {
            try
            {

                PrintDocument formulario = new PrintDocument();
                formulario.PrinterSettings.PrinterName = config.Default.print;
                formulario.PrinterSettings.DefaultPageSettings.PrinterResolution.X = 2600;
                formulario.PrinterSettings.DefaultPageSettings.PrinterResolution.X = 2600;
                formulario.PrinterSettings.DefaultPageSettings.PrinterResolution.Kind = PrinterResolutionKind.High;
                formulario.PrintPage += new PrintPageEventHandler(Datos_nota);
                PrintPreviewDialog printDialog1 = new PrintPreviewDialog();
                printDialog1.Document = formulario;
                formulario.Print();

            }
            catch (Exception error) { MessageBox.Show("" + error); }
        }
        private void Datos_nota(object obj, PrintPageEventArgs ev)
        {
            string textP = "";
            if(preferencialopt.Checked == true) { textP = "* "; }
            Font Fuente = new Font("Century Gothic", 11);
            Font FuenteTitulo = new Font("Century Gothic", 15);
            Font FuentenumTurno= new Font("Century Gothic", 23);
            Font Fuentehora = new Font("Century Gothic", 9);
            float pos_y = -10;
            float pos_x = 2;
            
            ev.Graphics.DrawString(config.Default.name, FuenteTitulo, Brushes.Black, pos_x + 2, pos_y + 30, new StringFormat());
            ev.Graphics.DrawString("TURNO: " + textP + TXTINICIAL.Text.ToUpper() + "-" + turnoGenerado.turno, FuentenumTurno, Brushes.Black, pos_x + 2, pos_y + 70, new StringFormat());
            ev.Graphics.DrawString(txtservicio.Text, Fuente, Brushes.Black, pos_x + 2, pos_y + 120, new StringFormat());
            ev.Graphics.DrawString("FECHA: " + System.DateTime.Now.ToShortDateString() + "        HORA: " + System.DateTime.Now.ToShortTimeString(), Fuentehora, Brushes.Black, pos_x + 2, pos_y + 150, new StringFormat());
            ev.Graphics.DrawString(txtservicio.Text, Fuente, Brushes.Black, pos_x + 2, pos_y + 120, new StringFormat());
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(preferencialopt.Checked == true){
                preferencial = true;
            }
            else
            {
                preferencial = false;
            }
           
        }

        void Notifica(int id_service)
        {
            try
            {
                var socket = IO.Socket(config.Default.wsurl);
                socket.Emit("newturno", id_service);
            }
            catch { }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
           /* var socket = IO.Socket("http://10.10.56.21:3900");
            socket.Emit("newturno", 52);*/
           /* socket.On("connection", () =>
            {
                socket.Emit("newturno",52);
            });

            socket.On("newturno", (data) =>
            {
                socket.Emit("newturno", 52);
                Console.WriteLine(data);
                socket.Disconnect();
            });
            Console.ReadLine();*/
        }
        }
    }
