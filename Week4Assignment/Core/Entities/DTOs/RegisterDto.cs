using Core.Entities.Abstract;

namespace Core.DTOs
{
    public class RegisterDto:IDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
