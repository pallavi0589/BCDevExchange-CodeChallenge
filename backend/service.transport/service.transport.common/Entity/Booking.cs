﻿using System;
namespace service.transport.common.Entity
{
    public class Booking
    {
        public Int64 BookingId { get; set; }
        public int TransportOptionId { get; set; }
        public int PassengerCount { get; set; }
        public string UserName { get; set; }
    }
}

