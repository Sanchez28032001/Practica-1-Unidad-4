namespace Practica_1__Unidad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private int sumar(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;
            return resultado;

        }

        private Double operaciones(int num1, int num2, string op)
        {
            Double resultado;
            if (op == "s")
            {
                resultado = num1 + num2;
            }
            else if (op == "r")
            {
                resultado = num1 - num2;
            }
            else if (op == "m")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            //Entrada de datos
            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            int suma;
            suma = sumar(numero1, numero2);
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            resultado = operaciones(numero1, numero2, "r");
            textBox3.Text = Convert.ToString(resultado);
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            resultado = operaciones(numero1, numero2, "m");
            textBox3.Text = Convert.ToString(resultado);
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            Double resultado;

            numero1 = Convert.ToInt32(textBox1.Text);
            numero2 = Convert.ToInt32(textBox2.Text);

            resultado = operaciones(numero1, numero2, "d");
            textBox3.Text = Convert.ToString(resultado);
        }
    }
}