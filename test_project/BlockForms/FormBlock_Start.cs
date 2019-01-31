using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_project.BlokForms
{
    public partial class FormBlock_Start : Form
    {
       private  int r = 0;

       public FormBlock_Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = Int32.Parse(textBox1.Text);
        }

        public int R
        {
            get { return r; }
        }
    }
}
