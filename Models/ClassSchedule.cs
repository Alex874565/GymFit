namespace GymFit.Models
{
    public class ClassSchedule
    {
        private Class ScheduledClass { get; set; }

        private DateTime StartTime { get; set; }

        private DateTime EndTime { get; set; }

        private List<Client> Clients { get; set; }

        private int ClientNo { get; set; }
    }
}
