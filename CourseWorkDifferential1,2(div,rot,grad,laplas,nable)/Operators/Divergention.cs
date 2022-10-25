using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_.Operators
{
    internal class DivergentionOperator : Deriviative
    {

        public Vector VectorOperate(VectorFunction f)
        {

            Vector vector = new Vector();

            vector.I = FunctionOperate(f.P, "x");
            vector.J = FunctionOperate(f.Q, "y");
            vector.K = FunctionOperate(f.R, "z");
            return vector;

        }

    }
}
