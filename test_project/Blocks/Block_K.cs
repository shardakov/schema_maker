using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_project.BlokForms;

namespace test_project.Blocks
{
   public class Block_K : BlockData
    {

        FormBlock_K blockK;
        NameOfBlock nameK; 
       
       public Block_K(Image image, Data data)
           : base(image, data)
        {
            blockK = new FormBlock_K(Data.R);
            nameK = new NameOfBlock();
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
            blockK.ShowDialog();
        }
        public override void OpenNameBlock()
        {
            nameK.ShowDialog();
        }

    }
}
