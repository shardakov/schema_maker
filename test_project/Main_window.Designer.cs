namespace test_project
{
    partial class Main_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.PaintArrow = new System.Windows.Forms.ToolStripSplitButton();
            this.PaintON = new System.Windows.Forms.ToolStripMenuItem();
            this.PaintOFF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripBtn_Delete = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Hexagon = new System.Windows.Forms.Button();
            this.btn_Truangle = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Rhombus = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.сохранитьСхемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьСхемуToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.infoToolStripMenuItem.Text = "Информация";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaintArrow,
            this.toolStripComboBox1,
            this.toolStripBtn_Delete});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(861, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // PaintArrow
            // 
            this.PaintArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PaintArrow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaintON,
            this.PaintOFF});
            this.PaintArrow.Image = ((System.Drawing.Image)(resources.GetObject("PaintArrow.Image")));
            this.PaintArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaintArrow.Name = "PaintArrow";
            this.PaintArrow.Size = new System.Drawing.Size(32, 22);
            this.PaintArrow.Text = "toolStripSplitButton1";
            // 
            // PaintON
            // 
            this.PaintON.Name = "PaintON";
            this.PaintON.Size = new System.Drawing.Size(200, 22);
            this.PaintON.Text = "Отрисовка включена";
            this.PaintON.Click += new System.EventHandler(this.PaintON_Click);
            // 
            // PaintOFF
            // 
            this.PaintOFF.Name = "PaintOFF";
            this.PaintOFF.Size = new System.Drawing.Size(200, 22);
            this.PaintOFF.Text = "Отрисовка выключена";
            this.PaintOFF.Click += new System.EventHandler(this.PaintOFF_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "100%",
            "75%",
            "50%",
            "25%"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripComboBox1.Text = "100%";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripBtn_Delete
            // 
            this.toolStripBtn_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Delete.Image")));
            this.toolStripBtn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Delete.Name = "toolStripBtn_Delete";
            this.toolStripBtn_Delete.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtn_Delete.Text = "Delete";
            this.toolStripBtn_Delete.Click += new System.EventHandler(this.toolStripBtn_Delete_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 394);
            this.listBox1.TabIndex = 2;
            this.listBox1.Tag = "1";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Calculate.Location = new System.Drawing.Point(12, 461);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(178, 23);
            this.btn_Calculate.TabIndex = 0;
            this.btn_Calculate.Text = "Рассчитать";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(211, 52);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(638, 445);
            this.panel.TabIndex = 16;
            this.panel.Tag = "";
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Hexagon
            // 
            this.btn_Hexagon.BackColor = System.Drawing.Color.White;
            this.btn_Hexagon.Image = ((System.Drawing.Image)(resources.GetObject("btn_Hexagon.Image")));
            this.btn_Hexagon.Location = new System.Drawing.Point(115, 292);
            this.btn_Hexagon.Name = "btn_Hexagon";
            this.btn_Hexagon.Size = new System.Drawing.Size(75, 68);
            this.btn_Hexagon.TabIndex = 15;
            this.btn_Hexagon.UseVisualStyleBackColor = false;
            this.btn_Hexagon.Click += new System.EventHandler(this.btn_Hexagon_Click);
            // 
            // btn_Truangle
            // 
            this.btn_Truangle.BackColor = System.Drawing.Color.White;
            this.btn_Truangle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Truangle.Image")));
            this.btn_Truangle.Location = new System.Drawing.Point(12, 292);
            this.btn_Truangle.Name = "btn_Truangle";
            this.btn_Truangle.Size = new System.Drawing.Size(84, 68);
            this.btn_Truangle.TabIndex = 14;
            this.btn_Truangle.UseVisualStyleBackColor = false;
            this.btn_Truangle.Click += new System.EventHandler(this.btn_Truangle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.BackColor = System.Drawing.Color.White;
            this.btn_Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Rectangle.Image")));
            this.btn_Rectangle.Location = new System.Drawing.Point(115, 218);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(75, 68);
            this.btn_Rectangle.TabIndex = 13;
            this.btn_Rectangle.UseVisualStyleBackColor = false;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Rhombus
            // 
            this.btn_Rhombus.BackColor = System.Drawing.Color.White;
            this.btn_Rhombus.Image = ((System.Drawing.Image)(resources.GetObject("btn_Rhombus.Image")));
            this.btn_Rhombus.Location = new System.Drawing.Point(12, 218);
            this.btn_Rhombus.Name = "btn_Rhombus";
            this.btn_Rhombus.Size = new System.Drawing.Size(84, 68);
            this.btn_Rhombus.TabIndex = 12;
            this.btn_Rhombus.UseVisualStyleBackColor = false;
            this.btn_Rhombus.Click += new System.EventHandler(this.btn_Rhombus_Click);
            // 
            // btn_Square
            // 
            this.btn_Square.BackColor = System.Drawing.Color.White;
            this.btn_Square.Image = ((System.Drawing.Image)(resources.GetObject("btn_Square.Image")));
            this.btn_Square.Location = new System.Drawing.Point(115, 144);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(75, 68);
            this.btn_Square.TabIndex = 11;
            this.btn_Square.UseVisualStyleBackColor = false;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.Color.White;
            this.btn_Circle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Circle.Image")));
            this.btn_Circle.Location = new System.Drawing.Point(12, 144);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(84, 68);
            this.btn_Circle.TabIndex = 10;
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.BackColor = System.Drawing.Color.White;
            this.btn_Finish.Image = ((System.Drawing.Image)(resources.GetObject("btn_Finish.Image")));
            this.btn_Finish.Location = new System.Drawing.Point(115, 70);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(75, 68);
            this.btn_Finish.TabIndex = 0;
            this.btn_Finish.UseVisualStyleBackColor = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.White;
            this.btn_Start.Image = ((System.Drawing.Image)(resources.GetObject("btn_Start.Image")));
            this.btn_Start.Location = new System.Drawing.Point(12, 70);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(84, 68);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // сохранитьСхемуToolStripMenuItem
            // 
            this.сохранитьСхемуToolStripMenuItem.Name = "сохранитьСхемуToolStripMenuItem";
            this.сохранитьСхемуToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сохранитьСхемуToolStripMenuItem.Text = "Сохранить схему";
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 509);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_Hexagon);
            this.Controls.Add(this.btn_Truangle);
            this.Controls.Add(this.btn_Rectangle);
            this.Controls.Add(this.btn_Rhombus);
            this.Controls.Add(this.btn_Square);
            this.Controls.Add(this.btn_Circle);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_window";
            this.Text = "tmp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Button btn_Rhombus;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Truangle;
        private System.Windows.Forms.Button btn_Hexagon;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripBtn_Delete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSplitButton PaintArrow;
        private System.Windows.Forms.ToolStripMenuItem PaintON;
        private System.Windows.Forms.ToolStripMenuItem PaintOFF;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСхемуToolStripMenuItem;
    }
}

