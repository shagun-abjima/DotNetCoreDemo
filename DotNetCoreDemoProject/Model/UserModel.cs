using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Model
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public int UserType { get; set; }

    }
}
