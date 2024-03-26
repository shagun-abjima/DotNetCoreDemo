using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Model
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Mobile { get; set; }
        public int Salary { get; set; }
        public String Email { get; set; }

    }
}
