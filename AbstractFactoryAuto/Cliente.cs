using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbstractFactoryAuto.Mundo.Interfaces;
using AbstractFactoryAuto.Mundo.Clases;
using AbstractFactoryAuto.Mundo.Fabricas;

namespace AbstractFactoryAuto
{
    public partial class Cliente : Form
    {

        private IFabricaDePartes fabrica;
        private IAuto auto;
        private ICarroceria carroceria;
        private IMotor motor;

        public Cliente()
        {
            InitializeComponent();
            cb_tipo.SelectedIndex = 0;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_renoult_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {

            if (rb_mazda.Checked)
            {
                fabrica = new FabricaMazda();
            }
            else
            {
                fabrica = new FabricaRenoult();
            }

            auto = fabrica.crearAuto();
            carroceria = fabrica.crearCarroceria();
            motor = fabrica.crearMotor();

            if(cb_tipo.SelectedIndex==0)
                MessageBox.Show(auto.darNombre());
            if(cb_tipo.SelectedIndex==1)
                MessageBox.Show(motor.darNombre());
            if(cb_tipo.SelectedIndex==2)
                MessageBox.Show(carroceria.darNombre());


            label2.Text = "Se creo un auto : " + auto.darNombre();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
