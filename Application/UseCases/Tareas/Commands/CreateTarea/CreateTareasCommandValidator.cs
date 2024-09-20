using FluentValidation;

namespace Application.UseCases.Tareas.Commands.CreateTarea
{
    public class CreateTareasCommandValidator : AbstractValidator<CreateTareasCommand>
    {
        public CreateTareasCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("No tiene ID");

            /*RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Debe tener un mensaje");*/
        }
    }
}
