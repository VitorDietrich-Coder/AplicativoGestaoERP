using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Aplicativo_Gestão_ERP
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            panel3.Visible = false;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (!((String.IsNullOrWhiteSpace(Nome.Text)) || (String.IsNullOrWhiteSpace(Email.Text)) || (String.IsNullOrWhiteSpace(Senha.Text))))
            {
                Controlalogin control = new Controlalogin();
                control.acessa(Email.Text);

                if (control.tem)
                {
                    MessageBox.Show("Digite um valor valido");
                }
                else
                {
                    if (Senha.Text == ConfSenhaCAD.Text)
                    {
                        CadastroUsuario cadson = new CadastroUsuario(Nome.Text, Email.Text, Senha.Text);
                        MessageBox.Show(cadson.mensagem);
                        panel1.Visible = false;
                        panel2.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("As senha não coincidem");
                    }
                }
            }
            else
            {
                MessageBox.Show("revise os campos tem algum campo em branco");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(EmailLOG.Text, SenhaLOG.Text);
            BuscaNome pega = new BuscaNome();
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("login deu certo");
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = true;
                    painel4.Visible = true;
                    label11.Text = pega.Pega_Nome2(EmailLOG.Text);
                    DataPainel.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
                else
                {
                    MessageBox.Show("deu errado");
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
        private void criardiretorio()
        {
                string folderPath = @"D:\MyFolder";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine(folderPath);
                }
            }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
