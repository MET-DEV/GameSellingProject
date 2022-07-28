using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Application.Service.ResponseModel
{
    public class SuccessResponse:Response
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public SuccessResponse(bool status, string message)
        {
            Status = status;
            Message = message;
        }
    }
}
