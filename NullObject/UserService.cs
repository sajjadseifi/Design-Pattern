using System.Collections.Generic;

namespace Design_Pattern.NullObject
{
    public class UserService
    {
        private List<User> _users = new List<User>(){
            new User("sajjad", true),
            new User("reza", false),
            new User("ali", false),
            new User("pouya", true),
            new User("koko", true)
        };
        public UserBase GetUser(string uname)
        {
            foreach (var usr in _users)
                if (usr.Username == uname)
                    return usr;

            return new NullUser();
        }
    }
}