using AgendaDemo.Entities;

namespace AgendaDemo.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> FakeUsers = new List<User>()
        {
            new User()
            {
                Id = 0,
                UserName = "First",
            }
        };

        public User? Get(int id)
        {
            return FakeUsers.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetAll()
        {
            return FakeUsers;
        }

        public void Add(User user)
        {
            FakeUsers.Add(user);
        }
    }
}
