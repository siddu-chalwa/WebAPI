using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientEight.Models
{
    /// <summary>
    /// class: for initial DB setup with pre defined data, and for hard coding the data to db
    /// </summary>
    public static class SeedingClass
    {
        /// <summary>
        /// function
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
			try
			{
                modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Name = "SidduChalwa",
                    Age = 23,
                    Salary = 450000,
                    UserID = "siddu@gmail.com",
                    Password = "@Siddu0.sid"
                }
                );
            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
