using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_.Operators
{
    internal class Deriviative : IDiffOperator
    {
        public Function FunctionOperate(Function f)
        {
            throw new NotImplementedException();
        }

        public Function FunctionOperate(Function function, string deriviate)
        {
            Function function1 = new Function(function);

            switch (deriviate)
            {
                case "x":
                    if (function.a == 0 || function.alpha == 0) function1.a = 0;

                    else if (function.alpha == 1) function1.alpha = 0;

                    else { function1.a *= function1.alpha; function1.alpha--; };
                    break;
                case "y":
                    if (function.a == 0 || function.beta == 0) function1.a = 0;

                    else if (function.beta == 1) function1.beta = 0;

                    else { function1.a *= function1.beta; function1.beta--; };
                    break;

                case "z":
                    if (function.a == 0 || function.gamma == 0) function1.a = 0;

                    else if (function.gamma == 1) function1.gamma = 0;

                    else { function1.a *= function1.gamma; function1.gamma--; };
                    break;

            }
            return function1;
        }

        public Vector VectorOperate(Function f)
        {
            throw new NotImplementedException();
        }
    }
}
