using Flunt.Notifications;

namespace AppCadastro.Domain.Entities
{
	public class Endereco : Notifiable
	{
		public Endereco(
			int id,
			string cep, 
			string logradouro, 
			string numero, 
			int idTipoImovel, 
			string complemento, 
			string bairro, 
			string municipio, 
			int idEstado, 
			string pais, 
			string tempoResidencia)
		{
			Id = id;
			Cep = cep;
			Logradouro = logradouro;
			Numero = numero;
			IdTipoImovel = idTipoImovel;
			Complemento = complemento;
			Bairro = bairro;
			Municipio = municipio;
			IdEstado = idEstado;
			Pais = pais;
			TempoResidencia = tempoResidencia;
		}

		public int Id { get; private set; }
		public string Cep { get; private set; }
		public string Logradouro { get; private set; }
		public string Numero { get; private set; }
		public int IdTipoImovel { get; private set; }
		public string Complemento { get; private set; }
		public string Bairro { get; private set; }
		public string Municipio { get; private set; }
		public int IdEstado { get; private set; }
		public string Pais { get; private set; }
		public string TempoResidencia { get; private set; } // mês e ano
	}
}
