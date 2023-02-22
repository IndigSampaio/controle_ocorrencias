namespace Controle_de_Ocorrencias
{
    partial class frm_cadSetor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_setor = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_ocorrenciasDataSet = new Controle_de_Ocorrencias.controle_ocorrenciasDataSet();
            this.setoresTableAdapter = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.setoresTableAdapter();
            this.tableAdapterManager = new Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(323, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 100);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Setor :";
            // 
            // txtbx_setor
            // 
            this.txtbx_setor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setoresBindingSource, "setor", true));
            this.txtbx_setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_setor.Location = new System.Drawing.Point(114, 167);
            this.txtbx_setor.Name = "txtbx_setor";
            this.txtbx_setor.Size = new System.Drawing.Size(232, 28);
            this.txtbx_setor.TabIndex = 3;
            this.txtbx_setor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_sair
            // 
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sair.Image = global::Controle_de_Ocorrencias.Properties.Resources._001_exit;
            this.btn_sair.Location = new System.Drawing.Point(0, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(102, 100);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Image = global::Controle_de_Ocorrencias.Properties.Resources._001_analytic;
            this.button3.Location = new System.Drawing.Point(200, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consultar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_salvar.Image = global::Controle_de_Ocorrencias.Properties.Resources._003_ponto_de_verificacao;
            this.btn_salvar.Location = new System.Drawing.Point(100, 0);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(100, 100);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_novo.Image = global::Controle_de_Ocorrencias.Properties.Resources._002_inserir;
            this.btn_novo.Location = new System.Drawing.Point(0, 0);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 100);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // setoresBindingSource
            // 
            this.setoresBindingSource.DataMember = "setores";
            this.setoresBindingSource.DataSource = this.controle_ocorrenciasDataSet;
            // 
            // controle_ocorrenciasDataSet
            // 
            this.controle_ocorrenciasDataSet.DataSetName = "controle_ocorrenciasDataSet";
            this.controle_ocorrenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // setoresTableAdapter
            // 
            this.setoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.motoristaTableAdapter = null;
            this.tableAdapterManager.ocorrenciaTableAdapter = null;
            this.tableAdapterManager.outros_setoresTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = this.setoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Controle_de_Ocorrencias.controle_ocorrenciasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veiculoTableAdapter = null;
            // 
            // frm_cadSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 257);
            this.Controls.Add(this.txtbx_setor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_cadSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cadSetor";
            this.Load += new System.EventHandler(this.frm_cadSetor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_ocorrenciasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label label1;
        private controle_ocorrenciasDataSet controle_ocorrenciasDataSet;
        private System.Windows.Forms.BindingSource setoresBindingSource;
        private controle_ocorrenciasDataSetTableAdapters.setoresTableAdapter setoresTableAdapter;
        private controle_ocorrenciasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtbx_setor;
    }
}