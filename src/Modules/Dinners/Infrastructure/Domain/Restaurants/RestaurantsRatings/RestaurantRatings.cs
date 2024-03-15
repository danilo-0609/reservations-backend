﻿using Dinners.Domain.Restaurants;
using Dinners.Domain.Restaurants.RestaurantRatings;

namespace Dinners.Infrastructure.Domain.Restaurants.RestaurantsRatings;

internal sealed class RestaurantRatings
{
    public RestaurantId RestaurantId { get; set; }

    public RestaurantRatingId RestaurantRatingId { get; set; }
}
