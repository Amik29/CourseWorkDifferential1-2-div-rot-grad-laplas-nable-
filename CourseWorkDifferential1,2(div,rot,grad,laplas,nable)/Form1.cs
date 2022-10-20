namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Grad_Click(object sender, EventArgs e)
        {
            Function f = new Function(Convert.ToDouble(AInput.Text), Convert.ToDouble(AlphaInput.Text), Convert.ToDouble(BettaInput.Text), Convert.ToDouble(GammaInput.Text));
            Operator @operator = new Operator();
            Vector vector = @operator.OperateGrad2D(f);


            MessageBox.Show($"{vector.I.FuncToString()} ; {vector.J.FuncToString()} ; {vector.K.FuncToString()}");
        }

        private void Div_dekart_Click(object sender, EventArgs e)
        {
            Operator @operator = new Operator();
            Function P = new Function(Convert.ToDouble(P_a.Text), Convert.ToDouble(P_alpha.Text), Convert.ToDouble(P_beta.Text), Convert.ToDouble(P_gamma.Text));
            Function Q = new Function(Convert.ToDouble(Q_a.Text), Convert.ToDouble(Q_alpha.Text), Convert.ToDouble(Q_beta.Text), Convert.ToDouble(Q_gamma.Text));
            Function R = new Function(Convert.ToDouble(R_a.Text), Convert.ToDouble(R_alpha.Text), Convert.ToDouble(R_beta.Text), Convert.ToDouble(R_gamma.Text));

            VectorFunction vectfunc = new VectorFunction(P, Q, R);

            Vector vector = @operator.OperateDivCartezian(vectfunc);
            MessageBox.Show($"{vector.I.FuncToString()} + {vector.J.FuncToString()} + {vector.K.FuncToString()}");

        }

        private void Rotor_Dekart_Click(object sender, EventArgs e)
        {

            Operator @operator = new Operator();
            Function P = new Function(Convert.ToDouble(P_a.Text), Convert.ToDouble(P_alpha.Text), Convert.ToDouble(P_beta.Text), Convert.ToDouble(P_gamma.Text));
            Function Q = new Function(Convert.ToDouble(Q_a.Text), Convert.ToDouble(Q_alpha.Text), Convert.ToDouble(Q_beta.Text), Convert.ToDouble(Q_gamma.Text));
            Function R = new Function(Convert.ToDouble(R_a.Text), Convert.ToDouble(R_alpha.Text), Convert.ToDouble(R_beta.Text), Convert.ToDouble(R_gamma.Text));


            VectorFunction vectfunc = new VectorFunction(P, Q, R);

            MessageBox.Show(@operator.OperateCurl(vectfunc));
        }
    }
}