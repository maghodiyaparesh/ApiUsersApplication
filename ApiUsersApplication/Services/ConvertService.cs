using ApiUsersApplication.Models;
using ApiUsersApplication.Utilities;
using Newtonsoft.Json;

namespace ApiUsersApplication.Services
{
    public class ConvertService : IConvertService
    {
        public List<Users> ConvertToUsers(string apiRequest)
        {
            var usersList = new List<Users>();
            var apiRequests = JsonConvert.DeserializeObject<List<ApiRequest>>(apiRequest, new JsonSerializerSettings { DateTimeZoneHandling = DateTimeZoneHandling.Utc });

            foreach (var request in apiRequests)
            {
                if (!UsersValidator.ValidJoiningDate(request.JoiningDate)) continue;

                var user = new Users
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.EmailAddress,
                    IsActive = ConvertToBool(request.Status),
                    JoiningDate = request.JoiningDate,
                    MemberType = request.MemberType,
                    JobTitle = request.JobTitle ?? ""
                };

                user.IsMember = UsersValidator.ValidIsMember(user.IsActive, user.MemberType);

                usersList.Add(user);
            }

            return usersList;
        }

        private bool ConvertToBool(dynamic value)
        {
            if (value is string s)
                return s.Equals("Active", StringComparison.OrdinalIgnoreCase) || s.Equals("True", StringComparison.OrdinalIgnoreCase);
            
            if (value is bool b)
                return b;

            return false;
        }

    }
}
