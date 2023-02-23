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
    public partial class frm_consulOcorrencia : Form
    {
        public frm_consulOcorrencia()
        {
            InitializeComponent();
        }

        private void ocorrenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ocorrenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);

        }

        private void frm_consulOcorrencia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.ocorrencia'. Você pode movê-la ou removê-la conforme necessário.
            this.ocorrenciaTableAdapter.Fill(this.controle_ocorrenciasDataSet.ocorrencia);

        }
    }
}
