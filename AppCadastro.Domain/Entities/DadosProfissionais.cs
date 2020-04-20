using System;

namespace AppCadastro.Domain.Entities
{
	public class DadosProfissionais
	{
		public string OcupacaoPrincipal { get; set; } 
		public string Cargo { get; set; }
		public DateTime DataAdmissao { get; set; }
		public int IdNaturezaOcupacao { get; set; }
		public NaturezaOcupacao NaturezaOcupacao { get; set; }
		public int IdNivelCargo { get; set; }
		public NivelCargo NivelCargo { get; set; }
	}
}
