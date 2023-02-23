namespace Controle_de_Ocorrencias
{
    partial class frm_consultMotorista
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.controle_ocorrenciasDataSet = new Controle_de_Ocorrencias.controle_ocorrenciasDataSet();
            this.motoristaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoristaTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.motoristaTableAdapter();
            this.tableAdapterManager = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager();
            this.motoristaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do motorista :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // controle_ocorrenciasDataSet
            // 
            this.controle_ocorrenciasDataSet.DataSetName = "controle_ocorrenciasDataSet";
            this.controle_ocorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motoristaBindingSource
            // 
            this.motoristaBindingSource.DataMember = "motorista";
            this.motoristaBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // motoristaTableAdapter
            // 
            this.motoristaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.func_outros_setoresTableAdapter = null;
            this.tableAdapterManager.motoristaTableAdapter = this.motoristaTableAdapter;
            this.tableAdapterManager.ocorrenciaTableAdapter = null;
            this.tableAdapterManager.setor_motoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            // 
            // motoristaDataGridView
            // 
            this.motoristaDataGridView.AllowUserToAddRows = false;
            this.motoristaDataGridView.AllowUserToDeleteRows = false;
            this.motoristaDataGridView.AutoGenerateColumns = false;
            this.motoristaDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.motoristaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.motoristaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.motoristaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.motoristaDataGridView.DataSource = this.motoristaBindingSource;
            this.motoristaDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.motoristaDataGridView.Location = new System.Drawing.Point(12, 161);
            this.motoristaDataGridView.Name = "motoristaDataGridView";
            this.motoristaDataGridView.ReadOnly = true;
            this.motoristaDataGridView.RowTemplate.Height = 24;
            this.motoristaDataGridView.Size = new System.Drawing.Size(515, 393);
            this.motoristaDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_motorista";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_motorista";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "motorista";
            this.dataGridViewTextBoxColumn2.HeaderText = "motorista";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "ativo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // frm_consultMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 566);
            this.Controls.Add(this.motoristaDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_consultMotorista";
            this.Text = "Consultar Motoristas";
            this.Load += new System.EventHandler(this.frm_consultMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private controle_ocorrenciasDataSet controle_ocorrenciasDataSet;
        private System.Windows.Forms.BindingSource motoristaBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.motoristaTableAdapter motoristaTableAdapter;
        private controle_ocorrenciasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView motoristaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}