using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Prototipo_PLC
{
    public partial class Form2 : Form
    {
        private Form1 _mainForm;

        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _mainForm.Show(); // Muestra el Form1 original
            this.Close(); // Cierra Form2
        }
    }
}
