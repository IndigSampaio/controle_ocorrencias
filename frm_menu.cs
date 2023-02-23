using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Ocorrencias
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadSetor_Click(object sender, EventArgs e)
        {
            frm_cadSetor cadSetor = new frm_cadSetor();
            cadSetor.ShowDialog();
        }

        private void btn_cadVeic_Click(object sender, EventArgs e)
        {
            frm_cadVeiculo cadVeiculo = new frm_cadVeiculo();
            cadVeiculo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_cadMotorista cadMotorista = new frm_cadMotorista();
            cadMotorista.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_cadFun_outrosSetores outrosSetores = new frm_cadFun_outrosSetores();
            outrosSetores.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_abrirOcorrencia abrirOcorrencia = new frm_abrirOcorrencia();
            abrirOcorrencia.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_consultMotorista consultMotorista = new frm_consultMotorista();
            consultMotorista.ShowDialog();
        }

        private void btn_consulSetores_Click(object sender, EventArgs e)
        {
            frm_consulSetor consulSetor = new frm_consulSetor();
            consulSetor.ShowDialog();
        }

        private void btn_consultFunOutrosSetores_Click(object sender, EventArgs e)
        {
            frm_consultFunc_outrosSetores consultFunc_OutrosSetores = new frm_consultFunc_outrosSetores();
            consultFunc_OutrosSetores.ShowDialog();
        }

        private void btn_consultVeic_Click(object sender, EventArgs e)
        {
            frm_consultVeiculo consultVeiculo = new frm_consultVeiculo();
            consultVeiculo.ShowDialog();
        }

        private void btn_consulOcorrencias_Click(object sender, EventArgs e)
        {
            frm_consulOcorrencia consulOcorrencia = new frm_consulOcorrencia();
            consulOcorrencia.ShowDialog();
        }
    }
}
