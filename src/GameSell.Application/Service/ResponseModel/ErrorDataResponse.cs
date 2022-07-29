using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Application.Service.ResponseModel
{
    public class ErrorDataResponse<T>:DataResponse<T>
    {
        
        public ErrorDataResponse(string message, T data):base(false,message,data)
        {

        }
    }
}
