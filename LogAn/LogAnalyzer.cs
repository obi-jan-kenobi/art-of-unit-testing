using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn {
    public class LogAnalyzer {

        private IExtensionManager mgr;

        public LogAnalyzer(IExtensionManager mgr) {
            this.mgr = mgr;
        }

        public bool wasLastFileNameValid { get; set; }

        public bool isValidLogFileName(string fileName) {
            return mgr.isValid(fileName);
        }
    }
}
