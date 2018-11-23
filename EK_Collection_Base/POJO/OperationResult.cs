using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK_Collection_Base.POJO
{
    /// <summary>
    /// Provides a success flag and message
    /// useful as a method return type.
    /// </summary>
    public class OperationResult
    {
        public OperationResult()
        {
        }

        public OperationResult(bool success, string message) : this()
        {
            this.Success = success;
            this.Message = message;
        }

        public bool Success { get; }
        public string Message { get; }
    }

    /// <summary>
    /// Provides a decimal amount of message
    /// useful as a method return type.
    /// </summary>
    public class OperationResultDecimal
    {
        public OperationResultDecimal()
        {
        }

        public OperationResultDecimal(decimal result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public decimal Result { get; }
        public string Message { get; }
    }
}
