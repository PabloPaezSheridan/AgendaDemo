using System.ComponentModel.DataAnnotations;

namespace AgendaDemo.Models
{
    public class AddUserRequest
    {
        [MaxLength(10)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
