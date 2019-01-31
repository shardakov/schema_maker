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
    public partial class FormBlock_P : Form
    {
        public FormBlock_P(int r)
        {
            InitializeComponent();
            dataGridView_P.ColumnCount = r;
            dataGridView_P.RowCount = r;
        }
    }
}
