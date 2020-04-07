using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTest
{
    /// <summary>
    /// class: to perform unit test
    /// </summary>
    public class UnitTest1
    {
        List<User> entities = new List<User>() { 
            new User(){ UserID = "sidduchalwa@gmail.com", Password = "siddu123", Name = "sidduchalwa", Age = 23, Salary = 450000, ID = 1}
        };
        /// <summary>
        /// delete test
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        [Theory]
        [InlineData("sidduchalwa@gmail.com", "siddu123")]
        public void delete(string userID, string password)
        {
            try
            {
                Assert.NotNull(entities.FirstOrDefault(u => u.UserID == userID && u.Password == password));
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// details test
        /// </summary>
        /// <param name="userID"></param>
        [Theory]
        [InlineData("sidduchalwa@gmail.com")]
        public void details(string userID)
        {
            try
            {
                Assert.NotNull(entities.FirstOrDefault(u => (u.UserID == userID)));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    class User
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
