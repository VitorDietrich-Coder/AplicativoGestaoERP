using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Gestão_ERP
{
    class ConexaoGET
    {
        private static string server = @"LAPTOP-CE4Q030Q";
        private static string database = "GestEstoque";
 

        public static string conn
        {
           get { return $"Data Source={server}; Integrated Security=True; Initial Catalog = {database}"; }


        }
    }
}
