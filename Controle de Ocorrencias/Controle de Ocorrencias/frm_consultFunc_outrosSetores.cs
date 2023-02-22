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
    public partial class frm_consultFunc_outrosSetores : Form
    {
        public frm_consultFunc_outrosSetores()
        {
            InitializeComponent();
        }

        private void func_outros_setoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.func_outros_setoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controle_ocorrenciasDataSet);

        }

        private void frm_consultFunc_outrosSetores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controle_ocorrenciasDataSet.func_outros_setores'. Você pode movê-la ou removê-la conforme necessário.
            this.func_outros_setoresTableAdapter.Fill(this.controle_ocorrenciasDataSet.func_outros_setores);

        }
    }
}
