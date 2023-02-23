namespace Controle_de_Ocorrencias
{
    partial class frm_consulOcorrencia
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
            System.Windows.Forms.Label data_ocorrenciaLabel;
            System.Windows.Forms.Label veiculoLabel;
            System.Windows.Forms.Label motoristaLabel;
            System.Windows.Forms.Label setor_motivoLabel;
            this.controle_ocorrenciasDataSet = new Controle_de_Ocorrencias.controle_ocorrenciasDataSet();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocorrenciaTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.ocorrenciaTableAdapter();
            this.tableAdapterManager = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ocorrenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ocorrenciaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.veiculoComboBox = new System.Windows.Forms.ComboBox();
            this.motoristaComboBox = new System.Windows.Forms.ComboBox();
            this.setor_motivoComboBox = new System.Windows.Forms.ComboBox();
            data_ocorrenciaLabel = new System.Windows.Forms.Label();
            veiculoLabel = new System.Windows.Forms.Label();
            motoristaLabel = new System.Windows.Forms.Label();
            setor_motivoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // data_ocorrenciaLabel
            // 
            data_ocorrenciaLabel.AutoSize = true;
            data_ocorrenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_ocorrenciaLabel.Location = new System.Drawing.Point(167, 58);
            data_ocorrenciaLabel.Name = "data_ocorrenciaLabel";
            data_ocorrenciaLabel.Size = new System.Drawing.Size(172, 24);
            data_ocorrenciaLabel.TabIndex = 1;
            data_ocorrenciaLabel.Text = "Data da Ocorrencia";
            // 
            // veiculoLabel
            // 
            veiculoLabel.AutoSize = true;
            veiculoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            veiculoLabel.Location = new System.Drawing.Point(12, 117);
            veiculoLabel.Name = "veiculoLabel";
            veiculoLabel.Size = new System.Drawing.Size(79, 24);
            veiculoLabel.TabIndex = 3;
            veiculoLabel.Text = "Veiculo:";
            // 
            // motoristaLabel
            // 
            motoristaLabel.AutoSize = true;
            motoristaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            motoristaLabel.Location = new System.Drawing.Point(311, 117);
            motoristaLabel.Name = "motoristaLabel";
            motoristaLabel.Size = new System.Drawing.Size(90, 24);
            motoristaLabel.TabIndex = 5;
            motoristaLabel.Text = "Motorista:";
            // 
            // setor_motivoLabel
            // 
            setor_motivoLabel.AutoSize = true;
            setor_motivoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            setor_motivoLabel.Location = new System.Drawing.Point(573, 117);
            setor_motivoLabel.Name = "setor_motivoLabel";
            setor_motivoLabel.Size = new System.Drawing.Size(119, 24);
            setor_motivoLabel.TabIndex = 7;
            setor_motivoLabel.Text = "Setor Motivo:";
            // 
            // controle_ocorrenciasDataSet
            // 
            this.controle_ocorrenciasDataSet.DataSetName = "controle_ocorrenciasDataSet";
            this.controle_ocorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ocorrenciaBindingSource
            // 
            this.ocorrenciaBindingSource.DataMember = "ocorrencia";
            this.ocorrenciaBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // ocorrenciaTableAdapter
            // 
            this.ocorrenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.func_outros_setoresTableAdapter = null;
            this.tableAdapterManager.motoristaTableAdapter = null;
            this.tableAdapterManager.ocorrenciaTableAdapter = this.ocorrenciaTableAdapter;
            this.tableAdapterManager.setor_motoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ocorrenciaDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 555);
            this.panel1.TabIndex = 1;
            // 
            // ocorrenciaDataGridView
            // 
            this.ocorrenciaDataGridView.AllowUserToAddRows = false;
            this.ocorrenciaDataGridView.AllowUserToDeleteRows = false;
            this.ocorrenciaDataGridView.AutoGenerateColumns = false;
            this.ocorrenciaDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ocorrenciaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ocorrenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ocorrenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.ocorrenciaDataGridView.DataSource = this.ocorrenciaBindingSource;
            this.ocorrenciaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ocorrenciaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ocorrenciaDataGridView.Name = "ocorrenciaDataGridView";
            this.ocorrenciaDataGridView.ReadOnly = true;
            this.ocorrenciaDataGridView.RowTemplate.Height = 24;
            this.ocorrenciaDataGridView.Size = new System.Drawing.Size(903, 555);
            this.ocorrenciaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_ocorrencia";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Ocorrencia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_ocorrencia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "veiculo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Veiculo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "motorista";
            this.dataGridViewTextBoxColumn4.HeaderText = "Motorista";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "setor_motivo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Setor do Motivo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fun_outros_setores";
            this.dataGridViewTextBoxColumn6.HeaderText = "Funcionario de outros Setores";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ocorrencia";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ocorrencia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "contra_medida";
            this.dataGridViewTextBoxColumn8.HeaderText = "Contra Medidas";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // data_ocorrenciaDateTimePicker
            // 
            this.data_ocorrenciaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ocorrenciaBindingSource, "data_ocorrencia", true));
            this.data_ocorrenciaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_ocorrenciaDateTimePicker.Location = new System.Drawing.Point(362, 53);
            this.data_ocorrenciaDateTimePicker.Name = "data_ocorrenciaDateTimePicker";
            this.data_ocorrenciaDateTimePicker.Size = new System.Drawing.Size(368, 28);
            this.data_ocorrenciaDateTimePicker.TabIndex = 2;
            this.data_ocorrenciaDateTimePicker.Value = new System.DateTime(2023, 2, 22, 0, 0, 0, 0);
            // 
            // veiculoComboBox
            // 
            this.veiculoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "veiculo", true));
            this.veiculoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiculoComboBox.FormattingEnabled = true;
            this.veiculoComboBox.Location = new System.Drawing.Point(97, 114);
            this.veiculoComboBox.Name = "veiculoComboBox";
            this.veiculoComboBox.Size = new System.Drawing.Size(146, 30);
            this.veiculoComboBox.TabIndex = 4;
            // 
            // motoristaComboBox
            // 
            this.motoristaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "motorista", true));
            this.motoristaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motoristaComboBox.FormattingEnabled = true;
            this.motoristaComboBox.Location = new System.Drawing.Point(419, 114);
            this.motoristaComboBox.Name = "motoristaComboBox";
            this.motoristaComboBox.Size = new System.Drawing.Size(121, 30);
            this.motoristaComboBox.TabIndex = 6;
            // 
            // setor_motivoComboBox
            // 
            this.setor_motivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "setor_motivo", true));
            this.setor_motivoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setor_motivoComboBox.FormattingEnabled = true;
            this.setor_motivoComboBox.Location = new System.Drawing.Point(707, 114);
            this.setor_motivoComboBox.Name = "setor_motivoComboBox";
            this.setor_motivoComboBox.Size = new System.Drawing.Size(144, 30);
            this.setor_motivoComboBox.TabIndex = 8;
            // 
            // frm_consulOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 830);
            this.Controls.Add(setor_motivoLabel);
            this.Controls.Add(this.setor_motivoComboBox);
            this.Controls.Add(motoristaLabel);
            this.Controls.Add(this.motoristaComboBox);
            this.Controls.Add(veiculoLabel);
            this.Controls.Add(this.veiculoComboBox);
            this.Controls.Add(data_ocorrenciaLabel);
            this.Controls.Add(this.data_ocorrenciaDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Name = "frm_consulOcorrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Ocorrencias";
            this.Load += new System.EventHandler(this.frm_consulOcorrencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controle_ocorrenciasDataSet controle_ocorrenciasDataSet;
        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.ocorrenciaTableAdapter ocorrenciaTableAdapter;
        private controle_ocorrenciasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ocorrenciaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DateTimePicker data_ocorrenciaDateTimePicker;
        private System.Windows.Forms.ComboBox veiculoComboBox;
        private System.Windows.Forms.ComboBox motoristaComboBox;
        private System.Windows.Forms.ComboBox setor_motivoComboBox;
    }
}