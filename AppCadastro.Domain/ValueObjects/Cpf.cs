using Flunt.Validations;

namespace AppCadastro.Domain.ValueObjects
{
	public class Cpf : ValueObject
	{
		public Cpf(string numero)
		{
			Numero = numero;

			AddNotifications(new Contract()
				.Requires()
				.HasMaxLen(Numero, 11, "Numero", "Número do CPF Inválido")
				.IsTrue(Validate(), "Numero", "Número do CPF Inválido")
			);
		}

		public string Numero { get; private set; }

		private bool Validate()
		{
			var validacao = true;

			// TODO: Implementar a validação do cpf.

			return validacao;
		}

		
	}
}
