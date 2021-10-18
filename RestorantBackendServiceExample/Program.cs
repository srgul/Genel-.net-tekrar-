using System;

namespace RestorantBackendServiceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();

            menu.Category = "Sıcaklar";
            menu.Name = "Kahveler";
            menu.Price = 12;

            Console.WriteLine(menu.Price);
            Console.WriteLine(menu.Name);
            Console.WriteLine(menu.Category);


            User user = new User();

            user.Email = "user@email.com";
            user.Password = "123123";
            user.Name = "username";
            user.LastName = "user lastname";


            User user1 = new User();

            user1.Email = "user1@email.com";
            user1.LastName = "userlastname1";
            user1.Name = "username1";
            user1.Password = "userPass1";

            Console.WriteLine(user1.Password);

            Console.WriteLine("Hello World!");
        }
    }

    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
    }

    class Menu
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
