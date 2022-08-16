using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    public class ErrorException : Exception {
        public ErrorException(string message) : base(message) { }
    }
    public static class ThrowFail {
        public static void Fail() {
            throw new ErrorException("Error!"); 
        }
    }
}
