namespace AppCadastro.Domain.Entities
{
	public class Escolaridade
	{
		public Escolaridade(int id, string descricao)
		{
			Id = id;
			Descricao = descricao;
		}

		public int Id { get; private set; }
		public string Descricao { get; private set; }
	}
}
