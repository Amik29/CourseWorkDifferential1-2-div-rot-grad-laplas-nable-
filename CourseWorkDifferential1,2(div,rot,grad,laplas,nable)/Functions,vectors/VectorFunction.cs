using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{
    internal class VectorFunction
    {
        Function p;
        Function q;
        Function r;
        public VectorFunction (Function p, Function q, Function r)
        {
            this.p = p;
            this.q = q;
            this.r = r;
        }
        public Function P
        {
            get { return p; }
            set { p = value; }
        }
        public Function Q
        {
            get { return q; }
            set { q = value; }
        }

        public Function R
        {
            get { return r; }
            set { r = value; }
        }

    }
}
