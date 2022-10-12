using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{

    internal class Operator
    {

        public Operator() { }
        public string Operate(Function function, string deriviate)
        {
            switch (deriviate)
            {
                case "x":
                    if (function.a == 0) return "0";
                    if (function.alpha == 0) return "0";
                    if (function.alpha == 1) return $"{function.a}*y^{function.beta}*z^{function.gamma}";
                    else return $"{function.a * function.alpha}*x^{function.alpha - 1}*y^{function.beta}*z^{function.gamma}";
                case "y":
                    if (function.a == 0) return "0";
                    if (function.beta == 0) return "0";
                    if (function.beta == 1) return $"{function.a}*x^{function.alpha}*z^{function.gamma}";
                    else return $"{function.a * function.beta}*x^{function.alpha}*y^{function.beta-1}*z^{function.gamma}";

                case "z":
                    if (function.a == 0) return "0";
                    if (function.gamma == 0) return "0";
                    if (function.gamma == 1) return $"{function.a}*x^{function.alpha}*y^{function.beta}";
                    else return $"{function.a * function.gamma}*x^{function.alpha}*y^{function.beta}*z^{function.gamma-1}";

            }
            return "";

        }



    }
}
