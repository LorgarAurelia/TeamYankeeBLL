using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamYankeeBLL.Exceptions
{
    public class NoDataException : Exception
    {
        public override string Message { get; } = ExceptionsMessages.EmptyResultException;
    }
}
