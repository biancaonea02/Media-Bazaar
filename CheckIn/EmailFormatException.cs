using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    class EmailFormatException : FormatException
    {
        public EmailFormatException(string message) : base(message)
        { }

    }
}
