namespace AppCadastro.Domain.Entities
{
	public class FormacaoAcademica
	{
		public FormacaoAcademica(int id, string descricao)
		{
			Id = id;
			Descricao = descricao;
		}

		public int Id { get; private set; }
		public string Descricao { get; private set; }
	}
}
