using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1
{
    public class TeacherRepository
    {
        private ScheduleContext _context;

        public TeacherRepository(ScheduleContext context)
        {
            _context = context;
        }
        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public IEnumerable<Teacher> Get()
        {
            return _context.Teachers.FromSqlRaw("SELECT * FROM teachers WHERE id NOT IN (SELECT teacher_id FROM schedule)").ToList();
        }
    }
}