using System;

namespace movieEngine.Tickets.Models
{
    public class Showing
    {
        public static int TotalSeats = 120; 
        public int ShowingId { get; set; }
        public int MovieId { get; set; }
        public DateTime StartTime {get; set; }
        public int TheaterId { get; set; }
        public int TicketsSold { get; set; }
        public int AvailableSeats 
        {
            get {
                return TotalSeats - this.TicketsSold;
            }
        }
        public Showing MakeCopy(){
            return (Showing) this.MemberwiseClone();
        }
    }
}