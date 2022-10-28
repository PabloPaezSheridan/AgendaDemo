using AgendaDemo.Helpers;
using System.ComponentModel.DataAnnotations;

namespace AgendaDemo.Entities
{
    public class User
    {

        public int Id { get; set; }
        public string UserName { get; set; }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = Security.CreateSHA512(value); }
        }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
