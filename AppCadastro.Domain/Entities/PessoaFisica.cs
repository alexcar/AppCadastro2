using System;
using System.Collections.Generic;
using Flunt.Notifications;

namespace AppCadastro.Domain.Entities
{
	public class PessoaFisica : Notifiable
	{
		public PessoaFisica(
			int id,
			string nome, 
			string cpf, 
			int idEstadoCivil, 
			EstadoCivil estadoCivil, 
			string nomeTratamento, 
			string sexo, 
			DateTime dataNascimento, 
			string documento, 
			DateTime dataExpedicaoDocumento, 
			string orgaoExpedicaoDocumento, 
			int idEstadoExpedicaoDocumento, 
			int idEscolaridade, 
			Escolaridade escolaridade, 
			int idFormacaoAcademica, 
			FormacaoAcademica formacaoAcademica, 
			string conclusaoFormacaoAcademica, 
			string dddTelefone, 
			string telefone, 
			string dddCelular, 
			string celular, 
			string email, 
			bool autorizaContatoEmail, 
			string nomeConjuge, 
			DateTime dataNascimentoConjuge, 
			string cpfConjuge, 
			int idEndereco, 
			Endereco endereco, 
			int idDadosProfissionais, 
			DadosProfissionais dadosProfissionais, 
			List<Referencia> referencias)
		{
			Id = id;
			Nome = nome;
			Cpf = cpf;
			IdEstadoCivil = idEstadoCivil;
			EstadoCivil = estadoCivil;
			NomeTratamento = nomeTratamento;
			Sexo = sexo;
			DataNascimento = dataNascimento;
			Documento = documento;
			DataExpedicaoDocumento = dataExpedicaoDocumento;
			OrgaoExpedicaoDocumento = orgaoExpedicaoDocumento;
			IdEstadoExpedicaoDocumento = idEstadoExpedicaoDocumento;
			IdEscolaridade = idEscolaridade;
			Escolaridade = escolaridade;
			IdFormacaoAcademica = idFormacaoAcademica;
			FormacaoAcademica = formacaoAcademica;
			ConclusaoFormacaoAcademica = conclusaoFormacaoAcademica;
			DddTelefone = dddTelefone;
			Telefone = telefone;
			DddCelular = dddCelular;
			Celular = celular;
			Email = email;
			AutorizaContatoEmail = autorizaContatoEmail;
			NomeConjuge = nomeConjuge;
			DataNascimentoConjuge = dataNascimentoConjuge;
			CpfConjuge = cpfConjuge;
			IdEndereco = idEndereco;
			Endereco = endereco;
			IdDadosProfissionais = idDadosProfissionais;
			DadosProfissionais = dadosProfissionais;
			Referencias = referencias;
		}

		public int Id { get; private set; }
		public string Nome { get; private set; }
		public string Cpf { get; private set; }
		public int IdEstadoCivil { get; private set; }
		public EstadoCivil EstadoCivil { get; private set; }
		public string NomeTratamento { get; private set; }
		public string Sexo { get; private set; } // enum
		public DateTime DataNascimento { get; private set; }
		public string Documento { get; private set; }
		public DateTime DataExpedicaoDocumento { get; private set; }
		public string OrgaoExpedicaoDocumento { get; private set; }
		public int IdEstadoExpedicaoDocumento { get; private set; }
		public int IdEscolaridade { get; private set; }
		public Escolaridade Escolaridade { get; private set; }
		public int IdFormacaoAcademica { get; private set; }
		public FormacaoAcademica FormacaoAcademica { get; private set; }
		public string ConclusaoFormacaoAcademica { get; private set; } // mês e ano
		public string DddTelefone { get; private set; }
		public string Telefone { get; private set; }
		public string DddCelular { get; private set; }
		public string Celular { get; private set; }
		public string Email { get; private set; }
		public bool AutorizaContatoEmail { get; private set; }
		public string NomeConjuge { get; private set; }
		public DateTime DataNascimentoConjuge { get; private set; }
		public string CpfConjuge { get; private set; }
		public int IdEndereco { get; private set; }
		public Endereco Endereco { get; private set; }
		public int IdDadosProfissionais { get; private set; }
		public DadosProfissionais DadosProfissionais { get; private set; }
		public List<Referencia> Referencias { get; private set; }
	}
}
