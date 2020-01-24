using System;

namespace sample_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("anu",20 );
            Console.WriteLine(user.getUserDetails());
        }
    }
}
