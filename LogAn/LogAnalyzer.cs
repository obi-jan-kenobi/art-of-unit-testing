using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn {
    public class LogAnalyzer {

        public bool wasLastFileNameValid { get; set; }

        public bool isValidLogFileName(string fileName) {



            wasLastFileNameValid = false;
            if(string.IsNullOrEmpty(fileName)) {
                throw new ArgumentException("dateiname muss angegeben werden");
            }
            if (!fileName.EndsWith(".SFL", StringComparison.CurrentCultureIgnoreCase)) {
                return false;
            } else {
                wasLastFileNameValid = true;
                return true;
            }
        }
    }
}
