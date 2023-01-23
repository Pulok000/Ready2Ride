namespace Ready2Ride.Server.Data
{
    public class Ticket
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string BusName { get; set; }
        public DateTime ScheduleDate { get; set; }
    }
}
