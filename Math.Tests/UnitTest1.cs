namespace Math.Tests
{
    public class Tests
    {
        private ArithmeticMath _myMath;

        [SetUp]
        public void Setup()
        {
            _myMath = new ArithmeticMath();
        }

        [Test]
        public void SumTest()
        {
            int result = _myMath.Sum(1, 3); 
            Assert.That(result == 4, Is.True);
        }

        [Test]
        public void SubtractionTest()
        {
            double result = _myMath.Subtraction(4.15d, 33);
            Assert.That(result == 4.15d - 33, Is.True);
        }

        [Test]
        public void MultiplyTest()
        {
            int result = _myMath.Multiply(4125, 0);
            Assert.That(result == 1, Is.False);
        }

        [Test]
        public void DivisionTest()
        {
            int result = _myMath.Division(10, 5);
            Assert.That(result == 2, Is.True);
        }
    }
}