namespace Math
{
    public class Calculator
    {
        private ArithmeticMath arithmeticMath;
        private LogicMath logicMath;
        private TrigonometricMath trigonometricMath;

        public Calculator()
        {
            arithmeticMath = new ArithmeticMath();
            logicMath = new LogicMath();
            trigonometricMath = new TrigonometricMath();
        }

        // Арифметические операции
        public int Sum(int a, int b) => arithmeticMath.Sum(a, b);
        public double Sum(double a, double b) => arithmeticMath.Sum(a, b);

        public int Subtraction(int a, int b) => arithmeticMath.Subtraction(a, b);
        public double Subtraction(double a, double b) => arithmeticMath.Subtraction(a, b);

        public int Multiply(int a, int b) => arithmeticMath.Multiply(a, b);
        public double Multiply(double a, double b) => arithmeticMath.Multiply(a, b);

        public int Division(int a, int b) => arithmeticMath.Division(a, b);
        public double Division(double a, double b) => arithmeticMath.Division(a, b);

        // Логические операции
        public bool Not(bool a) => logicMath.Not(a);
        public bool And(bool a, bool b) => logicMath.And(a, b);
        public bool Or(bool a, bool b) => logicMath.Or(a, b);
        public bool Xor(bool a, bool b) => logicMath.Xor(a, b);

        // Тригонометрические операции
        public double Sin(double a) => trigonometricMath.Sin(a);
        public double Cos(double a) => trigonometricMath.Cos(a);
        public double Tg(double a) => trigonometricMath.Tg(a);
        public double Ctg(double a) => trigonometricMath.Ctg(a);
    }
}