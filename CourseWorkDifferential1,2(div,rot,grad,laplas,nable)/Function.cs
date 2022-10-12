using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{
    internal class Function//a*x^a*y^b*z^g
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
    }
}
