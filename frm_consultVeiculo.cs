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
    public partial class frm_consultVeiculo : Form
    {
        public frm_consultVeiculo()
        {
            InitializeComponent();
        }

        private void veiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.veiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);

        }

        private void frm_consultVeiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.controle_ocorrenciasDataSet.veiculo);
            txtbx_placa.Text = "";
            txtbx_veiculo.Text = "";

        }

        private void fillByconsultveiculoToolStripButton_Click(object sender, EventArgs e)
        {
    
        }

        private void txtbx_veiculo_TextChanged(object sender, EventArgs e)
        {
            this.veiculoTableAdapter.FillByconsultveiculo(this.controle_ocorrenciasDataSet.veiculo, txtbx_veiculo.Text);
        }

        private void fillByconsultPlacaToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void txtbx_placa_TextChanged(object sender, EventArgs e)
        {
            this.veiculoTableAdapter.FillByconsultPlaca(this.controle_ocorrenciasDataSet.veiculo, txtbx_placa.Text);
        }
    }
}
