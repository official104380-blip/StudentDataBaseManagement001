using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentDataBaseManagement001.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string RollNumber { get; set; }
        public string Course { get; set; }
        public int Year { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}