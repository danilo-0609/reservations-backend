﻿namespace Dinners.Domain.Menus.Schedules;

public sealed record TimeRange
{
    public TimeSpan Start { get; set; }

    public TimeSpan End { get; set; }

    public TimeRange(TimeSpan start, TimeSpan end)
    {
        Start = start;
        End = end;
    }
}
