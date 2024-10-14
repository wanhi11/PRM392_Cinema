﻿using System;
using System.Collections.Generic;

namespace PRM_API.Models;

public partial class Showtime
{
    public int ShowtimeId { get; set; }

    public int MovieId { get; set; }

    public int HallId { get; set; }

    public DateTime ShowDate { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual CinemaHall Hall { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;
}