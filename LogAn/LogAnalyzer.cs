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
            if (string.IsNullOrEmpty(fileName)) {
                throw new ArgumentException("dateiname muss angegeben werden");
            }
            try { return mgr.isValid(fileName); }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }
    }
}
