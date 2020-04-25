using System;
using System.Collections.Generic;
using System.Text;
using Flunt.Validations;

namespace AppCadastro.Domain.ValueObjects
{
	public class Email : ValueObject
	{
		public Email(string endereco)
		{
			Endereco = endereco;

			AddNotifications(new Contract()
				.Requires()
				.IsEmail(Endereco, "Email.Endereco", "E-mail inválido")
			);
		}
		
		public string Endereco { get; private set; }
	}
}
