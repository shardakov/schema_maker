using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.BlokForms;

namespace test_project.Blocks
{
   public class Block_L : BlockData
    {

        FormBlock_L blockL;
        NameOfBlock nameL;
       
       public Block_L(Image image , Data data)
           : base(image, data)
        {
            blockL = new FormBlock_L(Data.R);
            nameL = new NameOfBlock();
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

        
        public override void OpenForm()
        {
            blockL.ShowDialog();
        }

        public override void OpenNameBlock()
        {
            nameL.ShowDialog();
        }
    }
}
