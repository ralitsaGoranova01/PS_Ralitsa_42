using WelcomeExtended.Others;
using Welcome.Others;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Loggers;

try
{
 //   var user = new User
 //{
 //      Name = "John Smith",
 //     Password = "password123",
//        Role = UserRolesEnum.STUDENT
//   };
//
 //   var viewModel = new UserViewModel(user);
 //  var view = new UserView(viewModel);
 //   view.Display();
 //view.DisplayError();

 UserData userData = new UserData();
 User studentUser = new User()
 {
     Name = "student",
     Password = "122",
     Role = UserRolesEnum.STUDENT
 };
 userData.AddUser(studentUser);
 User teacherUser = new User()
 {
     Name = "teacher",
     Password = "12232",
     Role = UserRolesEnum.PROFESSOR
 };
 userData.AddUser(studentUser);
 Console.WriteLine("Enter username:");
 string name = Console.ReadLine();

 Console.WriteLine("Enter password:");
 string password = Console.ReadLine();
 
 User user = null;

 foreach (var u in userData._users)
 {
     if (userData.ValidateUser(name, password))
     {
         user = u;
         break;
     }
 }

 if (user != null)
 {
     Console.WriteLine(UserHelper.ToString(user));
 }
 else
 {
     throw new Exception("User not found");
 }

 
}
catch (Exception e)
{
    var log = new Delegates.ActionOnError(Delegates.Log);
    log(e.Message);
}
finally
{
    Console.WriteLine("Executed in any case!");
}