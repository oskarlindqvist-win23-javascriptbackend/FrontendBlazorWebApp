﻿using System.ComponentModel.DataAnnotations;

namespace FrontendBlazorWebApp.Filters;

public class CheckBoxRequired : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        return value is bool b && b;
    }
}
