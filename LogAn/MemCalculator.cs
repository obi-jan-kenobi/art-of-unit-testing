using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn {
    public class MemCalculator {
        private int sum = 0;
        public void add(int number) {
            sum += number;
        }
        public int getSum() {
            int temp = sum;
            sum = 0;
            return temp;
        }
    }
}
