namespace Exemplo01
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(27, 11);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(68, 21);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(27, 35);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(183, 29);
            this.txtModelo.TabIndex = 1;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(27, 67);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(39, 21);
            this.lblCor.TabIndex = 2;
            this.lblCor.Text = "Cor";
            // 
            // cbCor
            // 
            this.cbCor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(27, 91);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(183, 29);
            this.cbCor.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(27, 134);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 21);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço";
            // 
            // mtbPreco
            // 
            this.mtbPreco.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPreco.Location = new System.Drawing.Point(27, 158);
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(183, 29);
            this.mtbPreco.TabIndex = 5;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(27, 190);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(42, 21);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano";
            // 
            // nudAno
            // 
            this.nudAno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAno.Location = new System.Drawing.Point(27, 214);
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(183, 29);
            this.nudAno.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(27, 249);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 43);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 302);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.nudAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.Button btnSalvar;
    }
}

