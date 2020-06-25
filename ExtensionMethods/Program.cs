using System;

namespace ExtensionMethods {
    class Program {
        static void Main(string[] args) {

            long i = 3;
            i.ToString();
            var squaredValue = i.Squared();
            var cubedValue = i.Cubed();
            var magicValue = ((long)88).Squared();
            var bigValue = ((long)5).Cubed().Squared();

            var fx = 37.EvalFunc(); // 1485
        }
    }
}
