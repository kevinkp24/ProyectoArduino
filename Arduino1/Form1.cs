using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino1
{
    public partial class Form1 : Form
    {
        SerialPort port;
        bool IsClosed = false;
        private StreamWriter writer;
        public Form1()
        {
            InitializeComponent();
            writer = new StreamWriter("datos.txt", true);
            port = new SerialPort();
            port.PortName = "COM3";
            port.BaudRate = 9600;
            port.ReadTimeout = 500;
            try
            {
                port.Open();
            }
            catch
            {
                Console.WriteLine("Falla en arduino");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread hilo = new Thread(EscucharSerial);
            hilo.Start();
        }

        private void EscucharSerial()
        {
            int contador, contadorDos, contadorDiez;
            while (!IsClosed)
            {
                try
                {
                    if (port.IsOpen)
                    {
                        string cadena = port.ReadLine();

                        string[] datosSeparados = cadena.Split(',');

                         contador = int.Parse(datosSeparados[0]);
                         contadorDos = int.Parse(datosSeparados[1]);
                         contadorDiez = int.Parse(datosSeparados[2]);

                        txtAlgo.Invoke(new MethodInvoker(delegate
                        {
                            txtAlgo.Text = cadena;
                        }));

                        txtContador.Invoke(new MethodInvoker(delegate
                        {
                            txtContador.Text = contador.ToString();
                        }));

                        txtContador2.Invoke(new MethodInvoker(delegate
                        {
                            txtContador2.Text = contadorDos.ToString();
                        }));

                        txtContador10.Invoke(new MethodInvoker(delegate
                        {
                            txtContador10.Text = contadorDiez.ToString();
                        }));
                    }
                    else
                    {
                        Console.WriteLine("El puerto está cerrado.");
                        break;
                    }
                    writer.WriteLine($"Contador: {contador}, ContadorDos: {contadorDos}, ContadorDiez: {contadorDiez}");
                }
                catch (TimeoutException ex)
                {
                    Console.WriteLine("Timeout de lectura: " + ex.Message);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error de E/S: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Excepción: " + ex.Message);
                }
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
            if (port.IsOpen)
            { 
                port.Close();
            }

            if (writer != null)
            {
                writer.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Write("1");
                    Console.WriteLine("Se ha enviado un '1' al puerto serial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al enviar datos: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El puerto no está abierto.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Write("0");
                    Console.WriteLine("Se ha enviado un '0' al puerto serial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al enviar datos: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El puerto no está abierto.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Write("3");
                    Console.WriteLine("Se ha enviado un '3' al puerto serial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al enviar datos: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El puerto no está abierto.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Write("4");
                    Console.WriteLine("Se ha enviado un '4' al puerto serial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al enviar datos: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El puerto no está abierto.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Write("5");
                    Console.WriteLine("Se ha enviado un '5' al puerto serial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al enviar datos: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El puerto no está abierto.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Write("6");
                    Console.WriteLine("Se ha enviado un '5' al puerto serial.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al enviar datos: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El puerto no está abierto.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bt_grafica_Click(object sender, EventArgs e)
        {
            GraficaArduinos graficaArduinos = new GraficaArduinos();
            this.Hide();
            graficaArduinos.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
