using System;
using UTNAvanzada2.Common.Models;

namespace UTN_Students.Models.Models
{
    public class Student : Entity
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

        public override int GetId()
        {
            return this.StudentId;
        }

        public override void SetId(int studentId)
        {
            this.StudentId = studentId;
        }
    }
}
