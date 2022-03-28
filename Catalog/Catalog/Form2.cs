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
    
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
           
        }
        Catalog product;
        public Form2(Catalog list)
        {
            InitializeComponent();
            this.product = list;
        }

        
        
        private void btn_OK_Click(object sender, EventArgs e)
        {
                    

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
