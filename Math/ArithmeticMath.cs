namespace Math
{
    public class ArithmeticMath
    {
        public int Sum(int a, int b) => a + b;
        public double Sum(double a, double b) => a + b;

        public int Subtraction(int a, int b) => a - b;
        public double Subtraction(double a, double b) => a - b;

        public int Multiply(int a, int b) => a * b;
        public double Multiply(double a, double b) => a * b;

        public int Division(int a, int b) => b == 0 ? throw new DivideByZeroException() : a / b;
        public double Division(double a, double b) => b == 0 ? throw new DivideByZeroException() : a / b;
    }
}
