using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioFocare1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void ckbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            ListaCliente lstClientes = new ListaCliente();

            List<string> lstM = lstClientes.Sexo();
            List<int> lstIdadeMasculina = lstClientes.Idade();

            ListViewItem lstItem;

            lstListaCliente.Columns.Add("Idade");
            lstListaCliente.Columns.Add("Sexo");

            int intRow = 0;
            //Adicionando itens ao ListView
            foreach (var index in lstIdadeMasculina)
            {
                //lstListaCliente.Columns[1].Text = index.ToString();

                //lstListaCliente.Items.Add(index.ToString());
                //lstListaCliente.Items.Add(lstM[0].ToString());
               
                lstItem = new ListViewItem(index.ToString());
                lstListaCliente.Items.Add(lstItem);
            }

        }

    }
}
