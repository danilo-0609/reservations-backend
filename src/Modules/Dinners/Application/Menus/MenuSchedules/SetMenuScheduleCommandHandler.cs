﻿using Dinners.Application.Common;
using Dinners.Domain.Menus;
using Dinners.Domain.Menus.Errors;
using Dinners.Domain.Menus.Schedules;
using ErrorOr;
using MediatR;

namespace Dinners.Application.Menus.MenuSchedules;

internal sealed class SetMenuScheduleCommandHandler : ICommandHandler<SetMenuScheduleCommand, ErrorOr<Unit>>
{
    private readonly IMenuRepository _menuRepository;

    public SetMenuScheduleCommandHandler(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<Unit>> Handle(SetMenuScheduleCommand request, CancellationToken cancellationToken)
    {
        Menu? menu = await _menuRepository.GetByIdAsync(MenuId.Create(request.MenuId), cancellationToken);

        if (menu is null)
        {
            return MenuErrorCodes.NotFound;
        }

        MenuSchedule menuSchedule = menu.SetMenuSchedule(request.DayOfWeeks, request.Open, request.Close);

        var menuUpdate = menu.Update(menu.MenuReviewIds.ToList(),
            menu.MenuDetails,
            menu.DishSpecification,
            menuSchedule,
            menu.MenuConsumers.ToList(),
            DateTime.UtcNow);

        await _menuRepository.UpdateAsync(menuUpdate, cancellationToken);

        return Unit.Value;
    }
}
