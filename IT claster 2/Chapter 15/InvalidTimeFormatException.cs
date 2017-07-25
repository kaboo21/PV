using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15
{
    [Serializable]
    class InvalidTimeFormatException:ApplicationException
    {
        public InvalidTimeFormatException() { }
        public InvalidTimeFormatException(string message) : base(message) { }
        public InvalidTimeFormatException(string message, ApplicationException innerException) :
            base(message, innerException) { }

        protected InvalidTimeFormatException(SerializationInfo info,
            StreamingContext context) : base(info, context) { }


    }
}
