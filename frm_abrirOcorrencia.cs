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
    public partial class frm_abrirOcorrencia : Form
    {
        public frm_abrirOcorrencia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.func_outros_setores'. Você pode movê-la ou removê-la conforme necessário.
            this.func_outros_setoresTableAdapter.Fill(this.controle_ocorrenciasDataSet.func_outros_setores);
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.setores'. Você pode movê-la ou removê-la conforme necessário.
            this.setoresTableAdapter.Fill(this.controle_ocorrenciasDataSet.setores);
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.controle_ocorrenciasDataSet.veiculo);
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.ocorrencia'. Você pode movê-la ou removê-la conforme necessário.
            this.ocorrenciaTableAdapter.Fill(this.controle_ocorrenciasDataSet.ocorrencia);
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.motorista'. Você pode movê-la ou removê-la conforme necessário.
            this.motoristaTableAdapter.Fill(this.controle_ocorrenciasDataSet.motorista);

            cmbbx_FuncResp.Text = "";
            cmbbx_FuncResp.Enabled = false;
            cmbbx_motorista.Text = "";
            cmbbx_motorista.Enabled = false;
            cmbbx_setorResp.Text = "";
            cmbbx_setorResp.Enabled = false;
            cmbbx_veiculo.Text = "";
            cmbbx_veiculo.Enabled = false;
            txtbx_ContraMedida.Text = "";
            txtbx_ContraMedida.Enabled = false;
            txtbx_ocorrencia.Text = "";
            txtbx_ocorrencia.Enabled = false;

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            if (txtbx_ocorrencia.Enabled == false)
            {
                this.Validate();
                this.ocorrenciaBindingSource.AddNew();

                cmbbx_FuncResp.Enabled = true;
                cmbbx_motorista.Enabled = true;
                cmbbx_setorResp.Enabled = true;
                cmbbx_veiculo.Enabled = true;
                txtbx_ContraMedida.Enabled = true;
                txtbx_ocorrencia.Enabled = true;
            }

            else if (txtbx_ContraMedida.Enabled == true || cmbbx_FuncResp.Enabled == true)
            {
                MessageBox.Show("Nao e possivel adicionar um novo registro enquanto esse nao foi finalzado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if (cmbbx_veiculo.Text == "" || txtbx_ocorrencia.Text == "")
            {
                MessageBox.Show("O campo VEICULO\n o campo OCORRENCIA\n nao pode estar em branco", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                this.Validate();
                this.ocorrenciaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);
                MessageBox.Show("Inicie um novo registro para poder salvar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbbx_FuncResp.Text = "";
                cmbbx_FuncResp.Enabled = false;
                cmbbx_motorista.Text = "";
                cmbbx_motorista.Enabled = false;
                cmbbx_setorResp.Text = "";
                cmbbx_setorResp.Enabled = false;
                cmbbx_veiculo.Text = "";
                cmbbx_veiculo.Enabled = false;
                txtbx_ContraMedida.Text = "";
                txtbx_ContraMedida.Enabled = false;
                txtbx_ocorrencia.Text = "";
                txtbx_ocorrencia.Enabled = false;
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frm_consulOcorrencia consulOcorrencia = new frm_consulOcorrencia();
            consulOcorrencia.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (cmbbx_FuncResp.Enabled == true)
            {
                if (MessageBox.Show("Deseja realmente sair?\nO registro nao salvo, sera perdido!", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }
    }
}
