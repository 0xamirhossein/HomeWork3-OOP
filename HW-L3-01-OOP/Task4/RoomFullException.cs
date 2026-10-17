using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    internal class RoomFullException : Exception  //
                                                  // Summary:
                                                  //     Initializes a new instance of the System.Exception class with a specified error
                                                  //     message and a reference to the inner exception that is the cause of this exception.
                                                  //
                                                  //
                                                  // Parameters:
                                                  //   message:
                                                  //     The error message that explains the reason for the exception.
    {
        public RoomFullException(string message) : base(message)
        { 

        }
    }
}
