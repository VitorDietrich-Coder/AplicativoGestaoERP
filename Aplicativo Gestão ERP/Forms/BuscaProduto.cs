using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Gestão_ERP
{
    public partial class BuscaProduto : Form
    {
        public BuscaProduto()
        {
            InitializeComponent();
        }

        public void FinalizaForms()
        {
            BuscaProduto buscaProduto = new BuscaProduto();
            buscaProduto.Close();
            buscaProduto.Visible = false;       
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            PreencheValores preencheValores = new PreencheValores();
            preencheValores.preencheLabel(dataGridView1);
            Close();
        }
      }
   }
