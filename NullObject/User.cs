using System.Collections.Generic;

namespace Design_Pattern.NullObject
{
    public class User : UserBase
    {
        public string Username { get; set; }

        public User(string username, bool authenticated = false) : base(authenticated)
        {
            Username = username;
        }

    }
}