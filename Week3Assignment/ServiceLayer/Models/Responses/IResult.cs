using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models.Responses
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
