using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
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
                if (string.IsNullOrEmpty(user.Role))
                {
                    return "Please select a role.";
                }
                //user
                if (repo.IsUserExists(user.UserName))
                {
                    return "Username already exists.";
                }
                return "Valid";
            }
            catch (Exception )
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
            user.IsApproved = false;

            //adduser
            repo.AddUser(user);
            return "Sign up successful! Waiting for admin approval";
        }

        public User LogIn(string userName, string password)
        {
            if (userName == AdminUserName && password == AdminPassword)
            {
                return new User
                {
                    UserName = AdminUserName,
                    Role = "Admin",
                    IsApproved = true
                };
            }
            //check db for regular user
            User validUser = repo.ValidateUser(userName, password);
            if (validUser != null && validUser.IsApproved) 
            { 
                return validUser; 
            }
            return null; 
        }

        public DataTable GetPendingUsers()
        {
            return repo.GetPendingUsers();
        }
        public string ApproveUser(int userId)
        {
            try
            {
                repo.ApproveUser(userId);
                return "User approved successfully.";
            }
            catch (Exception ex)
            {
                return "An error occurred while approving the user: " + ex.Message;
            }
        }
        public string RejectUser(int userId)
        {
            try
            {
                repo.RejectUser(userId);
                return "User rejected successfully.";
            }
            catch (Exception ex)
            {
                return "An error occurred while rejecting the user: " + ex.Message;
            }
        }

    }


}

