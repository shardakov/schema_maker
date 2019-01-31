using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.BlokForms;

namespace test_project.Blocks
{
   public class Block_D : BlockData
    {

       FormBlock_D blockD;
       NameOfBlock nameD;

        public Block_D(Image image, Data data)
           : base(image, data)
        {
            blockD = new FormBlock_D(Data.R);
            nameD = new NameOfBlock();
        }

        public override int Cost
        {
            get
            {
                return 1;
            }
            set
            {
            }
        }

        public override double Calculate()
        {
            return 1;
        }

        public override void OpenForm()
        {
            blockD.ShowDialog();
        }
        
        public override void OpenNameBlock()
        {
            nameD.ShowDialog();
        }
    }
}
