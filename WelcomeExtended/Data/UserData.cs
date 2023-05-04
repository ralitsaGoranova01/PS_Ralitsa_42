using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data;

public class UserData
{
    public List<User> _users;
    public int _nextid;

 //   public UserData(List<User> users, int nextid)
   // {
    //    _users = users;
     //   _nextid = nextid;
    //}

    public UserData()
    {
        _users = new List<User>();
        _nextid = 0;
    }

    public void AddUser(User user)
    {
        user.FacultyNumber = _nextid;
        _users.Add(user);
    }
    
    public void DeleteUser(User user)
    {
        _users.Remove(user);
    }

    public bool ValidateUser(string name, string password)
    {
        foreach (var user in _users)
        {
            if (user.Name == name && user.Password == password)
            {
                return true;
            }
        }

        return false;
    }

    public bool ValidateUserLambda(string name, string password)
    {
        return _users.Where(x => x.Name == name && x.Password == password)
            .FirstOrDefault() != null ? true : false;
    }

    public bool ValidateUserLinq(string name, string password)
    {
        var ret = from user in _users
            where user.Name == name && user.Password == password
            select user.FacultyNumber;
        return ret != null ? true : false;
    }

    public User GetUser(string username, string password)
    {
        return _users.FirstOrDefault(u => u.Name == username && u.Password == password);
    }
    
    
    public void SetActive(string username, DateTime expires) {
        User user = _users.FirstOrDefault(u => u.Name == username);
        if (user != null) {
            
        }
    }

    public void AssignUserRole(string username, UserRolesEnum role)
    {
        User user = _users.FirstOrDefault(u => u.Name == username);
        if (user != null)
        {
            user.Role = role;
        }
    }
}