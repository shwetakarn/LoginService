using LoginService.Models;

namespace LoginService.LoginRepoitory
{
    public interface ILoginRepoitory
    {
         int CreateUser(User obj);

         bool LoginValidate(string username, string password);



    }
}