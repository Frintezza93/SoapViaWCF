namespace WcfTest
{
    public class Calculator : ICalculator
    {
        public string TestConnection()
        {
            return "Ok";
        }

        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multiplication(double a, double b)
        {
            return a*b;
        }

        public double Division(double a, double b)
        {
            return a/b;
        }

        public ComplexNumber ComplexAddition(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber
            {
                Imagine = a.Imagine + b.Imagine,
                Real = a.Real + b.Real,
            };
        }
    }
}
