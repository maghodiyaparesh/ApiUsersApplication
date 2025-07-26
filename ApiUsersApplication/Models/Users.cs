namespace ApiUsersApplication.Models
{
    public class Users
    {
        public Guid Id { get; set; } = new Guid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime JoiningDate { get; set; }
        public string MemberType { get; set; }
        public string JobTitle { get; set; }
        public bool IsMember { get; set; }

    }
}
