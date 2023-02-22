namespace Controle_de_Ocorrencias
{
    partial class frm_consultVeiculo
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
            this.veiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_ocorrenciasDataSet = new Controle_de_Ocorrencias.controle_ocorrenciasDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_veiculo = new System.Windows.Forms.TextBox();
            this.txtbx_placa = new System.Windows.Forms.TextBox();
            this.veiculoTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.veiculoTableAdapter();
            this.tableAdapterManager = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // veiculoDataGridView
            // 
            this.veiculoDataGridView.AutoGenerateColumns = false;
            this.veiculoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.veiculoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.veiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.veiculoDataGridView.DataSource = this.veiculoBindingSource;
            this.veiculoDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.veiculoDataGridView.Location = new System.Drawing.Point(12, 258);
            this.veiculoDataGridView.Name = "veiculoDataGridView";
            this.veiculoDataGridView.RowTemplate.Height = 24;
            this.veiculoDataGridView.Size = new System.Drawing.Size(385, 358);
            this.veiculoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_motivo";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_motivo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "veiculo";
            this.dataGridViewTextBoxColumn2.HeaderText = "veiculo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "placa";
            this.dataGridViewTextBoxColumn3.HeaderText = "placa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "veiculo";
            this.veiculoBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // controle_ocorrenciasDataSet
            // 
            this.controle_ocorrenciasDataSet.DataSetName = "controle_ocorrenciasDataSet";
            this.controle_ocorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Procurar Veiculo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Procurar Placa :";
            // 
            // txtbx_veiculo
            // 
            this.txtbx_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_veiculo.Location = new System.Drawing.Point(187, 66);
            this.txtbx_veiculo.Name = "txtbx_veiculo";
            this.txtbx_veiculo.Size = new System.Drawing.Size(169, 28);
            this.txtbx_veiculo.TabIndex = 4;
            this.txtbx_veiculo.TextChanged += new System.EventHandler(this.txtbx_veiculo_TextChanged);
            // 
            // txtbx_placa
            // 
            this.txtbx_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_placa.Location = new System.Drawing.Point(187, 132);
            this.txtbx_placa.Name = "txtbx_placa";
            this.txtbx_placa.Size = new System.Drawing.Size(169, 28);
            this.txtbx_placa.TabIndex = 5;
            this.txtbx_placa.TextChanged += new System.EventHandler(this.txtbx_placa_TextChanged);
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.func_outros_setoresTableAdapter = null;
            this.tableAdapterManager.motoristaTableAdapter = null;
            this.tableAdapterManager.ocorrenciaTableAdapter = null;
            this.tableAdapterManager.setor_motoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = this.veiculoTableAdapter;
            // 
            // frm_consultVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 628);
            this.Controls.Add(this.txtbx_placa);
            this.Controls.Add(this.txtbx_veiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.veiculoDataGridView);
            this.Name = "frm_consultVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Veiculo";
            this.Load += new System.EventHandler(this.frm_consultVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veiculoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controle_ocorrenciasDataSet controle_ocorrenciasDataSet;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.veiculoTableAdapter veiculoTableAdapter;
        private controle_ocorrenciasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView veiculoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_veiculo;
        private System.Windows.Forms.TextBox txtbx_placa;
    }
}