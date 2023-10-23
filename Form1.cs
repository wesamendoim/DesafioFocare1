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
            if (ckbMasculino.Checked == true)
            {
                ListaCliente lstClientes = new ListaCliente();

                List<string> lstM = lstClientes.Sexo();
                List<int> lstIdadeMasculina = lstClientes.Idade();

                ListViewItem lstItem;

                lstListaClientes.Columns.Add("Idade", 120, HorizontalAlignment.Center);
                lstListaClientes.Columns.Add("Sexo", 120, HorizontalAlignment.Center);
                
                //Adicionando itens ao ListView
                foreach (var index in lstIdadeMasculina)
                {
                    lstListaClientes.Items.Add(new ListViewItem(new String[] {index.ToString(), lstM[0].ToString()}));
                    lstListaClientes.Update();
                }

            }
            else
            {
                lstListaClientes.Clear();
            }

        }

        private void ckbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFeminino.Checked == true)
            {
                ListaCliente lstClientes = new ListaCliente();

                List<string> lstM = lstClientes.Sexo();
                List<int> lstIdadeMasculina = lstClientes.Idade();

                ListViewItem lstItem;

                lstListaClientes.Columns.Add("Idade", 120, HorizontalAlignment.Center);
                lstListaClientes.Columns.Add("Sexo", 120, HorizontalAlignment.Center);

                //Adicionando itens ao ListView
                foreach (var index in lstIdadeMasculina)
                {
                    lstListaClientes.Items.Add(new ListViewItem(new String[] { index.ToString(), lstM[1].ToString() }));
                    lstListaClientes.Update();
                }

            }
            else
            {
                lstListaClientes.Clear();
            }
        }
    }
}
