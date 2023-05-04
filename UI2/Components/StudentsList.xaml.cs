using System.Windows.Controls;
using DataLayer.Database;

namespace UI2.Components;

public partial class StudentsList : UserControl
{
    public StudentsList()
    {
        InitializeComponent();
        using (var context=new DatabaseContext())
        {
            var records = context.Users.ToString();
            students.DataContext = records;
        }
    }
}