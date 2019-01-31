using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.BlokForms;

namespace test_project.Blocks
{
   public class Block_B : BlockData
    {

        FormBlock_B blockB;
        NameOfBlock nameB;
       
       public Block_B(Image image, Data data)
           : base(image, data)
        {
            blockB = new FormBlock_B(Data.R);
            nameB = new NameOfBlock();
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
            blockB.ShowDialog();
        }

       public override void OpenNameBlock()
       {
           nameB.ShowDialog();
       }
    }
}
