namespace Aplicativo_Gestão_ERP
{
    partial class Configuracoes
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
            this.Diretorio = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DiretorioImagens = new System.Windows.Forms.Label();
            this.Diretorio.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Diretorio
            // 
            this.Diretorio.Controls.Add(this.tabPage1);
            this.Diretorio.Controls.Add(this.tabPage2);
            this.Diretorio.Location = new System.Drawing.Point(0, 1);
            this.Diretorio.Name = "Diretorio";
            this.Diretorio.SelectedIndex = 0;
            this.Diretorio.Size = new System.Drawing.Size(801, 446);
            this.Diretorio.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DiretorioImagens);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configurações Diretorio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DiretorioImagens
            // 
            this.DiretorioImagens.AutoSize = true;
            this.DiretorioImagens.Location = new System.Drawing.Point(8, 17);
            this.DiretorioImagens.Name = "DiretorioImagens";
            this.DiretorioImagens.Size = new System.Drawing.Size(151, 13);
            this.DiretorioImagens.TabIndex = 1;
            this.DiretorioImagens.Text = "Diretorio que salva as imagens";
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Diretorio);
            this.Name = "Configuracoes";
            this.Text = "Configuracoes";
            this.Diretorio.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Diretorio;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label DiretorioImagens;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}