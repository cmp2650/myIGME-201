using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_UnitTest2_14
{
    public class Friend
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Friend friend = new Friend();
            Friend enemy;

            // create my friend Charlie Sheen
            friend.Name = "Charlie Sheen";
            friend.Greeting = "Dear Charlie";
            friend.Birthdate = DateTime.Parse("1967-12-25");
            friend.Address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = new Friend();
            enemy.Name = friend.Name;
            enemy.Greeting = "Sorry Charlie";
            enemy.Birthdate = friend.Birthdate;
            enemy.Address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.Greeting} => {enemy.Greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.Address} => {enemy.Address}");
        }
    }
}
