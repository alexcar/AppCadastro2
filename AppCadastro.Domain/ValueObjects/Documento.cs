using System;
using System.Collections.Generic;
using System.Text;
using Flunt.Validations;

namespace AppCadastro.Domain.ValueObjects
{
	public class Documento : ValueObject
	{
		// TODO: Validar se o estado de expedição é uma sigla válida de estado.
		
		public Documento(string numero, DateTime dataExpedicao, string orgaoExpedicao, string estadoExpedicao)
		{
			Numero = numero;
			DataExpedicao = dataExpedicao;
			OrgaoExpedicao = orgaoExpedicao;
			EstadoExpedicao = estadoExpedicao;

			AddNotifications(new Contract()
				.Requires()
				.HasMaxLen(Numero, 15, "Documento.Numero", "O número deve conter até 15 caracteres")
				.HasMinLen(OrgaoExpedicao, 3, "Documento.OrgaoExpedicao", "O Orgão de Expedição deve conter pelo menos 3 caracteres")
				.HasMaxLen(OrgaoExpedicao, 15, "Documento.OrgaoExpedicao", "O Orgão de Expedição deve conter até 15 caracteres")
				.HasLen(EstadoExpedicao, 2, "Documento.EstadoExpedicao", "O estado de Expedição não é válido")
			);
		}
		
		public string Numero { get; private set; }
		public DateTime DataExpedicao { get; private set; }
		public string OrgaoExpedicao { get; private set; }
		public string EstadoExpedicao { get; private set; }
		
	}
}
