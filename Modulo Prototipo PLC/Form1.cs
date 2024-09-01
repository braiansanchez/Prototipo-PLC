using S7.Net;
using System.Data;
using System;
using Timer = System.Windows.Forms.Timer;

namespace Modulo_Prototipo_PLC
{
    public partial class Form1 : Form
    {
        private Plc plc;
        private Timer timer;
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            // Inicializar el DataTable
            dataTable = new DataTable();
            dataTable.Columns.Add("Variable", typeof(string));
            dataTable.Columns.Add("Value", typeof(string));
            dataGridView1.DataSource = dataTable;

            //Inicializar PLC
            plc = new Plc(CpuType.S7300, "127.0.0.1", 0, 2);

            // Inicializar el Timer
            timer = new Timer();
            timer.Interval = 200; // 200 ms = 5 veces por segundo
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ReadPLCData();
        }

        private void ReadPLCData()
        {
            try
            {
                // Leer datos del PLC
                var value = plc.ReadBytes(DataType.DataBlock, 1, 0, 200);

                // Limpiar la tabla y agregar nuevos datos
                dataTable.Rows.Clear();
                dataTable.Rows.Add("Example Variable", value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos del PLC: " + ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Open();
                timer.Start();
                MessageBox.Show("Conectado al PLC.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error conectando al PLC." + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (plc != null && plc.IsConnected)
            {
                plc.Close();
                MessageBox.Show("Desconectado del PLC.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); // Pasa la instancia actual de Form1
            this.Hide(); // Oculta el Form1 actual
            form2.Show(); // Muestra Form2
        }
    }
}