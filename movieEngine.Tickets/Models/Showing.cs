using System;

namespace movieEngine.Tickets.Models
{
    public class Showing
    {
        public int ShowingId { get; set; }
        public int MovieId { get; set; }
        public DateTime StartTime {get; set; }
        public int TheaterId { get; set; }
        public int TicketsSold { get; set; }
        public Showing MakeCopy(){
            return (Showing) this.MemberwiseClone();
        }
    }
}