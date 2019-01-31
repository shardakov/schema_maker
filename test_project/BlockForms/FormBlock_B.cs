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
    public partial class FormBlock_B : Form
    {
        public FormBlock_B(int r)
        {
            InitializeComponent();
            dataGridView_B.ColumnCount = r;
            dataGridView_B.RowCount = r;
        }
    }
}
