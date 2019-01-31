using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.BlokForms;

namespace test_project.Blocks
{
   public class Block_Z : BlockData
    {

        FormBlock_Z blockZ;
        NameOfBlock nameZ; 
       
       public Block_Z(Image image, Data data)
           : base(image, data)
        {
            blockZ = new FormBlock_Z(Data.R);
            nameZ = new NameOfBlock();
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
            blockZ.ShowDialog();
        }

        public override void OpenNameBlock()
        {
            nameZ.ShowDialog();
        }

    }
}
