using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_.Operators
{
    internal class GradientOperator : Deriviative
    {
        public Vector VectorOperate(Function function)
        {
            Vector vector = new Vector();

            vector.I = FunctionOperate(function, "x");
            vector.J = FunctionOperate(function, "y");
            vector.K = FunctionOperate(function, "z");
            return vector;
        }


    }
}
