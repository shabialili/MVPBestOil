using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{

    public partial class Catalog : Form
    {
        DataBase dataBase = new DataBase
        {
            products = new List<Product>()
        };
        public Catalog()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lb_ProductList.Items.RemoveAt(lb_ProductList.SelectedIndex);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lb_ProductList.Items.Clear();
        }
    }
}
