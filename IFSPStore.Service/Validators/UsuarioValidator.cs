
using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator() {

            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(x => x.Senha)
                .MinimumLength(8).WithMessage("Sua senha precisa ter pelo menos 8 caracteres")
                .MaximumLength(16).WithMessage("Sua senha precisa ter pelo menos 16 caracteres")
                .Matches(@"[A-Z]+").WithMessage("Sua senha precisa pelo menos uma letra maiúscula")
                .Matches(@"[a-z]+").WithMessage("Sua senha precisa ter pelo menos uma letra minúscula")
                .Matches(@"[0-9]+").WithMessage("Sua senha precisa ter pelo menos um número")
                .Matches(@"[\!\?\*\.]+").WithMessage("Sua senha deve conter pelo menos um (!? *.).")
                .NotEmpty().WithMessage("Por favor informe a senha.")
                .NotNull().WithMessage("Por favor informe a senha.");

            RuleFor(x => x.Login)
                .NotEmpty().WithMessage("Por favor informe o login.")
                .NotNull().WithMessage("Por favor informe o login.");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("E-mail inválido")
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email");

            RuleFor(x => x.DataCadastro)
                .Must(BeAValidDate).WithMessage("Start date is required");
           
        }
        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }

    }
}
