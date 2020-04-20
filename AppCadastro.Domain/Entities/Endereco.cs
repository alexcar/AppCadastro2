namespace AppCadastro.Domain.Entities
{
	public class Endereco
	{
		public string Cep { get; set; }
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public int IdTipoImovel { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Municipio { get; set; }
		public int IdEstado { get; set; }
		public string Pais { get; set; }
		public string TempoResidencia { get; set; } // mês e ano
	}
}
