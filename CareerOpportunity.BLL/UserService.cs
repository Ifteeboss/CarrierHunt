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

        public string ValidateApplicantSignUp(User user, string confirmPassword, bool agreedTerms)
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
                if (!agreedTerms)
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
            catch (Exception )
            {
                
                return "An error occurred during validation.";
            }
        }

        public string ValidateRecruiterSignUp(User user, string confirmPassword, bool agreedTerms)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(user.UserName) ||
                    string.IsNullOrWhiteSpace(user.Password) ||
                    string.IsNullOrWhiteSpace(user.Email)||
                    string.IsNullOrWhiteSpace(user.CompanyName))
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
                    return "Passwords do not match.";
                }
                if (!agreedTerms)
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
            catch (Exception)
            {

                return "An error occurred during validation.";
            }
        }

        public string SignUpApplicant(User user, string confirmPassword, bool agreedTerms)
        {
            string validation = ValidateApplicantSignUp(user, confirmPassword, agreedTerms);
            if (validation != "Valid")
            {
                return validation;
            }
            user.IsApproved = false;

            //adduser
            repo.AddApplicant(user);
            return "Applicant Sign up successful! Waiting for admin approval";
        }

        public string SignUpRecruiter(User user, string confirmPassword, bool agreedTerms)
        {
            string validation = ValidateRecruiterSignUp(user, confirmPassword, agreedTerms);
            if (validation != "Valid")
            {
                return validation;
            }
            user.IsApproved = false;

            //adduser
            repo.AddRecruiter(user);
            return "Recruiter Sign up successful! Waiting for admin approval";
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

        public DataTable GetPendingUsers(string role)
        {
            return repo.GetPendingUsers(role);
        }
        public string ApproveUser(int userId)
        {
            try
            {

                return repo.ApproveUser(userId); 
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
                
                return repo.RejectUser(userId); ;
            }
            catch (Exception ex)
            {
                return "An error occurred while rejecting the user: " + ex.Message;
            }
        }

        public int GetPendingCount(string role)
        {
            try
            {
                DataTable pendingUsers = repo.GetPendingUsers(role);
                return pendingUsers.Rows.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching pending count: " + ex.Message);
                return 0;
            }
        }

        public User GetUserById(int userId)
        {
            return repo.GetUserById(userId);
        }
        public string UpdateUser(User user)
        {
            try
            {
                return repo.UpdateUser(user);
            }
            catch (Exception ex)
            {
                return "An error occurred while updating the user: " + ex.Message;
            }
        }
        public string DeleteUser(int userId)
        {
            try
            {

                return repo.DeleteUser(userId); ;
            }
            catch (Exception ex)
            {
                return "An error occurred while rejecting the user: " + ex.Message;
            }
        }

        public DataTable GetAllUsersByRole(string role)
        {
            return repo.GetAllUsersByRole(role);
        }
    }


}

