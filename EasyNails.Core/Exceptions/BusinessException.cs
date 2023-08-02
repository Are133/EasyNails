using System;
using System.Collections.Generic;
using System.Text;

namespace EasyNails.Core.Exceptions
{
    public class BusinessException : Exception
    {
        #region Builder
        public BusinessException()
        {
                
        }

        public BusinessException(string message) : base(message) { }
        #endregion
    }
}
