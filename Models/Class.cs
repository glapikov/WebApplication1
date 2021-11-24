using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Class
    {
        public Class()
        {
            Schedules = new HashSet<Schedule>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}