namespace Controle_de_Ocorrencias
{
    partial class frm_cadMotorista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_nomeMoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbx_ativo = new System.Windows.Forms.CheckBox();
            this.cmbbx_setorMoto = new System.Windows.Forms.ComboBox();
            this.motoristaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_ocorrenciasDataSet = new Controle_de_Ocorrencias.controle_ocorrenciasDataSet();
            this.motoristaTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.motoristaTableAdapter();
            this.tableAdapterManager = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager();
            this.setormotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setor_motoTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.setor_motoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setormotoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_consultar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_consultar.Image = global::Controle_de_Ocorrencias.Properties.Resources._001_analytic;
            this.btn_consultar.Location = new System.Drawing.Point(200, 0);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(100, 100);
            this.btn_consultar.TabIndex = 3;
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
            this.btn_salvar.TabIndex = 2;
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
            this.btn_novo.TabIndex = 1;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(470, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 0;
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sair.Image = global::Controle_de_Ocorrencias.Properties.Resources._001_exit;
            this.btn_sair.Location = new System.Drawing.Point(0, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 100);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do motorista :";
            // 
            // txtbx_nomeMoto
            // 
            this.txtbx_nomeMoto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motoristaBindingSource, "motorista", true));
            this.txtbx_nomeMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nomeMoto.Location = new System.Drawing.Point(239, 154);
            this.txtbx_nomeMoto.Name = "txtbx_nomeMoto";
            this.txtbx_nomeMoto.Size = new System.Drawing.Size(272, 28);
            this.txtbx_nomeMoto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Setor do Motorista :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motorista ativo :";
            // 
            // chkbx_ativo
            // 
            this.chkbx_ativo.AutoSize = true;
            this.chkbx_ativo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motoristaBindingSource, "ativo", true));
            this.chkbx_ativo.Location = new System.Drawing.Point(239, 285);
            this.chkbx_ativo.Name = "chkbx_ativo";
            this.chkbx_ativo.Size = new System.Drawing.Size(18, 17);
            this.chkbx_ativo.TabIndex = 8;
            this.chkbx_ativo.UseVisualStyleBackColor = true;
            // 
            // cmbbx_setorMoto
            // 
            this.cmbbx_setorMoto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motoristaBindingSource, "setor_moto", true));
            this.cmbbx_setorMoto.DataSource = this.setormotoBindingSource;
            this.cmbbx_setorMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbx_setorMoto.FormattingEnabled = true;
            this.cmbbx_setorMoto.Location = new System.Drawing.Point(239, 219);
            this.cmbbx_setorMoto.Name = "cmbbx_setorMoto";
            this.cmbbx_setorMoto.Size = new System.Drawing.Size(272, 30);
            this.cmbbx_setorMoto.TabIndex = 9;
            this.cmbbx_setorMoto.SelectedIndexChanged += new System.EventHandler(this.cmbbx_setorMoto_SelectedIndexChanged);
            // 
            // motoristaBindingSource
            // 
            this.motoristaBindingSource.DataMember = "motorista";
            this.motoristaBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // controle_ocorrenciasDataSet
            // 
            this.controle_ocorrenciasDataSet.DataSetName = "controle_ocorrenciasDataSet";
            this.controle_ocorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // setormotoBindingSource
            // 
            this.setormotoBindingSource.DataMember = "setor_moto";
            this.setormotoBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // setor_motoTableAdapter
            // 
            this.setor_motoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_cadMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 349);
            this.ControlBox = false;
            this.Controls.Add(this.cmbbx_setorMoto);
            this.Controls.Add(this.chkbx_ativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_nomeMoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_cadMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar motorista";
            this.Load += new System.EventHandler(this.frm_cadMotorista_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setormotoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_nomeMoto;
        private controle_ocorrenciasDataSet controle_ocorrenciasDataSet;
        private System.Windows.Forms.BindingSource motoristaBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.motoristaTableAdapter motoristaTableAdapter;
        private controle_ocorrenciasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbx_ativo;
        private System.Windows.Forms.ComboBox cmbbx_setorMoto;
        private System.Windows.Forms.BindingSource setormotoBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.setor_motoTableAdapter setor_motoTableAdapter;
    }
}