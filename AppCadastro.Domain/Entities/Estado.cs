namespace AppCadastro.Domain.Entities
{
	public class Estado
	{
		public Estado(int id, string sigla, string descricao)
		{
			Id = id;
			Sigla = sigla;
			Descricao = descricao;
		}

		public int Id { get; private set; }
		public string Sigla { get; private set; }
		public string Descricao { get; private set; }
	}
}
