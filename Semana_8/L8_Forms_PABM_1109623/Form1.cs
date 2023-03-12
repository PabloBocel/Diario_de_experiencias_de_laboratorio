using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace L8_Forms_PABM_1109623
{
    public partial class Sumatoria : Form
    {
        public int operacion = 0;
        public Sumatoria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cmbsleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbsleccion.SelectedIndex) // Pablo Bocel 1109623, Me costó hacerlo :)
            {
                case 0:
                    tabDatos1.SelectedTab = tabpage0;
                    operacion = 1;
                    break; 
                case 1:
                    tabDatos1.SelectedTab = tabPage2;
                    operacion = 2;
                    break;
                case 2:
                    tabDatos1.SelectedTab = tabPage1;
                    operacion = 3;
                    break;
            }
        }

        private void btnseleccion_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operacion)
                {
                    case 1:
                        int suma = 0;
                        int num = Convert.ToInt32(txtNum.Text);
                        int i = 1;
                        do
                        {
                            if (num > 0)
                            {
                                suma = suma + i;
                                i++;
                            }
                            else
                            {
                                MessageBox.Show("Ingrese un número mayor a 0");
                            }
                        }
                        while (i <= num);
                        lblReultadoTotal.Text = "La sumatoria es " + suma;
                        break;
                    case 2:
                        int num2 = Convert.ToInt32(txtNum2.Text);
                        string tablas = "\n";
                        for (int j = 1; j <= 10; j++)
                        {
                        tablas = tablas + Convert.ToString((j * num2)) + "\n";
                        }
                        label2.Text = "Las tablas de multiplicación \n de este número son: " + tablas;
                        break;
                    case 3:
                        int num3 = Convert.ToInt32(txtNum3.Text);
                        int sum = 0;
                        int h = sum;
                        if (num3 > 0)
                        {
                            for (int l = 1; l < num3; l++)
                            {
                                if (num3 % l == 0)
                                {
                                    sum = sum + l;
                                }

                            }
                            if (sum == num3)
                            {
                                label5.Text =  num3 + " es un numero perfecto";
                            }
                            else
                            {
                                label5.Text =  "no es un numero perfecto";
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Selecionar una opción");
                        break;
                }
        }
            catch
            {
                MessageBox.Show("Ingresar número valido");
            }

}
           

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabpage0_Click(object sender, EventArgs e)
        {

        }
    }
}
