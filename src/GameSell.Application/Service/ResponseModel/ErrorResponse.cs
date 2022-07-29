using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Application.Service.ResponseModel
{
    public class ErrorResponse:Response
    {
       
        public ErrorResponse(string message):base(false, message)
        {
            
        }
    }
}
