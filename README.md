classDiagram
    class Calculator {
        +Calculator()
        +int Sum(int a, int b)
        +double Sum(double a, double b)
        +int Subtraction(int a, int b)
        +double Subtraction(double a, double b)
        +int Multiply(int a, int b)
        +double Multiply(double a, double b)
        +int Division(int a, int b)
        +double Division(double a, double b)
        +bool Not(bool a)
        +bool And(bool a, bool b)
        +bool Or(bool a, bool b)
        +bool Xor(bool a, bool b)
        +double Sin(double a)
        +double Cos(double a)
        +double Tg(double a)
        +double Ctg(double a)
    }

    class ArithmeticMath {
        +int Sum(int a, int b)
        +double Sum(double a, double b)
        +int Subtraction(int a, int b)
        +double Subtraction(double a, double b)
        +int Multiply(int a, int b)
        +double Multiply(double a, double b)
        +int Division(int a, int b)
        +double Division(double a, double b)
    }

    class LogicMath {
        +bool Not(bool a)
        +bool And(bool a, bool b)
        +bool Or(bool a, bool b)
        +bool Xor(bool a, bool b)
    }

    class TrigonometricMath {
        +double Sin(double a)
        +double Cos(double a)
        +double Tg(double a)
        +double Ctg(double a)
    }

    Calculator --> ArithmeticMath
    Calculator --> LogicMath
    Calculator --> TrigonometricMath
