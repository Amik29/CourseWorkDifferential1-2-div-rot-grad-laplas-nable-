using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{
    internal class Vector
    {
        Function i;
        Function j;
        Function k;
        public Function I
        {
            get { return i; }
            set { i = value; }
        }
        public Function J
        {
            get { return j; }
            set { j = value; }
        }
        public Function K
        {
            get { return k; }
            set { k = value; }
        }
    }
}
