﻿using Dinners.Application.Common;
using ErrorOr;
using MediatR;

namespace Dinners.Application.Menus.MenuImages.Delete;

public sealed record DeleteMenuImageCommand(Guid Id, string MenuImageUrl) : ICommand<ErrorOr<Unit>>;
