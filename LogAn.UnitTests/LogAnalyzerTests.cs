using NUnit.Framework;
using LogAn;
using System;

namespace LogAn.UnitTests {
    [TestFixture]
    public class LogAnalyzerTests
    {
        [TestCase("datei.SFL")]
        [TestCase("datei.sfl")]
        public void isValidLogFileName_GoodExtension_ReturnsTrue(string file) {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.isValidLogFileName(file);

            Assert.True(result);
        }
        [TestCase("datei.foo")]
        public void isValidLogFileName_BadExtension_ReturnsFalse(string file) {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.isValidLogFileName(file);

            Assert.False(result);
        }

        [Test]
        public void isValidLogFileName_EmptyFileName_Throws() {
            LogAnalyzer analyzer = makeAnalyzer();
            var ex = Assert.Catch<Exception>(() => analyzer.isValidLogFileName(string.Empty));
            StringAssert.Contains("dateiname muss angegeben werden", ex.Message);
        }

        [TestCase("foo.bar", false)]
        [TestCase("foo.sfl", true)]
        public void isValidLogFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected) {
            LogAnalyzer analyzer = makeAnalyzer();
            analyzer.isValidLogFileName(file);
            Assert.AreEqual(analyzer.wasLastFileNameValid, expected);
        }

        private LogAnalyzer makeAnalyzer() {
            return new LogAnalyzer();
        }
    }
}
