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
    public partial class frm_cadMotorista : Form
    {
        public frm_cadMotorista()
        {
            InitializeComponent();
        }

        private void motoristaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void frm_cadMotorista_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.setor_moto'. Você pode movê-la ou removê-la conforme necessário.
            this.setor_motoTableAdapter.Fill(this.controle_ocorrenciasDataSet.setor_moto);
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.motorista'. Você pode movê-la ou removê-la conforme necessário.
            this.motoristaTableAdapter.Fill(this.controle_ocorrenciasDataSet.motorista);

            cmbbx_setorMoto.Enabled = false;
            txtbx_nomeMoto.Enabled = false;
            chkbx_ativo.Enabled = false;
            cmbbx_setorMoto.Text = "";
            txtbx_nomeMoto.Text = "";
            chkbx_ativo.Checked = false;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {

            if(cmbbx_setorMoto.Enabled == true || txtbx_nomeMoto.Enabled == true)
            {
                MessageBox.Show("Nao e possivel adicionar um novo registro enquanto esse nao foi finalzado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                this.Validate();
                this.motoristaBindingSource.AddNew();
                cmbbx_setorMoto.Enabled = true;
                txtbx_nomeMoto.Enabled = true;
                chkbx_ativo.Enabled = true;
            }
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if(txtbx_nomeMoto.Text == "")
            {
                MessageBox.Show("O campo NOME DO MOTORISTA nao pode estar em branco", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                this.Validate();
                this.motoristaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);
                MessageBox.Show("Registro salvo com sucesso", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbbx_setorMoto.Enabled = false;
                txtbx_nomeMoto.Enabled = false;
                chkbx_ativo.Enabled = false;
                cmbbx_setorMoto.Text = "";
                txtbx_nomeMoto.Text = "";
                chkbx_ativo.Checked = false;
            }
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (cmbbx_setorMoto.Enabled == true || txtbx_nomeMoto.Enabled == true)
            {
                if(MessageBox.Show("Deseja realmente sair?\nO registro nao salvo, sera perdido!", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
            frm_consultMotorista consultMotorista = new frm_consultMotorista();
            consultMotorista.Show();
        }

        private void cmbbx_setorMoto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
