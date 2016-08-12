using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn {
    public interface IExtensionManager {
        Exception willThrow { get; set; }

        bool isValid(string fileName);
    }
}
