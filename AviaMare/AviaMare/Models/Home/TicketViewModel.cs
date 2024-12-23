﻿namespace AviaMare.Models.Home
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public int IdPlane { get; set; }
        public int Time { get; set; }
        public decimal Cost { get; set; }
        public DateTime TakeOffTime { get; set; }
        public DateTime LandingTime { get; set; }
        public int Count { get; set; }
    }
}