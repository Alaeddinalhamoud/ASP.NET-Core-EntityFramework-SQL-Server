using ASP_Core_EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Core_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Core_EF.Repository
{
    public class EnrollmentRepository : IEnrollment
    {
        private DB_Context db;
        public EnrollmentRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Enrollment> GetEnrollments => db.Enrollments.Include(s => s.Students).Include(c => c.Courses);

        public void Add(Enrollment _Enrollment)
        {
            db.Enrollments.Add(_Enrollment);
            db.SaveChanges();
        }

        public Enrollment GetEnrollment(int? Id)
        {
            return db.Enrollments.Find(Id);
        }

        public void Remove(int? Id)
        {
           Enrollment dbEntity= db.Enrollments.Find(Id);
            db.Enrollments.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
