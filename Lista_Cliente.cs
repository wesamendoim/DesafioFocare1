using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFocare1
{   

   public class ListaCliente
    {
        List<int> intIdade = new List<int>();
        List<string> strSexo = new List<string>();
        int i = 0;

        public List<int> Idade()
        {
            for(i=1;i<20;i++)
            {
                intIdade.Add(i);
            }

            return intIdade.ToList();
        }
        public List<string> Sexo()
        {
            strSexo.Add("M");
            strSexo.Add("F");

            return strSexo.ToList();
        }
    }
}
