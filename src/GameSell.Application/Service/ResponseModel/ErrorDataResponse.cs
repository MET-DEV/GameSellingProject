﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Application.Service.ResponseModel
{
    public class ErrorDataResponse<T>:Response
    {
        public bool Status { get; set; }


        public string Message { get; set; }
        public T Data { get; set; }
        public ErrorDataResponse(bool status, string message, T data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}
