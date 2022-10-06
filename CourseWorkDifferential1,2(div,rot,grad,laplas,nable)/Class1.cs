using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{
    internal class Function//a*x^a*y^b*z^g
    {
        float a;
        float alpha;
        float beta;
        float gamma;

        Function(float a, float alpha, float beta, float gamma)
        {
            this.a = a;
            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
        }
    }
}
