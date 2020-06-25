using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods {
    
    public static class IntExtensionMethods {

        public static int EvalFunc(this int x) {
            return (x * x) + (3 * x) + 5;
        }

        public static long Squared(this long val) {
            return val * val;
        }

        public static long Cubed(this long val) {
            return val * val * val;
        }
    }
}
