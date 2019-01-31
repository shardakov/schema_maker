using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_project.Blocks;

namespace test_project
{
    public partial class ScopeUser : UserControl
    {
        Boolean isDragging = false;
        BlockData blockData;
        

        public ScopeUser(BlockData blockData)
        {
            InitializeComponent();
            this.blockData = blockData;
            pictureBox1.Image = blockData.Image;
        }

        public BlockData BlockData
        {
            get { return blockData; }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + e.X;
                this.Top = this.Top + e.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                myMenu.Items.Add("Назвать").Name = "name";
                myMenu.Items.Add("Свойства").Name = "property";
                myMenu.Items.Add("Удалить").Name = "delete";
                myMenu.Show(pictureBox1, new Point(e.X, e.Y));
                myMenu.Items["name"].Click += ScopeUser_Name_Click;
                myMenu.Items["property"].Click += ScopeUser_Property_Click;
                myMenu.Items["delete"].Click += ScopeUser_Delete_Click;
            }
            else if (e.Button == MouseButtons.Left)
            {
                ArrowAdd(this);
            }
        }

        void ScopeUser_Name_Click(object sender, EventArgs e)
        {
            blockData.OpenNameBlock();
        }
        
        void ScopeUser_Property_Click(object sender, EventArgs e)
        {
            
            blockData.OpenForm();
        }

        void ScopeUser_Delete_Click(object sender, EventArgs e)
        {
            
            DialogResult messageBoxResult = MessageBox.Show("Вы готовы удалить объект?", "Удаление объекта", MessageBoxButtons.YesNo);
            if (messageBoxResult == DialogResult.Yes)
            {
                BoxDeleted(this);
            }
            else
                return;

        }


        #region 

        public event Action<ScopeUser> BoxDeleted = delegate { };

        public event Action<ScopeUser> ArrowAdd = delegate { };

        public event Action<ScopeUser> ArrowMove = delegate { };

        #endregion

    }
}
