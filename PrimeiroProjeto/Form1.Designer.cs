namespace PrimeiroProjeto
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
            this.Ligar = new System.Windows.Forms.Button();
            this.Desligar = new System.Windows.Forms.Button();
            this.Detalhes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ligar
            // 
            this.Ligar.Location = new System.Drawing.Point(25, 60);
            this.Ligar.Name = "Ligar";
            this.Ligar.Size = new System.Drawing.Size(123, 100);
            this.Ligar.TabIndex = 0;
            this.Ligar.Text = "Ligar";
            this.Ligar.UseVisualStyleBackColor = true;
            this.Ligar.Click += new System.EventHandler(this.Ligar_Click);
            // 
            // Desligar
            // 
            this.Desligar.Location = new System.Drawing.Point(376, 60);
            this.Desligar.Name = "Desligar";
            this.Desligar.Size = new System.Drawing.Size(137, 100);
            this.Desligar.TabIndex = 1;
            this.Desligar.Text = "Desligar";
            this.Desligar.UseVisualStyleBackColor = true;
            this.Desligar.Click += new System.EventHandler(this.Desligar_Click);
            // 
            // Detalhes
            // 
            this.Detalhes.Location = new System.Drawing.Point(730, 60);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(137, 100);
            this.Detalhes.TabIndex = 2;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(916, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.Desligar);
            this.Controls.Add(this.Ligar);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Janela1;
        private System.Windows.Forms.Button Botao1;
        private System.Windows.Forms.GroupBox Janela2;
        private System.Windows.Forms.Button Botao2;
        private System.Windows.Forms.Button Ligar;
        private System.Windows.Forms.Button Desligar;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.Button button1;
    }
}

