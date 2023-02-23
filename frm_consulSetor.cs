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
    public partial class frm_consulSetor : Form
    {
        public frm_consulSetor()
        {
            InitializeComponent();
        }

        private void setoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.setoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);

        }

        private void frm_consulSetor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.setores'. Você pode movê-la ou removê-la conforme necessário.
            this.setoresTableAdapter.Fill(this.controle_ocorrenciasDataSet.setores);

        }

        private void fillBysetorToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.setoresTableAdapter.FillBysetor(this.controle_ocorrenciasDataSet.setores, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void txtbx_consSetor_TextChanged(object sender, EventArgs e)
        {
            this.setoresTableAdapter.FillBysetor(this.controle_ocorrenciasDataSet.setores, txtbx_consSetor.Text);
        }
    }
}
