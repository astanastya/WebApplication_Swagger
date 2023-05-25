using WebApplication_Test.DB;

namespace WebApplication_Test
{
    public static class UserService
    {
        private static List<User> _users; 

        static UserService()
        {
            _users = UserRepository.Get();
        }

        public static User Add(User newUser)
        {
            newUser.Id = _users.Any() ? _users.Max(user => user.Id) + 1 : 1;
            _users.Add(newUser);

            //for create in json
            UserRepository.Save(_users);

            return newUser;
        }

        public static List<User> Get()
        {
            return _users;
        }

        public static User Get(int userId)
        {
            var user = _users.FirstOrDefault(user => user.Id == userId);
            if (user == null)
                throw new ArgumentException($"User with id {userId} does not exist");
            return user;
        }

        public static bool Delete(int id)
        {
            var userDetails = Get(id);
            _users.Remove(userDetails);

            //for create in json
            UserRepository.Save(_users);

            return true;
        }

        public static bool Update(User user)
        {
            var userDetails = Get(user.Id);
            userDetails.Name = user.Name;
            userDetails.Email = user.Email;
            userDetails.Skype = user.Skype;
            userDetails.Email = user.Email;
            userDetails.Department = user.Department;
            userDetails.Designation = user.Designation;

            //for create in json
            UserRepository.Save(_users);

            return true;
        }
    }
}