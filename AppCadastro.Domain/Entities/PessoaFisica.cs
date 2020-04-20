using System;
using System.Collections.Generic;

namespace AppCadastro.Domain.Entities
{
	public class PessoaFisica
	{
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public int IdEstadoCivil { get; set; }
		public EstadoCivil EstadoCivil { get; set; }
		public string NomeTratamento { get; set; }
		public string Sexo { get; set; } // enum
		public DateTime DataNascimento { get; set; }
		public string Documento { get; set; }
		public DateTime DataExpedicaoDocumento { get; set; }
		public string OrgaoExpedicaoDocumento { get; set; } 
		public int IdEstadoExpedicaoDocumento { get; set; }
		public int IdEscolaridade { get; set; }
		public Escolaridade Escolaridade { get; set; }
		public int IdFormacaoAcademica { get; set; }
		public FormacaoAcademica FormacaoAcademica { get; set; }
		public string ConclusaoFormacaoAcademica { get; set; } // mês e ano
		public string DddTelefone { get; set; }
		public string Telefone { get; set; }
		public string DddCelular { get; set; }
		public string Celular { get; set; }
		public string Email { get; set; }
		public bool AutorizaContatoEmail { get; set; }
		public string NomeConjuge { get; set; }
		public DateTime DataNascimentoConjuge { get; set; }
		public string CpfConjuge { get; set; }
		public int IdEndereco { get; set; }
		public Endereco Endereco { get; set; }
		public int IdDadosProfissionais { get; set; }
		public DadosProfissionais DadosProfissionais { get; set; }
		public List<Referencia> Referencias { get; set; }
	}
}
