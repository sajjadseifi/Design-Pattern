using System;
using design_pattern;

namespace Design_Pattern.NullObject
{
    public class NullObject : IRun
    {
        public void Run()
        {
            UserService userService = new UserService();

            // Sajjad Authentication  
            var sajjad = userService.GetUser("sajjad");
            if (sajjad is NullUser)
                Console.WriteLine("sajjad Is NullUser");

            if (sajjad.Authenticated)
                Console.WriteLine("sajjad Is Authenticated");
            else
                Console.WriteLine("sajjad Is Authenticated");

            // Reza Authentication  
            var reza = userService.GetUser("pp");

            if (reza is NullUser)
                Console.WriteLine("Reza Is NullUser");

            if (reza.Authenticated)
                Console.WriteLine("reza Is Authenticated");
            else
                Console.WriteLine("reza Is Authenticated");
        }
    }
}