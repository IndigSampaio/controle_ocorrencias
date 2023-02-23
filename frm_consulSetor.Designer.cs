namespace Controle_de_Ocorrencias
{
    partial class frm_consulSetor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controle_ocorrenciasDataSet = new Controle_de_Ocorrencias.controle_ocorrenciasDataSet();
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setoresTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.setoresTableAdapter();
            this.tableAdapterManager = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager();
            this.setoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_consSetor = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // controle_ocorrenciasDataSet
            // 
            this.controle_ocorrenciasDataSet.DataSetName = "controle_ocorrenciasDataSet";
            this.controle_ocorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // setoresBindingSource
            // 
            this.setoresBindingSource.DataMember = "setores";
            this.setoresBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // setoresTableAdapter
            // 
            this.setoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.func_outros_setoresTableAdapter = null;
            this.tableAdapterManager.motoristaTableAdapter = null;
            this.tableAdapterManager.ocorrenciaTableAdapter = null;
            this.tableAdapterManager.setor_motoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = this.setoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            // 
            // setoresDataGridView
            // 
            this.setoresDataGridView.AllowUserToAddRows = false;
            this.setoresDataGridView.AllowUserToDeleteRows = false;
            this.setoresDataGridView.AutoGenerateColumns = false;
            this.setoresDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.setoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.setoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.setoresDataGridView.DataSource = this.setoresBindingSource;
            this.setoresDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.setoresDataGridView.Location = new System.Drawing.Point(15, 137);
            this.setoresDataGridView.Name = "setoresDataGridView";
            this.setoresDataGridView.ReadOnly = true;
            this.setoresDataGridView.RowTemplate.Height = 24;
            this.setoresDataGridView.Size = new System.Drawing.Size(313, 402);
            this.setoresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_setores";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_setores";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "setor";
            this.dataGridViewTextBoxColumn2.HeaderText = "setor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Procurar Setor :";
            // 
            // txtbx_consSetor
            // 
            this.txtbx_consSetor.Location = new System.Drawing.Point(127, 32);
            this.txtbx_consSetor.Name = "txtbx_consSetor";
            this.txtbx_consSetor.Size = new System.Drawing.Size(201, 22);
            this.txtbx_consSetor.TabIndex = 3;
            this.txtbx_consSetor.TextChanged += new System.EventHandler(this.txtbx_consSetor_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // frm_consulSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 559);
            this.Controls.Add(this.txtbx_consSetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setoresDataGridView);
            this.Name = "frm_consulSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_consulSetor";
            this.Load += new System.EventHandler(this.frm_consulSetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controle_ocorrenciasDataSet controle_ocorrenciasDataSet;
        private System.Windows.Forms.BindingSource setoresBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.setoresTableAdapter setoresTableAdapter;
        private controle_ocorrenciasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView setoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_consSetor;
        private System.Windows.Forms.Timer timer1;
    }
}