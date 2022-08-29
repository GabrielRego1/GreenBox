using FluentValidation;
using GreenBox.Business.Models;

namespace GreenBox.Business.Validations
{
    public class ColaboradorValidation : AbstractValidator<Colaborador>
    {
        public ColaboradorValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Pontuacao)
                .GreaterThanOrEqualTo(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
