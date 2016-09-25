using System.ServiceModel;

namespace WcfTest
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        string TestConnection();

        [OperationContract]
        double Addition(double a, double b);

        [OperationContract]
        double Subtraction(double a, double b);

        [OperationContract]
        double Multiplication(double a, double b);

        [OperationContract]
        double Division(double a, double b);

        [OperationContract]
        ComplexNumber ComplexAddition(ComplexNumber a, ComplexNumber b);
    }
}
