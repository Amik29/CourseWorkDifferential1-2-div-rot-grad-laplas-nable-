using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_.Operators
{
    internal interface IDiffOperator
    {
        Vector VectorOperate(Function f);
        Function FunctionOperate(Function f);
        Function FunctionOperate(Function f, string deriviate);

    }
}
