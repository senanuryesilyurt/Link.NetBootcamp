using Core.Entities.Abstract;

namespace Core.DTOs
{
    public class UserDto:IDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
