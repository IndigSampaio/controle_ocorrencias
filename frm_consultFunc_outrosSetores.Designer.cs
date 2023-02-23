namespace Controle_de_Ocorrencias
{
    partial class frm_consultFunc_outrosSetores
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
            this.func_outros_setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.func_outros_setoresTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.func_outros_setoresTableAdapter();
            this.tableAdapterManager = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager();
            this.func_outros_setoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_outros_setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_outros_setoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // controle_ocorrenciasDataSet
            // 
            this.controle_ocorrenciasDataSet.DataSetName = "controle_ocorrenciasDataSet";
            this.controle_ocorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // func_outros_setoresBindingSource
            // 
            this.func_outros_setoresBindingSource.DataMember = "func_outros_setores";
            this.func_outros_setoresBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // func_outros_setoresTableAdapter
            // 
            this.func_outros_setoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.func_outros_setoresTableAdapter = this.func_outros_setoresTableAdapter;
            this.tableAdapterManager.motoristaTableAdapter = null;
            this.tableAdapterManager.ocorrenciaTableAdapter = null;
            this.tableAdapterManager.setor_motoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            // 
            // func_outros_setoresDataGridView
            // 
            this.func_outros_setoresDataGridView.AllowUserToAddRows = false;
            this.func_outros_setoresDataGridView.AllowUserToDeleteRows = false;
            this.func_outros_setoresDataGridView.AutoGenerateColumns = false;
            this.func_outros_setoresDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.func_outros_setoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.func_outros_setoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.func_outros_setoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.func_outros_setoresDataGridView.DataSource = this.func_outros_setoresBindingSource;
            this.func_outros_setoresDataGridView.Location = new System.Drawing.Point(12, 232);
            this.func_outros_setoresDataGridView.Name = "func_outros_setoresDataGridView";
            this.func_outros_setoresDataGridView.ReadOnly = true;
            this.func_outros_setoresDataGridView.RowTemplate.Height = 24;
            this.func_outros_setoresDataGridView.Size = new System.Drawing.Size(412, 220);
            this.func_outros_setoresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_fun";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_fun";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_fun";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_fun";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "setor";
            this.dataGridViewTextBoxColumn3.HeaderText = "setor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Setor :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 28);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.func_outros_setoresBindingSource;
            this.comboBox1.DisplayMember = "setor";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 30);
            this.comboBox1.TabIndex = 5;
            // 
            // frm_consultFunc_outrosSetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(440, 488);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.func_outros_setoresDataGridView);
            this.Name = "frm_consultFunc_outrosSetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Funcionarios";
            this.Load += new System.EventHandler(this.frm_consultFunc_outrosSetores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_outros_setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_outros_setoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controle_ocorrenciasDataSet controle_ocorrenciasDataSet;
        private System.Windows.Forms.BindingSource func_outros_setoresBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.func_outros_setoresTableAdapter func_outros_setoresTableAdapter;
        private controle_ocorrenciasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView func_outros_setoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}