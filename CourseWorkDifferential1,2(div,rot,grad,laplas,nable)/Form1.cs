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



            MessageBox.Show($"{@operator.Operate(f, "x")}  ;{@operator.Operate(f, "y")}  ;  {@operator.Operate(f, "z")}");
        }
    }
}