using NUnit.Framework;
using LogAn;
using System;

namespace LogAn.UnitTests {
    [TestFixture]
    public class LogAnalyzerTests {

        [TestCase("datei.SFL")]
        [TestCase("datei.sfl")]
        public void isValidLogFileName_GoodExtension_ReturnsTrue(string file) {
            LogAnalyzer analyzer = new LogAnalyzer(new FakeExtensionManager(true));
            bool result = analyzer.isValidLogFileName(file);

            Assert.True(result);
        }

        [TestCase("datei.foo")]
        public void isValidLogFileName_BadExtension_ReturnsFalse(string file) {
            LogAnalyzer analyzer = new LogAnalyzer(new FakeExtensionManager(false));
            bool result = analyzer.isValidLogFileName(file);

            Assert.False(result);
        }

        [Test]
        public void isValidLogFileName_EmptyFileName_Throws() {
            LogAnalyzer analyzer = makeAnalyzer(new FakeExtensionManager(false));
            var ex = Assert.Catch<Exception>(() => analyzer.isValidLogFileName(string.Empty));

            StringAssert.Contains("dateiname muss angegeben werden", ex.Message);
        }

        private LogAnalyzer makeAnalyzer(IExtensionManager mgr) {
            return new LogAnalyzer(mgr);
        }

        [Test]
        public void isValidLogFileName_ExtMngThrowsException_ReturnsFalse() {
            IExtensionManager fakeMng = new FakeExtensionManager(true);
            fakeMng.willThrow = new Exception("dies ist ein fake");
            LogAnalyzer analyzer = new LogAnalyzer(fakeMng);
            bool result = analyzer.isValidLogFileName("foo.bar");
        }
    }

    public class FakeExtensionManager : IExtensionManager {

        bool returnValue = false;
        Exception _willThrow;

        Exception IExtensionManager.willThrow {
            get { return _willThrow; }
            set { _willThrow = value; }
        }

        public FakeExtensionManager(bool returnValue) {
            this.returnValue = returnValue;
        }
        public bool isValid(string fileName) {

            if(_willThrow != null) {
                throw _willThrow;
            }

            if (string.IsNullOrEmpty(fileName)) {
                throw new ArgumentException("dateiname muss angegeben werden");
            }
            return returnValue;
        }
    }
}
