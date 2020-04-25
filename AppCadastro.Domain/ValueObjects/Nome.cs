using Flunt.Validations;

namespace AppCadastro.Domain.ValueObjects
{
	public class Nome : ValueObject
	{
		public Nome(string primeiroNome, string sobrenome)
		{
			PrimeiroNome = primeiroNome;
			Sobrenome = sobrenome;

			AddNotifications(new Contract()
				.Requires()
				.HasMinLen(PrimeiroNome, 3, "Nome.PrimeiroNome", "Nome deve conter pelo menos 3 caracteres")
				.HasMaxLen(PrimeiroNome, 15, "Nome.PrimeiroNome", "Nome deve conter até 40 caracteres")
				.HasMinLen(Sobrenome, 3, "Nome.Sobrenome", "Sobrenome deve conter pelo menos 3 caracteres")
				.HasMaxLen(Sobrenome, 40, "Nome.Sobrenome", "Sobrenome deve conter até 40 caracteres")
			);
		}
		
		public string PrimeiroNome { get; private set; }
		public string Sobrenome { get; private set; }

		public override string ToString()
		{
			return $"{PrimeiroNome} {Sobrenome}";
		}
	}
}
