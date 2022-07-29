using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Application.Service.ResponseModel
{
    public class SuccessDataResponse<T>:DataResponse<T>
    {
        public SuccessDataResponse(string message, T data) :base(true,message,data)
        {
           
        }
    }
}
