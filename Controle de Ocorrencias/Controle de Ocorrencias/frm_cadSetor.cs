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
    public partial class frm_cadSetor : Form
    {
        public frm_cadSetor()
        {
            InitializeComponent();
        }

        private void setoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void frm_cadSetor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.setores'. Você pode movê-la ou removê-la conforme necessário.
            this.setoresTableAdapter.Fill(this.controle_ocorrenciasDataSet.setores);
            txtbx_setor.Enabled = false;
            txtbx_setor.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtbx_setor.Text == "")
            {
                MessageBox.Show("O campo SETOR nao pode estar em branco", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else
            {
                this.Validate();
                this.setoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);
                MessageBox.Show("Registro salvo com sucesso", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbx_setor.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            if (txtbx_setor.Enabled == false)
            {
                txtbx_setor.Enabled = true;
            }

            else
            {
                MessageBox.Show("Nao e possivel adicionar um novo registro enquanto esse nao foi finalzado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (txtbx_setor.Enabled == true)
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

        private void button3_Click(object sender, EventArgs e)
        {
            frm_consulSetor consulSetor = new frm_consulSetor();
            consulSetor.ShowDialog();
        }
    }
}
