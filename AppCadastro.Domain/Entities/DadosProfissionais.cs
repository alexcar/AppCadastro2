using System;
using Flunt.Notifications;

namespace AppCadastro.Domain.Entities
{
	public class DadosProfissionais : Notifiable
	{
		public DadosProfissionais(
			int id,
			string ocupacaoPrincipal, 
			string cargo, 
			DateTime dataAdmissao, 
			int idNaturezaOcupacao, 
			NaturezaOcupacao naturezaOcupacao, 
			int idNivelCargo, 
			NivelCargo nivelCargo)
		{
			Id = id;
			OcupacaoPrincipal = ocupacaoPrincipal;
			Cargo = cargo;
			DataAdmissao = dataAdmissao;
			IdNaturezaOcupacao = idNaturezaOcupacao;
			NaturezaOcupacao = naturezaOcupacao;
			IdNivelCargo = idNivelCargo;
			NivelCargo = nivelCargo;
		}
		
		public int Id { get; private set; }
		public string OcupacaoPrincipal { get; private set; }
		public string Cargo { get; private set; }
		public DateTime DataAdmissao { get; private set; }
		public int IdNaturezaOcupacao { get; private set; }
		public NaturezaOcupacao NaturezaOcupacao { get; private set; }
		public int IdNivelCargo { get; private set; }
		public NivelCargo NivelCargo { get; private set; }
	}
}
