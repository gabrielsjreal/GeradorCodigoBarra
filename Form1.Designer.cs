namespace CodigoBarra
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
            this.btnGerarCodigo = new System.Windows.Forms.Button();
            this.btnGuardarCodigo = new System.Windows.Forms.Button();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.painelResultado = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnGerarCodigo
            // 
            this.btnGerarCodigo.Location = new System.Drawing.Point(167, 256);
            this.btnGerarCodigo.Name = "btnGerarCodigo";
            this.btnGerarCodigo.Size = new System.Drawing.Size(125, 23);
            this.btnGerarCodigo.TabIndex = 0;
            this.btnGerarCodigo.Text = "Gerar Código";
            this.btnGerarCodigo.UseVisualStyleBackColor = true;
            this.btnGerarCodigo.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnGuardarCodigo
            // 
            this.btnGuardarCodigo.Location = new System.Drawing.Point(167, 285);
            this.btnGuardarCodigo.Name = "btnGuardarCodigo";
            this.btnGuardarCodigo.Size = new System.Drawing.Size(125, 23);
            this.btnGuardarCodigo.TabIndex = 1;
            this.btnGuardarCodigo.Text = "Guardar Código";
            this.btnGuardarCodigo.UseVisualStyleBackColor = true;
            this.btnGerarCodigo.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(35, 217);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(400, 20);
            this.textCodigo.TabIndex = 2;
            // 
            // painelResultado
            // 
            this.painelResultado.Location = new System.Drawing.Point(35, 85);
            this.painelResultado.Name = "painelResultado";
            this.painelResultado.Size = new System.Drawing.Size(400, 100);
            this.painelResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 327);
            this.Controls.Add(this.painelResultado);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.btnGuardarCodigo);
            this.Controls.Add(this.btnGerarCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarCodigo;
        private System.Windows.Forms.Button btnGuardarCodigo;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Panel painelResultado;
    }
}

