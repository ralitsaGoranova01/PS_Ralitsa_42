using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers;

public static class UserHelper
{
    public static string ToString(this User user)
    {
        return $"Name: {user.Name}, Role: {user.Role}";
    }
    
    public static string ValidateCredentials(UserData userCollection,string name, string password)
    {
        string error = "";
        if (string.IsNullOrEmpty(name))
        {
            error= "The name cannot be empty";
        }

        if (string.IsNullOrEmpty(password))
        {
            error= "The password cannot be empty";
        }
        userCollection.ValidateUser(name, password);
        return error;
    }
    
    public static User GetUser(UserData userCollection, string name, string password)
    {
        return userCollection.GetUser(name, password);
    }
}