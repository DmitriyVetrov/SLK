using System;

namespace Slk.Models
{
    public class User : AppEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string ConnectionId { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FirstName))
                return "Unknown";
            else
                return $"{FirstName} {LastName}";
        }
    }
}