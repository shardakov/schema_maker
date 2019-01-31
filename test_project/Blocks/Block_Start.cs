using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.BlokForms;

namespace test_project.Blocks
{
   public class Block_Start : BlockData
    {

        public Block_Start(Image image, Data data)
            : base(image, data)
        {
            blockStart = new FormBlock_Start();
            nameStart = new NameOfBlock();
        }

        public override int Cost
        {
            get
            {
                //throw new NotImplementedException();
                return 1;
            }
            set
            {
                //throw new NotImplementedException();
            }
        }

        public override double Calculate()
        {
            return 1;
        }

        FormBlock_Start blockStart;
        NameOfBlock nameStart;
        public override void OpenForm()
        {
            blockStart.ShowDialog();
            Data.R = blockStart.R;
        }
        public override void OpenNameBlock()
        {
            nameStart.ShowDialog();
        }
    }
}
