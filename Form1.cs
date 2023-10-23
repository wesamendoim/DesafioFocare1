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

                lstListaClientes.Columns.Add("Idade", 80, HorizontalAlignment.Left);
                lstListaClientes.Columns.Add("Sexo", 80, HorizontalAlignment.Left);
                
                //lstListaClientes.HeaderStyle = ColumnHeaderStyle.Nonclickable;

                int intRow = 1;
                //Adicionando itens ao ListView
                foreach (var index in lstIdadeMasculina)
                {
                    //lstListaClientes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    //lstListaClientes.Items.Add(new ListViewItem(new String[] {index.ToString(), lstM[0].ToString()}));
                    //lstListaClientes.Items.Add(lstM[0].ToString(),0)
                    //lstListaClientes.Columns[1].Text = index.ToString();
                    //lstListaClientes.Columns[0].Text = lstM[0].ToString();

                    //lstListaCliente.Columns[0].Text = lstM[0].ToString();
                    //lstListaCliente.Items[intRow].SubItems.Add(index.ToString());
                    //intRow++;
                    //lstItem.SubItems[clmSexo].Text = index.ToString();
                    //lstListaCliente.Columns[1].Text = index.ToString();

                    //lstItem = new ListViewItem(index.ToString());
                    //lstItem.SubItems.Add(lstM[0].ToString());

                    //lstListaClientes.Items.Add(lstItem);
                    //lstListaClientes.View = View.Details;
                    //lstListaClientes.Columns[1].Text = index.ToString();
                    //lstListaClientes.Columns[0].Text = lstM[0].ToString();
                    lstListaClientes.Items.Add(new ListViewItem(new String[] {index.ToString(), lstM[0].ToString() }));
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
