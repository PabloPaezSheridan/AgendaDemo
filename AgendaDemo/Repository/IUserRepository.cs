using AgendaDemo.Entities;
using AgendaDemo.Models;

namespace AgendaDemo.Repository
{
    public interface IUserRepository
    {
        public User? Get(int id);

        public List<User> GetAll();

        public void Add(User user);

        public User? ValidateUser(AuthenticationRequestBody user);
    }
}
