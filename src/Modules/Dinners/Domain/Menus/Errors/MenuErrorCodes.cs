﻿using ErrorOr;

namespace Dinners.Domain.Menus.Errors;

public static class MenuErrorCodes
{
    public static Error NotFound =>
        Error.NotFound("Menu.NotFound", "Menu was not found");

    public static Error ImagesNotFound =>
        Error.NotFound("Menu.ImagesNotFound", "Menu images were not found");
}
