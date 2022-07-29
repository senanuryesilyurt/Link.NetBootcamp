using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Models.Responses
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
