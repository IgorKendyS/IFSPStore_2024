

using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator() {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("Por favor informe o nome.")
               .NotNull().WithMessage("Por favor informe o nome.")
               .MaximumLength(50).WithMessage("Nome pode ter no máximo 50 caracteres");

            RuleFor(c => c.Endereco)
                .NotEmpty().WithMessage("Por favor informe o endereço.")
                .NotNull().WithMessage("Por favor informe o endereço.");

            RuleFor(c => c.Documento)
                .NotEmpty().WithMessage("Por favor informe o documento.")
                .NotNull().WithMessage("Por favor informe o documento.");

            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("Por favor informe o bairro.")
                .NotNull().WithMessage("Por favor informe o bairro.");

        }
    }
}
