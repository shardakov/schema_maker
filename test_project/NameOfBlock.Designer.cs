namespace test_project
{
    partial class NameOfBlock
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
            this.textNameBlock = new System.Windows.Forms.TextBox();
            this.btnNameBlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNameBlock
            // 
            this.textNameBlock.Location = new System.Drawing.Point(12, 10);
            this.textNameBlock.Name = "textNameBlock";
            this.textNameBlock.Size = new System.Drawing.Size(181, 20);
            this.textNameBlock.TabIndex = 0;
            // 
            // btnNameBlock
            // 
            this.btnNameBlock.Location = new System.Drawing.Point(199, 8);
            this.btnNameBlock.Name = "btnNameBlock";
            this.btnNameBlock.Size = new System.Drawing.Size(75, 23);
            this.btnNameBlock.TabIndex = 1;
            this.btnNameBlock.Text = "Сохранить";
            this.btnNameBlock.UseVisualStyleBackColor = true;
            this.btnNameBlock.Click += new System.EventHandler(this.btnNameBlock_Click);
            // 
            // NameOfBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 42);
            this.Controls.Add(this.btnNameBlock);
            this.Controls.Add(this.textNameBlock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameOfBlock";
            this.Text = "NameOfBlock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNameBlock;
        private System.Windows.Forms.Button btnNameBlock;
    }
}