using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Application.Service.ResponseModel
{
    public class SuccessResponse:Response
    {
     
        public SuccessResponse(string message):base(true,message)
        {
           
        }
    }
}
