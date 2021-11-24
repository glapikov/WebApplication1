namespace WebApplication1.Models
{
    public partial class Schedule
    {
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public int? LessonId { get; set; }
        public int? WeekId { get; set; }
        public int? ClassId { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual DaysOfWeek Week { get; set; }
        public virtual Class Class { get; set; }
    }
}
