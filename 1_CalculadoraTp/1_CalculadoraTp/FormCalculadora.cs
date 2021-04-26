using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace _1_CalculadoraTp
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            //cargo operadores en el combobox
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('*');
            cmbOperador.Items.Add('/');
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }


        //BOTONES
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //METOODOS

        /// <summary>
        /// llama al metodo estati operar de la clase calculadora 
        /// </summary>
        /// <param name="numero1">recibe un strig numero 1</param>
        /// <param name="numero2">recibe un string numero 2</param>
        /// <param name="operador">recibe un string operador</param>
        /// <returns> retorna el resultado en double</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);

            return Calculadora.Operar(numeroUno, numeroDos, operador);
        }

        //metodo Limpiar
        /// <summary>
        /// Limpia los texbox del numero 1 y numero 2, tambien el del label resultado
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "";
            cmbOperador.Text = "";
        }


        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
     
            
            if(result==DialogResult.Yes) 
            {
               Dispose();
            }
            else 
            {
                e.Cancel = true;
            }
        }
    }
}
