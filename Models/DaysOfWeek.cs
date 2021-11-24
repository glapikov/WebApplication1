using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class DaysOfWeek
    {
        public DaysOfWeek()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
