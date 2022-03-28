using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{

    public partial class Form1 : Form
    {
        List<string> person = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Name = txt_name.Text;
            string Surname = txt_surname.Text;
            string Email = txt_email.Text;
            string Phone_number = txt_number.Text;
            string Born = txt_born.Text;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                listBox.Items.Add(new Car(textBox1.Text));
            textBox1.Text = null;
        }
    }
}
