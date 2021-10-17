using System;

namespace Desctructor
{
    class User
    {
        public User()
        {
            Console.WriteLine("An Instance of class created");
        }
        // Destructor
        ~User()
        {
            Console.WriteLine("An Instance of class destroyed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Details();
            GC.Collect();
        }
        public static void Details()
        {
            // Created instance of the class
            User user = new User();
        }
    }
}
