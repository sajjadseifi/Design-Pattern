namespace Design_Pattern.NullObject
{
    public abstract class UserBase
    {
        public bool Authenticated { get; set; }
        public UserBase(bool authenticated)
        {
            Authenticated = authenticated;
        }

    }
}