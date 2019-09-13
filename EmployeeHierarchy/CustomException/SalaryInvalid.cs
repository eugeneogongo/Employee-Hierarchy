using System;
using System.Collections;
using System.Runtime.Serialization;

namespace EmployeeHierarchy.CustomException
{
    /// <summary>
    /// Thrown when salary is negative or not a number
    /// </summary>
    class SalaryInvalid : Exception
    {
        public override Exception GetBaseException()
        {
            return base.GetBaseException();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        public override string Message { get; }
        public override IDictionary Data { get; }
        public override string StackTrace { get; }
        public override string HelpLink { get; set; }
        public override string Source { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public SalaryInvalid()
        {
        }

        public SalaryInvalid(string message) : base(message)
        {
        }

        public SalaryInvalid(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SalaryInvalid(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
