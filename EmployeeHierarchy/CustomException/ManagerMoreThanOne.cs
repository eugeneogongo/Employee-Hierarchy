using System;
using System.Runtime.Serialization;

namespace EmployeeHierarchy.CustomException
{
    class ManagerMoreThanOne : Exception
    {
        public ManagerMoreThanOne()
        {
        }

        public override Exception GetBaseException()
        {
            return base.GetBaseException();
        }

        public override string Message { get; }

        public ManagerMoreThanOne(string message) : base(message)
        {
        }

        public ManagerMoreThanOne(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ManagerMoreThanOne(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
