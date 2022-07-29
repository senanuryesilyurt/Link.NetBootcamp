using Core.Entities.Abstract;


namespace Core.DTOs
{
    public class LoginDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
