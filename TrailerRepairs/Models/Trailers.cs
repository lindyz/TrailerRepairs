using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrailerRepairs.Models
{
    public class Trailers
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}