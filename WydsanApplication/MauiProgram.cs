using FluentValidation;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Hosting;

namespace WydsanApplication
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>();

            return builder.Build();
        }

        
    }
}


public class InputValidator : AbstractValidator<string>
{
    public InputValidator()
    {
        RuleFor(x => x).NotEmpty().WithMessage("Поле не должно быть пустым.");
        RuleFor(x => x).Must(BeAValidNumber).WithMessage("Введите корректное число.");
    }

    private bool BeAValidNumber(string arg)
    {
        return double.TryParse(arg, out _);
    }
}