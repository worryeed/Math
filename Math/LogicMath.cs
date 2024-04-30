namespace Math
{
    public class LogicMath
    {
        public bool Not(bool a) => !a;
        public bool And(bool a, bool b) => a && b;
        public bool Or(bool a, bool b) => a || b;
        public bool Xor(bool a, bool b) => a ^ b;
    }
}
