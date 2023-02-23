namespace Controle_de_Ocorrencias
{
    partial class frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_cadSetor = new System.Windows.Forms.Button();
            this.btn_cadVeic = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_consultFunOutrosSetores = new System.Windows.Forms.Button();
            this.btn_consultMoto = new System.Windows.Forms.Button();
            this.btn_consultVeic = new System.Windows.Forms.Button();
            this.btn_consulSetores = new System.Windows.Forms.Button();
            this.btn_consulOcorrencias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadSetor
            // 
            this.btn_cadSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadSetor.Location = new System.Drawing.Point(12, 35);
            this.btn_cadSetor.Name = "btn_cadSetor";
            this.btn_cadSetor.Size = new System.Drawing.Size(239, 136);
            this.btn_cadSetor.TabIndex = 0;
            this.btn_cadSetor.Text = "Cadastrar Setores";
            this.btn_cadSetor.UseVisualStyleBackColor = true;
            this.btn_cadSetor.Click += new System.EventHandler(this.btn_cadSetor_Click);
            // 
            // btn_cadVeic
            // 
            this.btn_cadVeic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadVeic.Location = new System.Drawing.Point(502, 35);
            this.btn_cadVeic.Name = "btn_cadVeic";
            this.btn_cadVeic.Size = new System.Drawing.Size(239, 136);
            this.btn_cadVeic.TabIndex = 1;
            this.btn_cadVeic.Text = "Cadastrar Veiculos";
            this.btn_cadVeic.UseVisualStyleBackColor = true;
            this.btn_cadVeic.Click += new System.EventHandler(this.btn_cadVeic_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(747, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 136);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar Motorista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(257, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 136);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cadastrar Funcionarios de Outros Setores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 178);
            this.button3.TabIndex = 4;
            this.button3.Text = "Abrir Ocorrencia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_consultFunOutrosSetores
            // 
            this.btn_consultFunOutrosSetores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultFunOutrosSetores.Location = new System.Drawing.Point(257, 196);
            this.btn_consultFunOutrosSetores.Name = "btn_consultFunOutrosSetores";
            this.btn_consultFunOutrosSetores.Size = new System.Drawing.Size(239, 136);
            this.btn_consultFunOutrosSetores.TabIndex = 8;
            this.btn_consultFunOutrosSetores.Text = "Consultar Funcionarios de Outros Setores";
            this.btn_consultFunOutrosSetores.UseVisualStyleBackColor = true;
            this.btn_consultFunOutrosSetores.Click += new System.EventHandler(this.btn_consultFunOutrosSetores_Click);
            // 
            // btn_consultMoto
            // 
            this.btn_consultMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultMoto.Location = new System.Drawing.Point(747, 196);
            this.btn_consultMoto.Name = "btn_consultMoto";
            this.btn_consultMoto.Size = new System.Drawing.Size(239, 136);
            this.btn_consultMoto.TabIndex = 7;
            this.btn_consultMoto.Text = "Consultar Motorista";
            this.btn_consultMoto.UseVisualStyleBackColor = true;
            this.btn_consultMoto.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_consultVeic
            // 
            this.btn_consultVeic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultVeic.Location = new System.Drawing.Point(502, 196);
            this.btn_consultVeic.Name = "btn_consultVeic";
            this.btn_consultVeic.Size = new System.Drawing.Size(239, 136);
            this.btn_consultVeic.TabIndex = 6;
            this.btn_consultVeic.Text = "Consultar Veiculos";
            this.btn_consultVeic.UseVisualStyleBackColor = true;
            this.btn_consultVeic.Click += new System.EventHandler(this.btn_consultVeic_Click);
            // 
            // btn_consulSetores
            // 
            this.btn_consulSetores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulSetores.Location = new System.Drawing.Point(12, 196);
            this.btn_consulSetores.Name = "btn_consulSetores";
            this.btn_consulSetores.Size = new System.Drawing.Size(239, 136);
            this.btn_consulSetores.TabIndex = 5;
            this.btn_consulSetores.Text = "Consultar Setores";
            this.btn_consulSetores.UseVisualStyleBackColor = true;
            this.btn_consulSetores.Click += new System.EventHandler(this.btn_consulSetores_Click);
            // 
            // btn_consulOcorrencias
            // 
            this.btn_consulOcorrencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulOcorrencias.Location = new System.Drawing.Point(671, 462);
            this.btn_consulOcorrencias.Name = "btn_consulOcorrencias";
            this.btn_consulOcorrencias.Size = new System.Drawing.Size(315, 178);
            this.btn_consulOcorrencias.TabIndex = 9;
            this.btn_consulOcorrencias.Text = "Consultar Ocorrencias";
            this.btn_consulOcorrencias.UseVisualStyleBackColor = true;
            this.btn_consulOcorrencias.Click += new System.EventHandler(this.btn_consulOcorrencias_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 741);
            this.Controls.Add(this.btn_consulOcorrencias);
            this.Controls.Add(this.btn_consultFunOutrosSetores);
            this.Controls.Add(this.btn_consultMoto);
            this.Controls.Add(this.btn_consultVeic);
            this.Controls.Add(this.btn_consulSetores);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cadVeic);
            this.Controls.Add(this.btn_cadSetor);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadSetor;
        private System.Windows.Forms.Button btn_cadVeic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_consultFunOutrosSetores;
        private System.Windows.Forms.Button btn_consultMoto;
        private System.Windows.Forms.Button btn_consultVeic;
        private System.Windows.Forms.Button btn_consulSetores;
        private System.Windows.Forms.Button btn_consulOcorrencias;
    }
}

