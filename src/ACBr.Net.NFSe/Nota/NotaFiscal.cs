// ***********************************************************************
// Assembly         : ACBr.Net.NFe
// Author           : RFTD
// Created          : 10-01-2014
//
// Last Modified By : RFTD
// Last Modified On : 10-01-2014
// ***********************************************************************
// <copyright file="NFSe.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ACBr.Net.Core.Generics;
using ACBr.Net.DFe.Core.Document;
using System;

namespace ACBr.Net.NFSe.Nota
{
	/// <summary>
	/// Classe NFSe. Est� classe n�o pode ser herdada.
	/// </summary>
	public sealed class NotaFiscal : GenericClone<NotaFiscal>
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="NotaFiscal"/> class.
		/// </summary>
		internal NotaFiscal()
		{
			Id = 0;
			IdentificacaoRps = new IdentificacaoRps();
			IdentificacaoNFSe = new IdentificacaoNFSe();
			RpsSubstituido = new IdeRpsSubtituida();
			Servico = new DadosServico();
			Prestador = new DadosPrestador();
			Tomador = new DadosTomador();
			IntermediarioServico = new IdeIntermediarioServico();
			ConstrucaoCivil = new DadosConstrucaoCivil();
			CondicaoPagamento = new CondPagamento();
			OrgaoGerador = new IdeOrgaoGerador();
			Signature = new Signature();
			NfseCancelamento = new ConfirmacaoCancelamento();
			Transportadora = new DadosTransportadora();
			Emails = new EmailCollection();
		}

		#endregion Constructor

		#region Propriedades

		public int Id { get; set; }

		public IdentificacaoRps IdentificacaoRps { get; }

		public IdentificacaoNFSe IdentificacaoNFSe { get; }

		public IdeRpsSubtituida RpsSubstituido { get; }

		public ConfirmacaoCancelamento NfseCancelamento { get; }

		public DadosPrestador Prestador { get; internal set; }

		public DadosTomador Tomador { get; set; }

		public DadosServico Servico { get; }

		public LocalPrestacaoServico LogradouLocalPrestacaoServico { get; set; }

		public IdeIntermediarioServico IntermediarioServico { get; }

		public DadosConstrucaoCivil ConstrucaoCivil { get; }

		public NaturezaOperacao NaturezaOperacao { get; set; }

		public RegimeEspecialTributacao RegimeEspecialTributacao { get; set; }

		public DateTime DataOptanteSimplesNacional { get; set; }

		public NFSeSimNao IncentivadorCultural { get; set; }

		public NFSeSimNao Producao { get; set; }

		public SituacaoNFSeRps Situacao { get; set; }

		public NFSeSimNao DeducaoMateriais { get; set; }

		public CondPagamento CondicaoPagamento { get; }

		public string NumeroLote { get; set; }

		public string Protocolo { get; set; }

		public string Competencia { get; set; }

		public string OutrasInformacoes { get; set; }

		public decimal ValorCredito { get; set; }

		public IdeOrgaoGerador OrgaoGerador { get; }

		public string NFSeSubstituidora { get; set; }

		public string MotivoCancelamento { get; set; }

		public TipoEmissao TipoEmissao { get; set; }

		public TipoEmpreitadaGlobal EmpreitadaGlobal { get; set; }

		public DadosTransportadora Transportadora { get; }

		public EmailCollection Emails { get; }

		public TipoTributacao TipoTributacao { get; set; }

		public string Assinatura { get; set; }

		public Signature Signature { get; set; }

		#endregion Propriedades
	}
}