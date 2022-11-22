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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
             Form2 form2 = new Form2();
             form2.PreencheValores(dataGridView1);
             Close(); 
                }
            }
        }
