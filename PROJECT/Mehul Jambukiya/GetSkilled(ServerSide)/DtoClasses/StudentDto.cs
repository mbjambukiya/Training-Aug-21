using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.DtoClasses
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public string GenderName { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int ZipCode { get; set; }
        public DateTime LastModified { get; set; }
    }
}
