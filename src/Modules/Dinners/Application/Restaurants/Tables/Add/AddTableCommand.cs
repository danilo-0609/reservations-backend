﻿using Dinners.Application.Common;
using ErrorOr;
using MediatR;

namespace Dinners.Application.Restaurants.Tables.Add;

public sealed record AddTableCommand(Guid RestaurantId,
    int Number,
    int Seats,
    bool IsPremium) : ICommand<ErrorOr<Unit>>;
