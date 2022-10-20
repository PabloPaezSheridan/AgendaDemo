using AgendaDemo.Entities;

namespace AgendaDemo.Repository
{
    public interface IUserRepository
    {
        public User? Get(int id);

        public List<User> GetAll();

        public void Add(User user);

    }
}
