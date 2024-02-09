namespace Calculadora_Forms
{
    partial class Calculadora
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
            this.bd1 = new System.Windows.Forms.Button();
            this.bd2 = new System.Windows.Forms.Button();
            this.bd3 = new System.Windows.Forms.Button();
            this.bd4 = new System.Windows.Forms.Button();
            this.bd5 = new System.Windows.Forms.Button();
            this.bd6 = new System.Windows.Forms.Button();
            this.bd7 = new System.Windows.Forms.Button();
            this.bd8 = new System.Windows.Forms.Button();
            this.bd9 = new System.Windows.Forms.Button();
            this.bd0 = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.tbOperacao = new System.Windows.Forms.TextBox();
            this.btMais = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bd1
            // 
            this.bd1.Location = new System.Drawing.Point(80, 330);
            this.bd1.Name = "bd1";
            this.bd1.Size = new System.Drawing.Size(75, 23);
            this.bd1.TabIndex = 0;
            this.bd1.Text = "1";
            this.bd1.UseVisualStyleBackColor = true;
            this.bd1.Click += new System.EventHandler(this.bd1_Click);
            // 
            // bd2
            // 
            this.bd2.Location = new System.Drawing.Point(187, 330);
            this.bd2.Name = "bd2";
            this.bd2.Size = new System.Drawing.Size(75, 23);
            this.bd2.TabIndex = 1;
            this.bd2.Text = "2";
            this.bd2.UseVisualStyleBackColor = true;
            // 
            // bd3
            // 
            this.bd3.Location = new System.Drawing.Point(302, 330);
            this.bd3.Name = "bd3";
            this.bd3.Size = new System.Drawing.Size(75, 23);
            this.bd3.TabIndex = 2;
            this.bd3.Text = "3";
            this.bd3.UseVisualStyleBackColor = true;
            // 
            // bd4
            // 
            this.bd4.Location = new System.Drawing.Point(80, 279);
            this.bd4.Name = "bd4";
            this.bd4.Size = new System.Drawing.Size(75, 23);
            this.bd4.TabIndex = 3;
            this.bd4.Text = "4";
            this.bd4.UseVisualStyleBackColor = true;
            // 
            // bd5
            // 
            this.bd5.Location = new System.Drawing.Point(187, 279);
            this.bd5.Name = "bd5";
            this.bd5.Size = new System.Drawing.Size(75, 23);
            this.bd5.TabIndex = 4;
            this.bd5.Text = "5";
            this.bd5.UseVisualStyleBackColor = true;
            // 
            // bd6
            // 
            this.bd6.Location = new System.Drawing.Point(302, 279);
            this.bd6.Name = "bd6";
            this.bd6.Size = new System.Drawing.Size(75, 23);
            this.bd6.TabIndex = 5;
            this.bd6.Text = "6";
            this.bd6.UseVisualStyleBackColor = true;
            // 
            // bd7
            // 
            this.bd7.Location = new System.Drawing.Point(80, 231);
            this.bd7.Name = "bd7";
            this.bd7.Size = new System.Drawing.Size(75, 23);
            this.bd7.TabIndex = 6;
            this.bd7.Text = "7";
            this.bd7.UseVisualStyleBackColor = true;
            // 
            // bd8
            // 
            this.bd8.Location = new System.Drawing.Point(187, 231);
            this.bd8.Name = "bd8";
            this.bd8.Size = new System.Drawing.Size(75, 23);
            this.bd8.TabIndex = 7;
            this.bd8.Text = "8";
            this.bd8.UseVisualStyleBackColor = true;
            // 
            // bd9
            // 
            this.bd9.Location = new System.Drawing.Point(302, 231);
            this.bd9.Name = "bd9";
            this.bd9.Size = new System.Drawing.Size(75, 23);
            this.bd9.TabIndex = 8;
            this.bd9.Text = "9";
            this.bd9.UseVisualStyleBackColor = true;
            // 
            // bd0
            // 
            this.bd0.Location = new System.Drawing.Point(187, 384);
            this.bd0.Name = "bd0";
            this.bd0.Size = new System.Drawing.Size(75, 23);
            this.bd0.TabIndex = 9;
            this.bd0.Text = "0";
            this.bd0.UseVisualStyleBackColor = true;
            // 
            // tbDisplay
            // 
            this.tbDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbDisplay.Location = new System.Drawing.Point(111, 142);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(297, 20);
            this.tbDisplay.TabIndex = 10;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbOperacao
            // 
            this.tbOperacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperacao.Location = new System.Drawing.Point(111, 112);
            this.tbOperacao.Name = "tbOperacao";
            this.tbOperacao.Size = new System.Drawing.Size(88, 13);
            this.tbOperacao.TabIndex = 11;
            // 
            // btMais
            // 
            this.btMais.Location = new System.Drawing.Point(413, 330);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(75, 23);
            this.btMais.TabIndex = 12;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = true;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // btIgual
            // 
            this.btIgual.Location = new System.Drawing.Point(413, 384);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(75, 23);
            this.btIgual.TabIndex = 13;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.tbOperacao);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.bd0);
            this.Controls.Add(this.bd9);
            this.Controls.Add(this.bd8);
            this.Controls.Add(this.bd7);
            this.Controls.Add(this.bd6);
            this.Controls.Add(this.bd5);
            this.Controls.Add(this.bd4);
            this.Controls.Add(this.bd3);
            this.Controls.Add(this.bd2);
            this.Controls.Add(this.bd1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bd1;
        private System.Windows.Forms.Button bd2;
        private System.Windows.Forms.Button bd3;
        private System.Windows.Forms.Button bd4;
        private System.Windows.Forms.Button bd5;
        private System.Windows.Forms.Button bd6;
        private System.Windows.Forms.Button bd7;
        private System.Windows.Forms.Button bd8;
        private System.Windows.Forms.Button bd9;
        private System.Windows.Forms.Button bd0;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.TextBox tbOperacao;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btIgual;
    }
}

