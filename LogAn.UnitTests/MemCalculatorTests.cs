using NUnit.Framework;

namespace LogAn.UnitTests {
    [TestFixture]
    class MemCalculatorTests {
        [Test]
        public void Sum_ByDefault_ReturnsZero() {
            MemCalculator calc = new MemCalculator();
            int lastSum = calc.getSum();
            Assert.AreEqual(0, lastSum);
        }
        [Test]
        public void Add_Add5_IncreasesSumBy5() {
            MemCalculator calc = new MemCalculator();
            calc.add(5);
            int lastSum = calc.getSum();
            Assert.AreEqual(5, lastSum);
        }
    }
}
