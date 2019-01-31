using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.BlokForms;

namespace test_project.Blocks
{
   public class Block_P : BlockData
    {

        FormBlock_P blockP;
        NameOfBlock nameP;
       
       public Block_P(Image image, Data data)
           : base(image, data)
        {
            blockP = new FormBlock_P(Data.R);
            nameP = new NameOfBlock();
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
            blockP.ShowDialog();
        }

        public override void OpenNameBlock()
        {
            nameP.ShowDialog();
        }
    }
}
