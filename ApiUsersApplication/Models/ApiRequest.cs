namespace ApiUsersApplication.Models
{
    public class ApiRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Status { get; set; }
        public DateTime JoiningDate { get; set; }
        public string MemberType { get; set; }
        public string JobTitle { get; set; }
    }
}
