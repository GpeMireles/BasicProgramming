using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming {
    // Custom Exception class
    public class ErrorException : Exception {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Error message that the exceptions show</param>
        public ErrorException(string message) : base(message) { }
    }
    public static class ThrowFail {
        /// <summary>
        /// Throw an exception
        /// </summary>
        /// <exception cref="ErrorException">Custom exception</exception>
        public static void Fail() {
            throw new ErrorException("Error!"); 
        }
    }
}
