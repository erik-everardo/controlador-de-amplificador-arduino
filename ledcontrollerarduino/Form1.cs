using Sharer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ledcontrollerarduino
{
    public partial class Form1 : Form
    {
        SharerConnection connection;
        public Form1()
        {
            InitializeComponent();

            trackBar1.Enabled = false;
            valor.Text = (trackBar1.Value * 100 / 255).ToString() + "%";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            connection.Call("analogWrite", 3, trackBar1.Value / 4);
            valor.Text = ((trackBar1.Value / 4)*100/255).ToString() + "%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void conectarBoton_Click(object sender, EventArgs e)
        {
            

            try
            {
                string _puerto = puerto.Text;
                int _baudios = int.Parse(baudios.Text);
                connection = new SharerConnection(_puerto, _baudios);
                connection.Connect();
                trackBar1.Enabled = true;
                desconectar.Enabled = true;
                conectarBoton.Enabled = false;
            }

            catch(FormatException ex)
            {
                MessageBox.Show("Introducir valores de COM y baudios: " + ex.Message);
            }
            catch(System.IO.IOException ex)
            {
                MessageBox.Show("Introducir los valores correctos para la placa: " + ex.Message);
            }

            
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            connection.Disconnect();
            conectarBoton.Enabled = true;
            desconectar.Enabled = false;
            trackBar1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
