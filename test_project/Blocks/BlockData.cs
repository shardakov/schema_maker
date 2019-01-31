using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_project.Blocks
{
    public abstract class BlockData
    {
        private Blocks.Data data;

        protected Image image { get; set; }

        public BlockData(Image image, Data data)
        {
            this.image = image;
            this.data = data;
        }

        #region Properties

        public abstract int Cost { get; set; }

        public Image Image { get {return image;} }

        public BlockData InBlock { get; set; }

        public BlockData OutBlock { get; set; }

        public Data Data { get { return data; } }

        #endregion

        public abstract double Calculate();

        public abstract void OpenForm();

        public abstract void OpenNameBlock();
    }
}
