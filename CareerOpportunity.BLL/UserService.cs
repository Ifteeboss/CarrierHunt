using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using CareerOpportunity.Models;
using CareerOpportunity.DAL;


namespace CareerOpportunity.BLL
{
    public class UserService
    {
        //Admin details:
        private const string AdminUserName = "admin";
        private const string AdminPassword = "admin123";

        private readonly UserRepository repo = new UserRepository();

        public string ValidateSignUp(User user, string confirmPassword, bool agreedTrems)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(user.UserName) ||
                    string.IsNullOrWhiteSpace(user.Password) ||
                    string.IsNullOrWhiteSpace(user.Email))
                {
                    return "All fields are required.";
                }
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(user.Email, emailPattern))
                {
                    return "Please enter a valid email address.";
                }

                if (user.Password != confirmPassword)
                {
                    return "Password do not match.";
                }
                if (!agreedTrems)
                {
                    return "You must agree to the terms and conditions.";
                }
                //user
                if (repo.IsUserExists(user.UserName))
                {
                    return "Username already exists.";
                }
                return "Valid";
            }
            catch (Exception ex)
            {
                
                return "An error occurred during validation.";
            }
        }

        public string SignUp(User user, string confirmPassword, bool agreedTerms)
        {
            string validation = ValidateSignUp(user, confirmPassword, agreedTerms);
            if (validation != "Valid")
            {
                return validation;
            }

            //adduser
            repo.AddUser(user);
            return "Sign up successful!";
        }

        public string LogIn(string userName, string password)
        {
            if (userName == AdminUserName && password == AdminPassword)
            {
                return "Admin";
            }
            //check db for regular user
            bool validUser = repo.ValidateUser(userName, password);
            if (validUser)
            {
                return "User";
            }
            return "Invalid username or password.";
        }


    }
}
