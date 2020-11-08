using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class BusStationNotExistException : Exception
    {
        public BusStationNotExistException()
        {
        }

        public BusStationNotExistException(string message) : base(message)
        {
        }

        public BusStationNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BusStationNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
