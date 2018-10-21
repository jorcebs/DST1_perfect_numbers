using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Números_perfectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int num = 9999; num > 0; num--)
            {
                for (int i = num/2; i > 0; i--)
                    if (num % i == 0)
                        suma += i;
                if (suma == num)
                    lstNúmeros.Items.Add(num);
                suma = 0;
            }
        }
    }
}