﻿using ACBr.Net.Core.Extensions;
using System.IO;
using System.Xml.Linq;
using Xunit;

namespace ACBr.Net.NFSe.Test
{
	public class TestProviderGinfes
	{
		[Fact]
		public void TestarGeracaoLeituraRps()
		{
			var acbrNFSe = SetupACBrNFSe.Instance;

			acbrNFSe.NotasServico.Clear();

			var dados = new MemoryStream(Properties.Resources.Exemplo_Rps_Ginfes);
			acbrNFSe.NotasServico.Load(dados);

			Assert.True(acbrNFSe.NotasServico.Count == 1, "Erro ao carregar a Rps");

			var rpsGerada = acbrNFSe.NotasServico.GetXml(acbrNFSe.NotasServico[0]);

			dados.Position = 0;
			var xml = XDocument.Load(dados);
			var rpsOriginal = xml.AsString(true);

			Assert.True(rpsGerada == rpsOriginal, "Erro na Geração do Xml da Rps");
		}

		[Fact]
		public void TestarGeracaoLeituraNFSe()
		{
			var acbrNFSe = SetupACBrNFSe.Instance;

			acbrNFSe.NotasServico.Clear();

			var dados = new MemoryStream(Properties.Resources.Exemplo_Rps_Ginfes);
			acbrNFSe.NotasServico.Load(dados);

			Assert.True(acbrNFSe.NotasServico.Count == 1, "Erro ao carregar a NFSe");

			var nfseGerada = acbrNFSe.NotasServico.GetXml(acbrNFSe.NotasServico[0]);

			dados.Position = 0;
			var xml = XDocument.Load(dados);
			var nfseOriginal = xml.AsString(true);

			Assert.True(nfseGerada == nfseOriginal, "Erro na Geração do Xml da NFSe");
		}
	}
}