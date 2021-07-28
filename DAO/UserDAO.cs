using System.Collections.Generic;

namespace Design_Pattern.DAO
{
    public class UserDAO : DAO<User>
    {
        private List<User> _users = new List<User>();

        public void delete(User t) => _users.Remove(t);

        public User get(string email) => _users.Find(x => x.Email == email);
        public List<User> getAll() => _users;
        public void save(User t) => _users.Add(t);
        public void update(User t, string name = null, string email = null)
        {
            t.Email = email ?? t.Email;
            t.Name = email ?? t.Name;
        }
    }
}