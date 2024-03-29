﻿using Dinners.Application.Common;
using ErrorOr;
using MediatR;

namespace Dinners.Application.Reservations.Finish;

internal sealed record FinishReservationCommand(Guid ReservationId) : ICommand<ErrorOr<Unit>>;
