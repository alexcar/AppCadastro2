namespace AppCadastro.Domain.Entities
{
	public class TipoImovel
	{
		public TipoImovel(string descricao, int id)
		{
			Id = id;
			Descricao = descricao;
		}

		public int Id { get; private set; }
		public string Descricao { get; private set; }

	}
}
