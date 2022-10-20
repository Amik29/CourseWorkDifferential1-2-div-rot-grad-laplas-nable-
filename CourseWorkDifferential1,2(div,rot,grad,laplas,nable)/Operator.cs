using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{

    internal class Operator : Deriviative
    {

        public Operator() { }
        public Vector OperateGrad2D(Function function)
        {
            Vector vector = new Vector();

            vector.I = Deriviate(function, "x");
            vector.J = Deriviate(function, "y");
            vector.K = Deriviate(function, "z");
            return vector;
        }

        public Vector OperateDivCartezian(VectorFunction f)
        {

            Vector vector = new Vector();

            vector.I = Deriviate(f.P, "x");
            vector.J = Deriviate(f.Q, "y");
            vector.K = Deriviate(f.R, "z");
            return vector;



        }

        public string OperateCurl(VectorFunction f)
        {
            return $"{Deriviate(f.R, "y").FuncToString()} - {Deriviate(f.Q, "z").FuncToString()}   ;   {Deriviate(f.P, "z").FuncToString()} - {Deriviate(f.R, "x").FuncToString()} ; {Deriviate(f.Q, "x").FuncToString()} - {Deriviate(f.P, "y").FuncToString()} ";
        }



    }
}
