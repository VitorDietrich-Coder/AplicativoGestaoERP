using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_Gestão_ERP
{
    public class RespeitaQuant
    {
        public void validar(int minimo, int maximo, int quantidade)
        {
            Form2 form2 = new Form2();
            if (!form2.ControlaEstoque.Checked == true)
            {
                if (quantidade < minimo)
                {
                    MessageBox.Show($"Seu estoque minimo está configurado para{minimo} o mesmo ficará abaixo do minimo deseja continuar?");
                    DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Salvar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                }
                else if (quantidade >  maximo)
                {
                    MessageBox.Show($"Seu estoque máximo está configurado para {maximo} deseja importar tudo isso ?");
                }
            }
            else
            {
                MessageBox.Show($"Seu estoque minimo não está configurado");
            }
        
        }
    }
}
