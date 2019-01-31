using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.BlokForms;

namespace test_project.Blocks
{
   public class Block_Finish : BlockData
    {

        FormBlock_Finish blockFinish;
        NameOfBlock nameFinish;
       
       public Block_Finish(Image image, Data data)
           : base(image, data)
        {
            blockFinish = new FormBlock_Finish(Data.R);
            nameFinish = new NameOfBlock();
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
            blockFinish.ShowDialog();
        }
        public override void OpenNameBlock()
        {
            nameFinish.ShowDialog();

        }
    }
}
