using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBook
{
    public class AddressException : Exception
    {

        ExceptionType exceptionType;
        public enum ExceptionType
        {
            Connection_Failed, Contact_Not_Updated, Contact_Not_Add
        }
        public AddressException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
