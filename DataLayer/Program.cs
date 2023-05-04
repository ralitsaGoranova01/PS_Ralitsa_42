// See https://aka.ms/new-console-template for more information

using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new DatabaseContext())
        {
            context.Database.EnsureCreated();
            context.Add<DatabaseeUser>(new DatabaseeUser()
            {
                Name = "user",
                Password = "pass",
                Role = UserRolesEnum.STUDENT,
                Email = "rali@dnd"
            });
            context.SaveChanges();
            var users = context.Users.ToList();
            Console.ReadKey();
            Console.WriteLine("username:");
            var username = Console.ReadLine();

            Console.WriteLine("pass:");
            var password = Console.ReadLine();
        
            var user = users.FirstOrDefault(u => u.Name == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            Console.ReadLine();
        }
        
    
    }
}