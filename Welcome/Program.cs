using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.ViewModel;
using Welcome.View;
using Welcome.Others;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Name="Ralitsa",
                Password="123456",
                Role=UserRolesEnum.STUDENT,
                FacultyNumber=121220156,
                Email="rgoranova@tu-sofia.bg"
            };
            UserViewModel uvm=new UserViewModel(user);
            UserView uv = new UserView(uvm);
            uv.Display();
            Console.ReadKey();
        }
    }
}