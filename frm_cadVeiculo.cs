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
    public partial class frm_cadVeiculo : Form
    {
        public frm_cadVeiculo()
        {
            InitializeComponent();
        }

        private void veiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void frm_cadVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.controle_ocorrenciasDataSet.veiculo);
            txtbx_placa.Text = "";
            txtbx_placa.Enabled = false;
            txtbx_veiculo.Text = "";
            txtbx_veiculo.Enabled = false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (txtbx_veiculo.Enabled == true || txtbx_placa.Enabled == true)
            {
                if (MessageBox.Show("Deseja realmente sair?\n Dados nao salvos serao perdidos", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            if(txtbx_veiculo.Enabled == false || txtbx_placa.Enabled == false)
            {
                txtbx_placa.Enabled = true;
                txtbx_veiculo.Enabled = true;
                this.Validate();
                this.veiculoBindingSource.AddNew();
            }

            else if (txtbx_veiculo.Enabled == true || txtbx_placa.Enabled == true)
            {
                MessageBox.Show("Nao e possivel adicionar um novo registro enquanto esse nao foi finalzado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txtbx_veiculo.Text == "")
            {
                MessageBox.Show("O campo VEICULO nao pode estar vazio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                this.Validate();
                this.veiculoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);
                MessageBox.Show("Cadastro salvo com sucesso", "Confirmacao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbx_placa.Enabled = false;
                txtbx_veiculo.Enabled = false;
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frm_consultVeiculo consultVeiculo = new frm_consultVeiculo();
            consultVeiculo.ShowDialog();
        }
    }
}
