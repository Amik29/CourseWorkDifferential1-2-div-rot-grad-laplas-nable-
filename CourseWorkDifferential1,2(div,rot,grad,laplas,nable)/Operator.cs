﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{
    class Func
    {
        public double[] massOfCoefficient = new double[5];


    }

    abstract class Operator
    {
        public abstract void Operate(Func function);




    }
}
