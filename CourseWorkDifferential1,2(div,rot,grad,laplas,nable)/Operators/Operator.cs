using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_.Operators
{

    internal class Operator : Deriviative
    {
        public Operator() { }
        public string OperateCurl(VectorFunction f)
        {
            return $"{FunctionOperate(f.R, "y").FuncToString()} - {FunctionOperate(f.Q, "z").FuncToString()}   ;   {FunctionOperate(f.P, "z").FuncToString()} - {FunctionOperate(f.R, "x").FuncToString()} ; {FunctionOperate(f.Q, "x").FuncToString()} - {FunctionOperate(f.P, "y").FuncToString()} ";
        }
    }
}
