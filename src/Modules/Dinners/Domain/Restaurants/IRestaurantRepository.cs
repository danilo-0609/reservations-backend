﻿using Dinners.Domain.Restaurants.RestaurantTables;
using Domain.Restaurants;

namespace Dinners.Domain.Restaurants;

public interface IRestaurantRepository
{
    Task<bool> ExistsAsync(RestaurantId restaurantId);

    Task<Restaurant?> GetRestaurantById(RestaurantId restaurantId);

    Task<List<string>> GetRestaurantImagesUrlById(RestaurantId restaurantId, CancellationToken cancellationToken);

    Task UpdateAsync(Restaurant restaurant);

    Task<List<RestaurantTable>> GetRestaurantTablesById(RestaurantId restaurantId, CancellationToken cancellationToken); 

    Task AddAsync(Restaurant restaurant, CancellationToken cancellationToken);

    Task DeleteAsync(RestaurantId restaurant, CancellationToken cancellationToken);

    Task<List<Restaurant>> GetRestaurantsByNameAsync(string name, CancellationToken cancellationToken);

    Task<List<Restaurant>> GetByLocalizationAsync(string country, string region, string city, string? neighborhood, CancellationToken cancellationToken);
}
