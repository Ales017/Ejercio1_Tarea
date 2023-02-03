using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            if (IngreseunvalortextBox.Text == "")
            {
                errorProvider1.SetError(IngreseunvalortextBox, "Ingrese el valor");
                return;
            }
            errorProvider1.Clear();

            int resultado = ParOImpar(Convert.ToInt32(IngreseunvalortextBox.Text));
            int resultado2 = PositivoENegativo(Convert.ToInt32(IngreseunvalortextBox.Text));
            
        }

        private int ParOImpar(int Numero1)
        {
            if (Numero1 % 2 == 0 ) 
            {
                Resultadolabel.Text = "El numero es par";
            }
            else
            {
                Resultadolabel.Text = "El numero es impar";
            }
            return Numero1;
        }

        private int PositivoENegativo(int Numero1)
        {
            if (Numero1 >= 0)
            {
                Resultadolabel2.Text = "El numero es positivo";
            }
            else if (Numero1 <= 0) 
            {
                Resultadolabel2.Text = "El numero es negativo";
            }
            return Numero1;
        }

        private void Reiniciarbutton_Click(object sender, EventArgs e)
        {
            IngreseunvalortextBox.Text = "";
            Resultadolabel.Text = "";
            Resultadolabel2.Text = "";
        }
    }
}
