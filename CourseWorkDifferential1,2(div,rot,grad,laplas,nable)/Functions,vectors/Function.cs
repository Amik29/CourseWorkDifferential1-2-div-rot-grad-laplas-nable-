using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{
    internal class Function
    {
        public double a { get; set; }
        public double alpha { get; set; }
        public double beta { get; set; }
        public double gamma { get; set; }

        public Function(double a, double alpha, double beta, double gamma)
        {
            this.a = a;
            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
        }

        public Function( Function f)
        {
            this.a = f.a;
            this.alpha = f.alpha;
            this.beta = f.beta;
            this.gamma = f.gamma;
        }
        public string FuncToString() 
        {
            if (a == 0) return "0";
            if (alpha == 0 && beta == 0 && gamma == 0) return "a";


            else if (alpha == 0 && beta == 0 && gamma != 0) return $"{a} * z^{gamma}";
            else if (alpha == 0 && beta != 0 && gamma == 0) return $"{a} * y^{beta}";
            else if (alpha != 0 && beta == 0 && gamma == 0) return $"{a} * x^{alpha}";


            else if (alpha != 0 && beta != 0 && gamma == 0) return $"{a} * x^{alpha} * y^{beta}";
            else if (alpha != 0 && beta == 0 && gamma != 0) return $"{a} * x^{alpha} * z^{gamma}";
            else if (alpha == 0 && beta != 0 && gamma != 0) return $"{a}* y^{beta}*z^{gamma}";


            else if (alpha != 0 && beta != 0 && gamma != 0) return $"{a} * x^{alpha} * y^{beta} * z^{gamma}";
            else return "";
        }

    }
}
