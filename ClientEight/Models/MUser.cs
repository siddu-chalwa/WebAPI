using System;
using System.Linq;

namespace ClientEight.Models
{
    /// <summary>
    /// class: interacting with DB and performing various function
    /// </summary>
    public class MUser : IUser
    {
        DbContextClass dbContextClass;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="dbContextClass"></param>
        public MUser(DbContextClass dbContextClass)
        {
            this.dbContextClass = dbContextClass;
        }
        /// <summary>
        /// function: delete the row from the DB
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool delete(string userID, string password)
        {
            try
            {
                User user = dbContextClass.entities.FirstOrDefault(u => (u.UserID == userID && u.Password == password));
                if (user == null)
                    return false;
                dbContextClass.entities.Remove(user);
                dbContextClass.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// function: display the row values
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public User details(string userID)
        {
            try
            {
                return dbContextClass.entities.FirstOrDefault(u => (u.UserID == userID));
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// function: change the old data with new data
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool edit(User user)
        {
            try
            {
                User userVar = dbContextClass.entities.FirstOrDefault(u => u.UserID == user.UserID);
                if (userVar == null)
                    return false;
                userVar.Name = user.Name;
                userVar.Password = user.Password;
                userVar.Salary = user.Salary;
                dbContextClass.entities.Update(userVar);
                dbContextClass.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// function: create a new row in DB
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool signup(User user)
        {
            try
            {
                if (dbContextClass.entities.Any<User>(u => u.UserID == user.UserID))
                    return false;
                dbContextClass.entities.Add(user);
                dbContextClass.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// fuction: authenticatig the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool login(User user)
        {
            try
            {
                return  
            catch (Exception)
            {

                throw;
            }
        }
    }
}
