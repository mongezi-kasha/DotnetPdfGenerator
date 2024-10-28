namespace DotnetPdfGenerator.Models
{
    public class ChurchMembers
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public ChurchDepartments Departments { get; set; }
    }
}
