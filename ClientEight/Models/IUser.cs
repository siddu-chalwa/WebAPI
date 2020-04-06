namespace ClientEight.Models
{
    /// <summary>
    /// interface: help in dependecy injuction
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// function defination
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public User details(string userID);
        /// <summary>
        /// function defination
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool signup(User user);
        /// <summary>
        /// function defination
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool delete(string userID, string password);
        /// <summary>
        /// function defination
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool edit(User user);
        /// <summary>
        /// function defination
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool login(User user);
    }
}

/*
 * get - details
 * post - signup, login
 * update - edit
 * delete - delete
 */