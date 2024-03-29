﻿namespace Dinners.Domain.Restaurants.RestaurantSchedules;

public sealed record RestaurantScheduleStatus
{
    public string Value { get; private set; }

    public static RestaurantScheduleStatus Opened => new RestaurantScheduleStatus(nameof(Opened));

    public static RestaurantScheduleStatus Closed => new RestaurantScheduleStatus(nameof(Closed));

    private RestaurantScheduleStatus(string value)
    {
        Value = value;
    }

    private RestaurantScheduleStatus() { }
}
