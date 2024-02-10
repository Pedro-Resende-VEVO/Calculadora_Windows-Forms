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
            this.btMenos = new System.Windows.Forms.Button();
            this.btVezes = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.btSinal = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bd1
            // 
            this.bd1.Location = new System.Drawing.Point(12, 286);
            this.bd1.Name = "bd1";
            this.bd1.Size = new System.Drawing.Size(75, 48);
            this.bd1.TabIndex = 0;
            this.bd1.Text = "1";
            this.bd1.UseVisualStyleBackColor = true;
            this.bd1.Click += new System.EventHandler(this.bd1_Click);
            // 
            // bd2
            // 
            this.bd2.Location = new System.Drawing.Point(93, 288);
            this.bd2.Name = "bd2";
            this.bd2.Size = new System.Drawing.Size(75, 48);
            this.bd2.TabIndex = 1;
            this.bd2.Text = "2";
            this.bd2.UseVisualStyleBackColor = true;
            this.bd2.Click += new System.EventHandler(this.bd2_Click);
            // 
            // bd3
            // 
            this.bd3.Location = new System.Drawing.Point(174, 286);
            this.bd3.Name = "bd3";
            this.bd3.Size = new System.Drawing.Size(75, 48);
            this.bd3.TabIndex = 2;
            this.bd3.Text = "3";
            this.bd3.UseVisualStyleBackColor = true;
            this.bd3.Click += new System.EventHandler(this.bd3_Click);
            // 
            // bd4
            // 
            this.bd4.Location = new System.Drawing.Point(12, 235);
            this.bd4.Name = "bd4";
            this.bd4.Size = new System.Drawing.Size(75, 45);
            this.bd4.TabIndex = 3;
            this.bd4.Text = "4";
            this.bd4.UseVisualStyleBackColor = true;
            this.bd4.Click += new System.EventHandler(this.bd4_Click);
            // 
            // bd5
            // 
            this.bd5.Location = new System.Drawing.Point(93, 237);
            this.bd5.Name = "bd5";
            this.bd5.Size = new System.Drawing.Size(75, 46);
            this.bd5.TabIndex = 4;
            this.bd5.Text = "5";
            this.bd5.UseVisualStyleBackColor = true;
            this.bd5.Click += new System.EventHandler(this.bd5_Click);
            // 
            // bd6
            // 
            this.bd6.Location = new System.Drawing.Point(174, 235);
            this.bd6.Name = "bd6";
            this.bd6.Size = new System.Drawing.Size(75, 45);
            this.bd6.TabIndex = 5;
            this.bd6.Text = "6";
            this.bd6.UseVisualStyleBackColor = true;
            this.bd6.Click += new System.EventHandler(this.bd6_Click);
            // 
            // bd7
            // 
            this.bd7.Location = new System.Drawing.Point(12, 187);
            this.bd7.Name = "bd7";
            this.bd7.Size = new System.Drawing.Size(75, 42);
            this.bd7.TabIndex = 6;
            this.bd7.Text = "7";
            this.bd7.UseVisualStyleBackColor = true;
            this.bd7.Click += new System.EventHandler(this.bd7_Click);
            // 
            // bd8
            // 
            this.bd8.Location = new System.Drawing.Point(93, 185);
            this.bd8.Name = "bd8";
            this.bd8.Size = new System.Drawing.Size(75, 46);
            this.bd8.TabIndex = 7;
            this.bd8.Text = "8";
            this.bd8.UseVisualStyleBackColor = true;
            this.bd8.Click += new System.EventHandler(this.bd8_Click);
            // 
            // bd9
            // 
            this.bd9.Location = new System.Drawing.Point(174, 187);
            this.bd9.Name = "bd9";
            this.bd9.Size = new System.Drawing.Size(75, 42);
            this.bd9.TabIndex = 8;
            this.bd9.Text = "9";
            this.bd9.UseVisualStyleBackColor = true;
            this.bd9.Click += new System.EventHandler(this.bd9_Click);
            // 
            // bd0
            // 
            this.bd0.Location = new System.Drawing.Point(93, 342);
            this.bd0.Name = "bd0";
            this.bd0.Size = new System.Drawing.Size(75, 48);
            this.bd0.TabIndex = 9;
            this.bd0.Text = "0";
            this.bd0.UseVisualStyleBackColor = true;
            this.bd0.Click += new System.EventHandler(this.bd0_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbDisplay.Location = new System.Drawing.Point(12, 59);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(321, 20);
            this.tbDisplay.TabIndex = 10;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbOperacao
            // 
            this.tbOperacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperacao.Location = new System.Drawing.Point(23, 62);
            this.tbOperacao.Name = "tbOperacao";
            this.tbOperacao.Size = new System.Drawing.Size(88, 13);
            this.tbOperacao.TabIndex = 11;
            // 
            // btMais
            // 
            this.btMais.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMais.Location = new System.Drawing.Point(258, 286);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(75, 48);
            this.btMais.TabIndex = 12;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = false;
            this.btMais.Click += new System.EventHandler(this.btMais_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btIgual.Location = new System.Drawing.Point(258, 340);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(75, 48);
            this.btIgual.TabIndex = 13;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btMenos
            // 
            this.btMenos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btMenos.Location = new System.Drawing.Point(258, 235);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(75, 46);
            this.btMenos.TabIndex = 14;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = false;
            this.btMenos.Click += new System.EventHandler(this.btMenos_Click);
            // 
            // btVezes
            // 
            this.btVezes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btVezes.Location = new System.Drawing.Point(258, 187);
            this.btVezes.Name = "btVezes";
            this.btVezes.Size = new System.Drawing.Size(75, 42);
            this.btVezes.TabIndex = 15;
            this.btVezes.Text = "x";
            this.btVezes.UseVisualStyleBackColor = false;
            this.btVezes.Click += new System.EventHandler(this.btVezes_Click);
            // 
            // btPonto
            // 
            this.btPonto.Location = new System.Drawing.Point(174, 340);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(75, 48);
            this.btPonto.TabIndex = 16;
            this.btPonto.Text = ",";
            this.btPonto.UseVisualStyleBackColor = true;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // btSinal
            // 
            this.btSinal.Location = new System.Drawing.Point(12, 340);
            this.btSinal.Name = "btSinal";
            this.btSinal.Size = new System.Drawing.Size(75, 48);
            this.btSinal.TabIndex = 17;
            this.btSinal.Text = "+/-";
            this.btSinal.UseVisualStyleBackColor = true;
            this.btSinal.Click += new System.EventHandler(this.btSinal_Click);
            // 
            // btDividir
            // 
            this.btDividir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDividir.Location = new System.Drawing.Point(258, 139);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(75, 42);
            this.btDividir.TabIndex = 18;
            this.btDividir.Text = "/";
            this.btDividir.UseVisualStyleBackColor = false;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btApagar
            // 
            this.btApagar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btApagar.Location = new System.Drawing.Point(174, 139);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 42);
            this.btApagar.TabIndex = 19;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = false;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLimpar.Location = new System.Drawing.Point(93, 139);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 42);
            this.btLimpar.TabIndex = 20;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReset.Location = new System.Drawing.Point(12, 139);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 42);
            this.btReset.TabIndex = 21;
            this.btReset.Text = "Resetar";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 412);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btSinal);
            this.Controls.Add(this.btPonto);
            this.Controls.Add(this.btVezes);
            this.Controls.Add(this.btMenos);
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
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btVezes;
        private System.Windows.Forms.Button btPonto;
        private System.Windows.Forms.Button btSinal;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btReset;
    }
}

