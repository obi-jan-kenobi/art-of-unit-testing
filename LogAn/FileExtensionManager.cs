using System;

namespace LogAn {
    public class FileExtensionManager : IExtensionManager {
        public FileExtensionManager() {
        }

        public Exception willThrow {
            get {
                throw new NotImplementedException();
            }

            set {
                throw new NotImplementedException();
            }
        }

        public bool isValid(string filename) {
            return true;
        }
    }
}