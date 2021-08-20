using System;
using System.Runtime.Serialization;

namespace Exercise19
{
    [Serializable]
    internal class DomainException : Exception
    {
        public DomainException()
        {
        }

        public DomainException(string message) : base(message)
        {
        }
 
    }
}