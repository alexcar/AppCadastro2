using System;
using System.Collections.Generic;
using System.Text;
using AppCadastro.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppCadasatro.Tests.ValueObjects
{
	[TestClass]
	public class DocumentTests
	{
		[TestMethod]
		public void Numero_Eh_Invalido()
		{
			var documento = new Documento(
				"085024214", 
				DateTime.Now, 
				"IFP", 
				"SP");

			Assert.IsTrue(documento.Valid);
		}

		[TestMethod]
		public void Orgao_Expedicao_Eh_Invalido()
		{
			var documento = new Documento(
				"085024214",
				DateTime.Now,
				"IFP",
				"SP");

			Assert.IsTrue(documento.Valid);
		}

		[TestMethod]
		public void Estado_Expedicao_Eh_Invalido()
		{
			var documento = new Documento(
				"085024214",
				DateTime.Now,
				"IFP",
				"SP");

			Assert.IsTrue(documento.Valid);
		}
	}
}
