using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn {
    public class FakeExtensionManager : IExtensionManager {
        bool returnValue;

        public FakeExtensionManager(bool returnValue) {
            this.returnValue = returnValue;
        }
        public bool isValid(string fileName) {
            if (string.IsNullOrEmpty(fileName)) {
                throw new ArgumentException("dateiname muss angegeben werden");
            }
            return returnValue;
        }
    }
}
