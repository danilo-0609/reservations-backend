﻿using Dinners.Application.Common;
using ErrorOr;

namespace Dinners.Application.Reservations.Request;

public sealed record RequestReservationCommand(int ReservedTable,
        DateTime StartReservationDateTime,
        DateTime EndReservationDateTime,
        Guid RestaurantId,
        string Name,
        int NumberOfAttendees,
        List<Guid> MenuIds) : ICommand<ErrorOr<Guid>>;
