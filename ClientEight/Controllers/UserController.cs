
using ClientEight.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientEight.Controllers
{
    /// <summary>
    /// class: UserContoroller :contains organization, details, signup, delete, edit and login actionResult
    /// </summary>
    [Route("dn")]
    public class UserController: Controller
    {
        private readonly IUser iuser;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="iuser"></param>
        public UserController(IUser iuser)
        {
            this.iuser = iuser;
        }
        /// <summary>
        /// actionResult: Website
        /// </summary>
        /// <returns></returns>
        [Route("~/")]
        public string Website()
        {
            return "Welcome to Website.";
        }
        /// <summary>
        /// actionResult: Organization
        /// </summary>
        /// <returns></returns>
        [Route("~/dn")]
        public string Organization()
        {
            return "Welcome to Diebold Nixdorf.";
        }
        /// <summary>
        /// actionResult: details
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [Route("details/{userID}")]
        public JsonResult details(string userID)
        {
            try
            {
                User user = iuser.details(userID);
                return (user == null) ? Json(new { message = "Account not Exist" }) : Json(new { Name = user.Name, Age = user.Age, Salary = user.Salary });
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// actionResult: signup
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="salary"></param>
        /// <returns></returns>
        [Route("signup/{userID}&{password}&{name}&{age}&{salary}")]
        public string signup(string userID, string password, string name, int age, int salary)
        {
            if(!ValidationClass.DataValidation(new User() { UserID = userID, Password = password, Name = name, Age = age, Salary = salary }))
            {
                return "enter valid details";
            }
            try
            {
                return iuser.signup(new User() { UserID = userID, Password = password, Name = name, Age = age, Salary = salary }) ? "Account Created" : "Account Exist";
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// actionResult: delete
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [Route("delete/{userID}&{password}")]
        public string Delete(string userID, string password)
        {
            try
            {
                return iuser.delete(userID, password) ? "Account Deleted" : "Account not Exist";
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// actionResult: edit
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="salary"></param>
        /// <returns></returns>
        [Route("edit/{userID}&{password}/{name}&{age}&{salary}")]
        public string edit(string userID, string password, string name, int age, int salary)
        {
            try
            {
                return iuser.edit(new User() { UserID = userID, Password = password, Name = name, Age = age, Salary = salary }) ? "Update Sucessfull" : "Account not Exist";
            }
            catch (System.Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// actionResult: login
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [Route("login/{userID}&{password}")]
        public string login(string userID, string password)
        {
            try
            {
                return iuser.login(new Models.User() { UserID = userID, Password = password }) ? "valid user" : "invalid userID or password";
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
    