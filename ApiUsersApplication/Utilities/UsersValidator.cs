namespace ApiUsersApplication.Utilities
{
    public static class UsersValidator
    {
        public static bool ValidJoiningDate(DateTime joiningDate)
        {
            // Joining date should not be more then 17th July 2025
            return joiningDate > new DateTime(2025, 7, 17, 23, 59, 59);
        }

        public static bool ValidIsMember(bool isActive, string memberType)
        {
            string[] memberTypes = { "Senior Manager", "Escalation Manager", "Sales Manager" };

            // If user is active and memberTypes is available, then is member is true else false
            return isActive && memberTypes.Contains(memberType, StringComparer.OrdinalIgnoreCase);
        }
    }
}
