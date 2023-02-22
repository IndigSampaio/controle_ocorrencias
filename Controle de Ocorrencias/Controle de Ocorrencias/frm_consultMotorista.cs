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
    public partial class frm_consultMotorista : Form
    {
        public frm_consultMotorista()
        {
            InitializeComponent();
        }

        private void motoristaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.motoristaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);

        }

        private void frm_consultMotorista_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.motorista'. Você pode movê-la ou removê-la conforme necessário.
            this.motoristaTableAdapter.Fill(this.controle_ocorrenciasDataSet.motorista);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.motoristaTableAdapter.FillByconsultMoto(this.controle_ocorrenciasDataSet.motorista, textBox1.Text);
        }
    }
}
