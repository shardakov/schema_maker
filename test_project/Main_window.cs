using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_project.Blocks;

namespace test_project
{
     
    public partial class Main_window : Form
    {
        // Boolean isDragging = false;
        Boolean placing = false;
        System.Drawing.Image buttonImage = null;
        BlockData blockData = null;
        Data data;

        ScopeUser scope1;
        ScopeUser scope2;

        public Main_window()
        {
            InitializeComponent();
            data = new Data();
        }

        
// Обработка кнопок для рабочих блоков
# region Buttons from Panel

        private void btn_Start_Click(object sender, EventArgs e)
        {

            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\Recourse\Figure\Start.bmp", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            buttonImage = img;
            placing = true;
            blockData = new Block_Start(img, data);
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\Recourse\Figure\Finish.bmp", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            buttonImage = img;
            placing = true;
            blockData = new Block_Finish(img, data);
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\Recourse\Figure\Circle.bmp", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            buttonImage = img;
            placing = true;
            blockData = new Block_K(img, data);
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\Recourse\Figure\Square.bmp", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            buttonImage = img;
            placing = true;
            blockData = new Block_P(img, data);
        }

        private void btn_Rhombus_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\Recourse\Figure\Rhombus.bmp", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            buttonImage = img;
            placing = true;
            blockData = new Block_D(img, data);
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\Recourse\Figure\Square.bmp", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            buttonImage = img;
            placing = true;
            blockData = new Block_B(img, data);
        }

        private void btn_Truangle_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\Recourse\Figure\Triangle.bmp", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            buttonImage = img;
            placing = true;
            blockData = new Block_Z(img, data);
        }

        private void btn_Hexagon_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(@"..\..\Recourse\Figure\Hexagon.bmp", System.IO.FileMode.Open);
            System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            buttonImage = img;
            placing = true;
            blockData = new Block_L(img, data);
        }

# endregion

// Отрисовка стрелки
# region Arrow

        bool checkArrow = false;

        void us_ArrowMove(ScopeUser obj)
        {
            //
        }

        void us_ArrowAdd(ScopeUser scope)
        {
            if (scope1 == null)
            {
                scope1 = scope;
            }
            else
            {
                if (scope1 == scope)
                {
                    return;
                }
                scope2 = scope;
                ArrowAdd();
            }
        }


        int pero_x1, pero_y1, pero_x2, pero_y2;

        private void ArrowAdd()
        {
            if (checkArrow)
            {
                scope1.BlockData.OutBlock = scope2.BlockData;
                scope2.BlockData.InBlock = scope1.BlockData;
                int pero_x1Center = scope1.Left + (scope1.Width / 2);
                int pero_x2Center = scope2.Left + (scope2.Width / 2);
                int pero_y1Center = (scope1.Height / 2) + scope1.Top;
                int pero_y2Center = (scope2.Height / 2) + scope2.Top;
                pero_x1 = pero_x1Center;
                pero_y1 = pero_y1Center;
                pero_x2 = pero_x2Center;
                pero_y2 = pero_y2Center;
                Pen p = new Pen(Color.Black, 2);
                Graphics gr = panel.CreateGraphics();
                gr.DrawLine(p, pero_x1, pero_y1, pero_x2, pero_y2);
                double ugol = Math.Atan2(pero_x1 - pero_x2, pero_y1 - pero_y2);
                gr.DrawLine(p, pero_x2, pero_y2, Convert.ToInt32(pero_x2 + 15 * Math.Sin(0.3 + ugol)), Convert.ToInt32(pero_y2 + 15 * Math.Cos(0.3 + ugol)));
                gr.DrawLine(p, pero_x2, pero_y2, Convert.ToInt32(pero_x2 + 15 * Math.Sin(ugol - 0.3)), Convert.ToInt32(pero_y2 + 15 * Math.Cos(ugol - 0.3)));
                scope1 = null;
                scope2 = null;
            }
            else
                return;
        }

        public void PaintON_Click(object sender, EventArgs e)
        {
            checkArrow = true;
        }

        public void PaintOFF_Click(object sender, EventArgs e)
        {
            checkArrow = false;
        }


# endregion 

// Елементы с панели инструментов
# region Elements from ToolStrip

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "100%")
            {
                foreach (ScopeUser temp in panel.Controls)
                {
                    temp.Width = 100;
                    temp.Height = 100;
                }
            }
            if (toolStripComboBox1.Text == "75%")
            {
                foreach (ScopeUser temp in panel.Controls)
                {
                    temp.Width = 75;
                    temp.Height = 75;
                }
            }
            if (toolStripComboBox1.Text == "50%")
            {
                foreach (ScopeUser temp in panel.Controls)
                {
                    temp.Width = 50;
                    temp.Height = 50;
                }
            }
            if (toolStripComboBox1.Text == "25%")
            {
                foreach (ScopeUser temp in panel.Controls)
                {
                    temp.Width = 25;
                    temp.Height = 25;
                }
            }
        }

        private void toolStripBtn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult messageBoxResult = MessageBox.Show("Вы готовы очистить рабочее поле?", "Очистить рабочее поле", MessageBoxButtons.YesNo);
            if (messageBoxResult == DialogResult.Yes)
            {
                panel.Controls.Clear();
            }
            else
                return;
        }

# endregion

//Елементы меню
# region Elements from ToolStripMenu

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

# endregion

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (placing)
            {
                ScopeUser us = new ScopeUser(blockData);
                us.BoxDeleted += us_BoxDeleted;
                us.ArrowAdd += us_ArrowAdd;
                us.ArrowMove += us_ArrowMove;

                panel.Controls.Add(us);
                us.Left = e.X;
                us.Top = e.Y;
                placing = false;
            }
        }

        private void us_BoxDeleted(ScopeUser pictureBox)
        {
            panel.Controls.Remove(pictureBox);
            panel.Refresh();
            
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            Calculate window = new Calculate();
            window.ShowDialog();
        }

    }
}
