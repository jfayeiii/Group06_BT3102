using GOSO_Hotel.Model;
using GOSO_Hotel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSO_Hotel.Controller
{
    public class UserController
    {
        private UserRepository _userRepository;

        public UserController()
        {
            this._userRepository = new UserRepository();
        }

        public UserModel ValidateUser(string Username, string Password, bool isAdmin)
        {
            try
            {
                if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Username))
                {
                    throw new Exception("Password/Username cannot be empty.");
                }
                else
                {
                    Console.WriteLine("Login Succesfull");
                }
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _userRepository.ValidateUser(Username, Password, isAdmin);
        }
    }
}
