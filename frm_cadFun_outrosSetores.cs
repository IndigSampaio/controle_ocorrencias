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
    public partial class frm_cadFun_outrosSetores : Form
    {
        public frm_cadFun_outrosSetores()
        {
            InitializeComponent();
        }

        private void func_outros_setoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void frm_cadFun_outrosSetores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.setores'. Você pode movê-la ou removê-la conforme necessário.
            this.setoresTableAdapter.Fill(this.controle_ocorrenciasDataSet.setores);
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.func_outros_setores'. Você pode movê-la ou removê-la conforme necessário.
            this.func_outros_setoresTableAdapter.Fill(this.controle_ocorrenciasDataSet.func_outros_setores);
            txtbx_nomeFunc.Enabled = false;
            txtbx_nomeFunc.Text = "";
            cmbbx_setorFunc.Enabled = false;
            cmbbx_setorFunc.Text = "";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if(txtbx_nomeFunc.Enabled == false)
            {
                MessageBox.Show("Inicie um novo registro para poder salvar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtbx_nomeFunc.Text == "" || cmbbx_setorFunc.Text == "")
            {
                MessageBox.Show("O campo NOME DO FUNCIONARIO nao pode estar em branco", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                this.Validate();
                this.func_outros_setoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);
                MessageBox.Show("Registro salvo com sucesso", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbx_nomeFunc.Enabled = false;
                txtbx_nomeFunc.Text = "";
                cmbbx_setorFunc.Enabled = false;
                cmbbx_setorFunc.Text = "";
            }

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            if (txtbx_nomeFunc.Enabled == false)
            {
                txtbx_nomeFunc.Enabled = true;
                cmbbx_setorFunc.Enabled = true;
                this.Validate();
                this.func_outros_setoresBindingSource.AddNew();
            }

            else
            {
                MessageBox.Show("Nao e possivel adicionar um novo registro enquanto esse nao foi finalzado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if(txtbx_nomeFunc.Enabled == true)
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

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frm_consultFunc_outrosSetores consultFunc_OutrosSetores = new frm_consultFunc_outrosSetores();
            consultFunc_OutrosSetores.ShowDialog();
        }
    }
}
