namespace Controle_de_Ocorrencias
{
    partial class frm_abrirOcorrencia
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
            this.motoristaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoristaTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.motoristaTableAdapter();
            this.cmbbx_motorista = new System.Windows.Forms.ComboBox();
            this.ocorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.ocorrenciaTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.ocorrenciaTableAdapter();
            this.data_ocorrencia = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_ocorrencia = new System.Windows.Forms.TextBox();
            this.veiculoTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.veiculoTableAdapter();
            this.tableAdapterManager = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager();
            this.func_outros_setoresTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.func_outros_setoresTableAdapter();
            this.setoresTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.setoresTableAdapter();
            this.cmbbx_veiculo = new System.Windows.Forms.ComboBox();
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbbx_setorResp = new System.Windows.Forms.ComboBox();
            this.func_outros_setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbbx_FuncResp = new System.Windows.Forms.ComboBox();
            this.txtbx_ContraMedida = new System.Windows.Forms.TextBox();
            this.veiculoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_outros_setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // cmbbx_motorista
            // 
            this.cmbbx_motorista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "motorista", true));
            this.cmbbx_motorista.DataSource = this.motoristaBindingSource;
            this.cmbbx_motorista.DisplayMember = "motorista";
            this.cmbbx_motorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_motorista.FormattingEnabled = true;
            this.cmbbx_motorista.Location = new System.Drawing.Point(390, 170);
            this.cmbbx_motorista.Name = "cmbbx_motorista";
            this.cmbbx_motorista.Size = new System.Drawing.Size(255, 30);
            this.cmbbx_motorista.TabIndex = 0;
            this.cmbbx_motorista.ValueMember = "id_motorista";
            // 
            // ocorrenciaBindingSource
            // 
            this.ocorrenciaBindingSource.DataMember = "ocorrencia";
            this.ocorrenciaBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 100);
            this.panel1.TabIndex = 17;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_consultar.Image = global::Controle_de_Ocorrencias.Properties.Resources._001_analytic;
            this.btn_consultar.Location = new System.Drawing.Point(200, 0);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(100, 100);
            this.btn_consultar.TabIndex = 19;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_salvar.Image = global::Controle_de_Ocorrencias.Properties.Resources._003_ponto_de_verificacao;
            this.btn_salvar.Location = new System.Drawing.Point(100, 0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(100, 100);
            this.btn_salvar.TabIndex = 18;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_novo.Image = global::Controle_de_Ocorrencias.Properties.Resources._002_inserir;
            this.btn_novo.Location = new System.Drawing.Point(0, 0);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 100);
            this.btn_novo.TabIndex = 17;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(597, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 100);
            this.panel2.TabIndex = 0;
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sair.Image = global::Controle_de_Ocorrencias.Properties.Resources._001_exit;
            this.btn_sair.Location = new System.Drawing.Point(2, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 100);
            this.btn_sair.TabIndex = 18;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // ocorrenciaTableAdapter
            // 
            this.ocorrenciaTableAdapter.ClearBeforeFill = true;
            // 
            // data_ocorrencia
            // 
            this.data_ocorrencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "data_ocorrencia", true));
            this.data_ocorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_ocorrencia.Location = new System.Drawing.Point(206, 120);
            this.data_ocorrencia.Name = "data_ocorrencia";
            this.data_ocorrencia.Size = new System.Drawing.Size(370, 28);
            this.data_ocorrencia.TabIndex = 19;
            this.data_ocorrencia.Value = new System.DateTime(2023, 2, 22, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data da Ocorrencia :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Motorista :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veiculo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Setor responsavel pela ocorrencia :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Funcionario responsavel :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ocorrencia :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 578);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contra Medida :";
            // 
            // txtbx_ocorrencia
            // 
            this.txtbx_ocorrencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "ocorrencia", true));
            this.txtbx_ocorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ocorrencia.Location = new System.Drawing.Point(161, 373);
            this.txtbx_ocorrencia.Multiline = true;
            this.txtbx_ocorrencia.Name = "txtbx_ocorrencia";
            this.txtbx_ocorrencia.Size = new System.Drawing.Size(484, 180);
            this.txtbx_ocorrencia.TabIndex = 14;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.func_outros_setoresTableAdapter = this.func_outros_setoresTableAdapter;
            this.tableAdapterManager.motoristaTableAdapter = this.motoristaTableAdapter;
            this.tableAdapterManager.ocorrenciaTableAdapter = this.ocorrenciaTableAdapter;
            this.tableAdapterManager.setor_motoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = this.setoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = this.veiculoTableAdapter;
            // 
            // func_outros_setoresTableAdapter
            // 
            this.func_outros_setoresTableAdapter.ClearBeforeFill = true;
            // 
            // setoresTableAdapter
            // 
            this.setoresTableAdapter.ClearBeforeFill = true;
            // 
            // cmbbx_veiculo
            // 
            this.cmbbx_veiculo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "veiculo", true));
            this.cmbbx_veiculo.DataSource = this.veiculoBindingSource1;
            this.cmbbx_veiculo.DisplayMember = "veiculo";
            this.cmbbx_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_veiculo.FormattingEnabled = true;
            this.cmbbx_veiculo.Location = new System.Drawing.Point(119, 170);
            this.cmbbx_veiculo.Name = "cmbbx_veiculo";
            this.cmbbx_veiculo.Size = new System.Drawing.Size(121, 30);
            this.cmbbx_veiculo.TabIndex = 22;
            this.cmbbx_veiculo.ValueMember = "id_motivo";
            // 
            // setoresBindingSource
            // 
            this.setoresBindingSource.DataMember = "setores";
            this.setoresBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // cmbbx_setorResp
            // 
            this.cmbbx_setorResp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "setor_motivo", true));
            this.cmbbx_setorResp.DataSource = this.setoresBindingSource;
            this.cmbbx_setorResp.DisplayMember = "setor";
            this.cmbbx_setorResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_setorResp.FormattingEnabled = true;
            this.cmbbx_setorResp.Location = new System.Drawing.Point(337, 238);
            this.cmbbx_setorResp.Name = "cmbbx_setorResp";
            this.cmbbx_setorResp.Size = new System.Drawing.Size(308, 30);
            this.cmbbx_setorResp.TabIndex = 23;
            this.cmbbx_setorResp.ValueMember = "id_setores";
            // 
            // func_outros_setoresBindingSource
            // 
            this.func_outros_setoresBindingSource.DataMember = "func_outros_setores";
            this.func_outros_setoresBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // cmbbx_FuncResp
            // 
            this.cmbbx_FuncResp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "fun_outros_setores", true));
            this.cmbbx_FuncResp.DataSource = this.func_outros_setoresBindingSource;
            this.cmbbx_FuncResp.DisplayMember = "nome_fun";
            this.cmbbx_FuncResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_FuncResp.FormattingEnabled = true;
            this.cmbbx_FuncResp.Location = new System.Drawing.Point(337, 299);
            this.cmbbx_FuncResp.Name = "cmbbx_FuncResp";
            this.cmbbx_FuncResp.Size = new System.Drawing.Size(308, 30);
            this.cmbbx_FuncResp.TabIndex = 24;
            this.cmbbx_FuncResp.ValueMember = "id_fun";
            // 
            // txtbx_ContraMedida
            // 
            this.txtbx_ContraMedida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ocorrenciaBindingSource, "contra_medida", true));
            this.txtbx_ContraMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ContraMedida.Location = new System.Drawing.Point(161, 575);
            this.txtbx_ContraMedida.Multiline = true;
            this.txtbx_ContraMedida.Name = "txtbx_ContraMedida";
            this.txtbx_ContraMedida.Size = new System.Drawing.Size(484, 180);
            this.txtbx_ContraMedida.TabIndex = 25;
            // 
            // veiculoBindingSource1
            // 
            this.veiculoBindingSource1.DataMember = "veiculo";
            this.veiculoBindingSource1.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_imprimir.Image = global::Controle_de_Ocorrencias.Properties.Resources._001_analytic;
            this.btn_imprimir.Location = new System.Drawing.Point(300, 0);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(100, 100);
            this.btn_imprimir.TabIndex = 20;
            this.btn_imprimir.Text = "imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // frm_abrirOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 783);
            this.ControlBox = false;
            this.Controls.Add(this.txtbx_ContraMedida);
            this.Controls.Add(this.cmbbx_FuncResp);
            this.Controls.Add(this.cmbbx_setorResp);
            this.Controls.Add(this.cmbbx_veiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_ocorrencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_ocorrencia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbbx_motorista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "frm_abrirOcorrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Ocorrencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocorrenciaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.func_outros_setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private controle_ocorrenciasDataSet controle_ocorrenciasDataSet;
        private System.Windows.Forms.BindingSource motoristaBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.motoristaTableAdapter motoristaTableAdapter;
        private System.Windows.Forms.ComboBox cmbbx_motorista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.BindingSource ocorrenciaBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.ocorrenciaTableAdapter ocorrenciaTableAdapter;
        private System.Windows.Forms.DateTimePicker data_ocorrencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_ocorrencia;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.veiculoTableAdapter veiculoTableAdapter;
        private controle_ocorrenciasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbbx_veiculo;
        private controle_ocorrenciasDataSetTableAdapters.setoresTableAdapter setoresTableAdapter;
        private System.Windows.Forms.BindingSource setoresBindingSource;
        private System.Windows.Forms.ComboBox cmbbx_setorResp;
        private controle_ocorrenciasDataSetTableAdapters.func_outros_setoresTableAdapter func_outros_setoresTableAdapter;
        private System.Windows.Forms.BindingSource func_outros_setoresBindingSource;
        private System.Windows.Forms.ComboBox cmbbx_FuncResp;
        private System.Windows.Forms.TextBox txtbx_ContraMedida;
        private System.Windows.Forms.BindingSource veiculoBindingSource1;
        private System.Windows.Forms.Button btn_imprimir;
    }
}