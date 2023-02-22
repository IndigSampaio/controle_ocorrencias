namespace Controle_de_Ocorrencias
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btn_cadSetor
            // 
            this.btn_cadSetor.Location = new System.Drawing.Point(12, 95);
            this.btn_cadSetor.Name = "btn_cadSetor";
            this.btn_cadSetor.Size = new System.Drawing.Size(196, 96);
            this.btn_cadSetor.TabIndex = 0;
            this.btn_cadSetor.Text = "Cadastrar Setores";
            this.btn_cadSetor.UseVisualStyleBackColor = true;
            this.btn_cadSetor.Click += new System.EventHandler(this.btn_cadSetor_Click);
            // 
            // btn_cadVeic
            // 
            this.btn_cadVeic.Location = new System.Drawing.Point(12, 217);
            this.btn_cadVeic.Name = "btn_cadVeic";
            this.btn_cadVeic.Size = new System.Drawing.Size(196, 96);
            this.btn_cadVeic.TabIndex = 1;
            this.btn_cadVeic.Text = "Cadastrar Veiculos";
            this.btn_cadVeic.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 741);
            this.Controls.Add(this.btn_cadVeic);
            this.Controls.Add(this.btn_cadSetor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadSetor;
        private System.Windows.Forms.Button btn_cadVeic;
        private System.Windows.Forms.Timer timer1;
    }
}

