using System;

namespace UTN_Students.Web.ViewModels
{
    public class StudentVM
    {
        public int StudentId { get; set; }
        public int CareerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public string FileNumber { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
    }
}
