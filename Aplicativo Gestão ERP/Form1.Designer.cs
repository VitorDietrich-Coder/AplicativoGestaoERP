﻿
namespace Aplicativo_Gestão_ERP
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
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfSenhaCAD = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SenhaLOG = new System.Windows.Forms.TextBox();
            this.EmailLOG = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarEstoquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarTabelaDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesAvulsasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaDeEstoqueAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeEstoqueAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posiçãoDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preçopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDePreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarTabelaDePreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.DataPanel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(85, 316);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(261, 20);
            label10.TabIndex = 7;
            label10.Text = "Caso tenha cadastro basta se logar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(33, 270);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(298, 20);
            label9.TabIndex = 6;
            label9.Text = "Caso não tenha cadastro basta clicar em";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ConfSenhaCAD);
            this.panel1.Controls.Add(this.Senha);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(416, 208);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.MaximumSize = new System.Drawing.Size(476, 365);
            this.panel1.MinimumSize = new System.Drawing.Size(476, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 365);
            this.panel1.TabIndex = 4;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(343, 316);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 20);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "LOGIN";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cadastre-se";
            // 
            // ConfSenhaCAD
            // 
            this.ConfSenhaCAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfSenhaCAD.Location = new System.Drawing.Point(116, 229);
            this.ConfSenhaCAD.Margin = new System.Windows.Forms.Padding(2);
            this.ConfSenhaCAD.Name = "ConfSenhaCAD";
            this.ConfSenhaCAD.PasswordChar = '*';
            this.ConfSenhaCAD.Size = new System.Drawing.Size(271, 26);
            this.ConfSenhaCAD.TabIndex = 9;
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(115, 173);
            this.Senha.Margin = new System.Windows.Forms.Padding(2);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(271, 26);
            this.Senha.TabIndex = 8;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(115, 117);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(271, 26);
            this.Email.TabIndex = 7;
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(113, 62);
            this.Nome.Margin = new System.Windows.Forms.Padding(2);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(274, 26);
            this.Nome.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmar senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "E-mail";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "LOGIN";
            // 
            // SenhaLOG
            // 
            this.SenhaLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaLOG.Location = new System.Drawing.Point(114, 175);
            this.SenhaLOG.Margin = new System.Windows.Forms.Padding(2);
            this.SenhaLOG.Name = "SenhaLOG";
            this.SenhaLOG.PasswordChar = '*';
            this.SenhaLOG.Size = new System.Drawing.Size(268, 26);
            this.SenhaLOG.TabIndex = 3;
            // 
            // EmailLOG
            // 
            this.EmailLOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLOG.Location = new System.Drawing.Point(111, 112);
            this.EmailLOG.Margin = new System.Windows.Forms.Padding(2);
            this.EmailLOG.Name = "EmailLOG";
            this.EmailLOG.Size = new System.Drawing.Size(271, 26);
            this.EmailLOG.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(328, 271);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 18);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CADASTRE-SE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(label9);
            this.panel2.Controls.Add(this.EmailLOG);
            this.panel2.Controls.Add(this.SenhaLOG);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(415, 209);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 365);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1920, 22);
            this.panel3.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.movimentaçõesAvulsasToolStripMenuItem,
            this.relatórioDeEstoqueToolStripMenuItem,
            this.preçopToolStripMenuItem,
            this.cadastroDeUsuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutoToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            this.cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            this.cadastroDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de Produto";
            this.cadastroDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutoToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balançoToolStripMenuItem,
            this.cadastrarEstoquesToolStripMenuItem,
            this.entradaEstoqueToolStripMenuItem,
            this.saídaEstoqueToolStripMenuItem,
            this.importarTabelaDeEstoqueToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // balançoToolStripMenuItem
            // 
            this.balançoToolStripMenuItem.Name = "balançoToolStripMenuItem";
            this.balançoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.balançoToolStripMenuItem.Text = "Balanço de Estoque";
            // 
            // cadastrarEstoquesToolStripMenuItem
            // 
            this.cadastrarEstoquesToolStripMenuItem.Name = "cadastrarEstoquesToolStripMenuItem";
            this.cadastrarEstoquesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastrarEstoquesToolStripMenuItem.Text = "Cadastrar Estoques";
            // 
            // entradaEstoqueToolStripMenuItem
            // 
            this.entradaEstoqueToolStripMenuItem.Name = "entradaEstoqueToolStripMenuItem";
            this.entradaEstoqueToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.entradaEstoqueToolStripMenuItem.Text = "Entrada Estoque";
            // 
            // saídaEstoqueToolStripMenuItem
            // 
            this.saídaEstoqueToolStripMenuItem.Name = "saídaEstoqueToolStripMenuItem";
            this.saídaEstoqueToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saídaEstoqueToolStripMenuItem.Text = "Saída Estoque";
            // 
            // importarTabelaDeEstoqueToolStripMenuItem
            // 
            this.importarTabelaDeEstoqueToolStripMenuItem.Name = "importarTabelaDeEstoqueToolStripMenuItem";
            this.importarTabelaDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.importarTabelaDeEstoqueToolStripMenuItem.Text = "Importar Tabela de Estoque";
            // 
            // movimentaçõesAvulsasToolStripMenuItem
            // 
            this.movimentaçõesAvulsasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saídaDeEstoqueAVToolStripMenuItem,
            this.entradaDeEstoqueAVToolStripMenuItem});
            this.movimentaçõesAvulsasToolStripMenuItem.Name = "movimentaçõesAvulsasToolStripMenuItem";
            this.movimentaçõesAvulsasToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.movimentaçõesAvulsasToolStripMenuItem.Text = "Movimentações Avulsas";
            // 
            // saídaDeEstoqueAVToolStripMenuItem
            // 
            this.saídaDeEstoqueAVToolStripMenuItem.Name = "saídaDeEstoqueAVToolStripMenuItem";
            this.saídaDeEstoqueAVToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saídaDeEstoqueAVToolStripMenuItem.Text = "Saída de Estoque AV";
            // 
            // entradaDeEstoqueAVToolStripMenuItem
            // 
            this.entradaDeEstoqueAVToolStripMenuItem.Name = "entradaDeEstoqueAVToolStripMenuItem";
            this.entradaDeEstoqueAVToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.entradaDeEstoqueAVToolStripMenuItem.Text = "Entrada de Estoque AV";
            // 
            // relatórioDeEstoqueToolStripMenuItem
            // 
            this.relatórioDeEstoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGToolStripMenuItem,
            this.posiçãoDeEstoqueToolStripMenuItem});
            this.relatórioDeEstoqueToolStripMenuItem.Name = "relatórioDeEstoqueToolStripMenuItem";
            this.relatórioDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.relatórioDeEstoqueToolStripMenuItem.Text = "Relatório de Estoque";
            // 
            // lOGToolStripMenuItem
            // 
            this.lOGToolStripMenuItem.Name = "lOGToolStripMenuItem";
            this.lOGToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.lOGToolStripMenuItem.Text = "Log";
            // 
            // posiçãoDeEstoqueToolStripMenuItem
            // 
            this.posiçãoDeEstoqueToolStripMenuItem.Name = "posiçãoDeEstoqueToolStripMenuItem";
            this.posiçãoDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.posiçãoDeEstoqueToolStripMenuItem.Text = "Posição de Estoque";
            // 
            // preçopToolStripMenuItem
            // 
            this.preçopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDePreçoToolStripMenuItem,
            this.importarTabelaDePreçoToolStripMenuItem});
            this.preçopToolStripMenuItem.Name = "preçopToolStripMenuItem";
            this.preçopToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.preçopToolStripMenuItem.Text = "Preço";
            // 
            // tabelaDePreçoToolStripMenuItem
            // 
            this.tabelaDePreçoToolStripMenuItem.Name = "tabelaDePreçoToolStripMenuItem";
            this.tabelaDePreçoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.tabelaDePreçoToolStripMenuItem.Text = "Tabela de Preço";
            // 
            // importarTabelaDePreçoToolStripMenuItem
            // 
            this.importarTabelaDePreçoToolStripMenuItem.Name = "importarTabelaDePreçoToolStripMenuItem";
            this.importarTabelaDePreçoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.importarTabelaDePreçoToolStripMenuItem.Text = "Importar Tabela de Preço";
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            this.cadastroDeUsuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            this.cadastroDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.cadastroDeUsuárioToolStripMenuItem.Text = "Usuário";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro do Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1349, 728);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.DataPanel);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(0, 711);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1349, 17);
            this.panel4.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(94, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 3;
            // 
            // DataPanel
            // 
            this.DataPanel.AutoSize = true;
            this.DataPanel.Location = new System.Drawing.Point(65, 1);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(33, 13);
            this.DataPanel.TabIndex = 2;
            this.DataPanel.Text = "Data:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Usuário:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ConfSenhaCAD;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SenhaLOG;
        private System.Windows.Forms.TextBox EmailLOG;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEstoquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesAvulsasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaDeEstoqueAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeEstoqueAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarTabelaDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posiçãoDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDePreçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarTabelaDePreçoToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.Label DataPanel;
        private System.Windows.Forms.Label label13;
    }
}

