namespace AppCadastro.Domain.Entities
{
	public class Referencia
	{
		public Referencia(int id, string nome, string dddCelular, string celular)
		{
			Id = id;
			Nome = nome;
			DddCelular = dddCelular;
			Celular = celular;
		}

		public int Id { get; private set; }
		public string Nome { get; private set; }
		public string DddCelular { get; private set; }
		public string Celular { get; private set; }
	}
}
