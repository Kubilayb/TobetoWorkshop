using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Types
{
    public class BusinessException : Exception
    {
        public BusinessException(string errorCode, string message = "Hata Yaptınız!!!") : base(message)
        {
            ErrorCode = errorCode;
        }

        public string ErrorCode { get; }  // sadece okumak için getter 
    }
}

