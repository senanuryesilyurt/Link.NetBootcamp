
namespace ServiceLayer.Models.Responses
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //default data ya eşittir.
        public SuccessDataResult(T data, string message) : base(data, true, message) { }
        public SuccessDataResult(T data) : base(data, true) { }
        public SuccessDataResult(string message):base(default, true, message) { }
        public SuccessDataResult() : base(default, true) { }
    
    }
}
