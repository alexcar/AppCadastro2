namespace AppCadastro.Domain.Entities
{
	public class NaturezaOcupacao
	{
		public NaturezaOcupacao(int id, string descricao)
		{
			Id = id;
			Descricao = descricao;
		}

		public int Id { get; private set; }
		public string Descricao { get; private set; }
	}
}
