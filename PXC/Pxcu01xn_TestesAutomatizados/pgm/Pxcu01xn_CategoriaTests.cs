using Bergs.Bth.Bthsmoxn;
using Bergs.Bth.Bthstixn;
using Bergs.Bth.Bthstixn.MM4;
using Bergs.Pwx.Pwxoiexn;
using Bergs.Pxc.Pxcbtoxn;
using Bergs.Pxc.Pxcscaxn;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Bergs.Pxc.Pxcu01xn.Tests
{
	
	///  <summary>
	/// Contém os métodos de teste da classe Categoria.
	/// </summary>
	[TestFixture(Description="Classe de testes para a classe RN Categoria.", Author="E38360")]
	public class CategoriaTests : AbstractTesteRegraNegocio<Categoria>
	{
		#region Métodos de preparação dos testes
		///  <summary>
		/// Executa uma ação UMA vez por classe, ANTES do início da execução dos métodos de teste.
		/// </summary>
		protected override void BeforeAll()
		{
		}
		///  <summary>
		/// Executa uma ação ANTES de cada método de teste da classe.
		/// </summary>
		protected override void BeforeEach()
		{
		}
		///  <summary>
		/// Executa uma ação UMA vez por classe, DEPOIS do término da execução dos métodos de teste.
		/// </summary>
		protected override void AfterAll()
		{
		}
		///  <summary>
		/// Executa uma ação DEPOIS de cada método de teste da classe.
		/// </summary>
		protected override void AfterEach()
		{
		}
		///  <summary>
		/// Método para setar os dados necessários para conexão com o PHA no servidor de build.
		/// </summary>
		/// <returns>TO com dados necessários para conexão no servidor de build.</returns>
		protected override TOPhaServidorBuild SetarDadosServidorBuild()
		{
			return new TOPhaServidorBuild("GESTAG", "TREINAMENTO MM5");
		}
		#endregion
		#region Métodos de teste de sucesso.
		///  <summary>
		/// Realiza o teste padrão para o método Alterar(TOCategoria).
		/// Validações realizadas: 
		/// - Altera o registro na base, conforme os dados informados.
		/// - Verifica se o retorno do método Alterar foi de sucesso.
		/// - Realiza as seguintes Assertivas:
		/// 1 - Retorno não está nulo.
		/// 2 - Retorno.OK é sucesso (== true).
		/// 3 - Retorno.Dados não está nulo.
		/// - Obtém o TO novamente da base, utilizando o método Obter.
		/// - Compara o retorno do Obter com os dados do TO preenchido.
		/// </summary>
		[Test(Description="Testa o método Alterar(TOCategoria).", Author="E38360")]
		public void AlterarComSucessoTest()
		{
			TOCategoria toCategoria = new TOCategoria();
			// TODO: Setar valores necessários para o toCategoria
			// toCategoria.CodCategoria = ;
			// toCategoria.Descricao = ;
			// toCategoria.CodOperador = ;
			// toCategoria.UltAtualizacao = ;
			base.TestarAlterar(toCategoria);
		}
		///  <summary>
		/// Realiza o teste padrão para o método Contar(TOCategoria).
		/// Validações realizadas: 
		/// - Chama o Contar usando os filtros informados.
		/// - Verifica se o retorno do método Contar foi de sucesso.
		/// - Realiza as seguintes Assertivas:
		/// 1 - Retorno não está nulo.
		/// 2 - Retorno.OK é sucesso (== true).
		/// 3 - Retorno.Dados não está nulo.
		/// 4 - Retorno.Dados não é zero.
		/// 
		/// </summary>
		[Test(Description="Testa o método Contar(TOCategoria).", Author="E38360")]
		public void ContarComSucessoTest()
		{
			TOCategoria toCategoria = new TOCategoria();
			// TODO: Setar valores necessários para o toCategoria
			// toCategoria.CodCategoria = ;
			// toCategoria.Descricao = ;
			// toCategoria.CodOperador = ;
			// toCategoria.UltAtualizacao = ;
			base.TestarContar(toCategoria);
		}
		///  <summary>
		/// Realiza o teste padrão para o método Excluir(TOCategoria).
		/// Validações realizadas: 
		/// - Exclui o registro na base, conforme a chave informada.
		/// - Verifica se o retorno do método Excluir foi de sucesso.
		/// - Realiza as seguintes Assertivas:
		/// 1 - Retorno não está nulo.
		/// 2 - Retorno.OK é sucesso (== true).
		/// 3 - Retorno.Dados não está nulo.
		/// - Tenta obter o registro novamente da base, através do método Obter.
		/// - Verifica se o registro não existe mais.
		/// </summary>
		[Test(Description="Testa o método Excluir(TOCategoria).", Author="E38360")]
		public void ExcluirComSucessoTest()
		{
			TOCategoria toCategoria = new TOCategoria();
			// TODO: Setar valores necessários para o toCategoria
			// toCategoria.CodCategoria = ;
			// toCategoria.Descricao = ;
			// toCategoria.CodOperador = ;
			// toCategoria.UltAtualizacao = ;
			base.TestarExcluir(toCategoria);
		}
		///  <summary>
		/// Realiza o teste padrão para o método Imprimir(TOCategoria).
		/// Validações realizadas: 
		/// - Chama o método Imprimir usando os filtros informados.
		/// - Verifica se o retorno do método Imprimir foi de sucesso.
		/// - Realiza as seguintes Assertivas:
		/// 1 - Retorno não está nulo.
		/// 2 - Retorno.OK é sucesso (== true).
		/// 3 - Retorno.Dados não está nulo.
		/// - Verifica se o caminho em Retorno.Dados é existente, ou seja, se o relatório foi gerado.
		/// </summary>
		[Test(Description="Testa o método Imprimir(TOCategoria).", Author="E38360")]
		public void ImprimirComSucessoTest()
		{
			TOCategoria toCategoria = new TOCategoria();
			// TODO: Setar valores necessários para o toCategoria
			// toCategoria.CodCategoria = ;
			// toCategoria.Descricao = ;
			// toCategoria.CodOperador = ;
			// toCategoria.UltAtualizacao = ;
			base.TestarImprimir(toCategoria);
		}
		///  <summary>
		/// Realiza o teste padrão para o método Incluir(TOCategoria).
		/// Validações realizadas: 
		/// - Chama o método Incluir usando os filtros informados.
		/// - Verifica se o retorno do método Incluir foi de sucesso.
		/// - Realiza as seguintes Assertivas:
		/// 1 - Retorno não está nulo.
		/// 2 - Retorno.OK é sucesso (== true).
		/// 3 - Retorno.Dados não está nulo.
		/// - Obtém o TO novamente da base, utilizando o método Obter.
		/// - Compara o retorno do Obter com os dados do TO preenchido.
		/// </summary>
		[Test(Description="Testa o método Incluir(TOCategoria).", Author="E38360")]
		public void IncluirComSucessoTest()
		{
			TOCategoria toCategoria = new TOCategoria();
			// TODO: Setar valores necessários para o toCategoria
			// toCategoria.CodCategoria = ;
			// toCategoria.Descricao = ;
			// toCategoria.CodOperador = ;
			// toCategoria.UltAtualizacao = ;
			base.TestarIncluir(toCategoria);
		}
		///  <summary>
		/// Realiza o teste padrão para o método Listar(TOCategoria, TOPaginacao).
		/// Validações realizadas: 
		/// - Chama o Listar usando os filtros informados.
		/// - Verifica se o retorno do método Listar foi de sucesso
		/// - Realiza as seguintes Assertivas:
		/// 1 - Retorno não está nulo.
		/// 2 - Retorno.OK é sucesso (== true).
		/// 3 - Retorno.Dados não está nulo.
		/// 4 - Retorno.Dados possui elementos.
		/// - Compara o retorno com os dados da lista de TO preenchida antes do teste.
		/// </summary>
		[Test(Description="Testa o método Listar(TOCategoria, TOPaginacao).", Author="E38360")]
		public void ListarComSucessoTest()
		{
			TOCategoria toCategoria = new TOCategoria();
			TOPaginacao toPaginacao = new TOPaginacao(1, 10);
			// TODO: Setar os valores necessários para o toCategoria
			// TODO: Setar os valores necessários para o toPaginacao
			// toCategoria.CodCategoria = ;
			// toCategoria.Descricao = ;
			// toCategoria.CodOperador = ;
			// toCategoria.UltAtualizacao = ;

			base.TestarListar(toCategoria, toPaginacao);
		}
		///  <summary>
		/// Realiza um teste para o método ObterPorID.
		/// </summary>
		[Test(Description="Testa o método ObterPorID(TOCategoria).", Author="E38360")]
		public void ObterPorIDComSucessoTest()
		{
			TOCategoria toCategoria = new TOCategoria();
			// TODO: Setar os valores necessários para o toCategoria
			toCategoria.CodCategoria = 1;
			// toCategoria.Descricao = ;
			// toCategoria.CodOperador = ;
			// toCategoria.UltAtualizacao = ;
			Retorno<TOCategoria> retorno = this.RN.ObterPorID(toCategoria);
			MMAssert.Sucesso(retorno);
			// TODO: Incluir as Assertivas necessárias para o ObterPorID
		}
		///  <summary>
		/// Realiza um teste para o método ObterPorDescricao.
		/// </summary>
		[Test(Description="Testa o método ObterPorDescricao(TOCategoria).", Author="E38360")]
		public void ObterPorDescricaoComSucessoTest()
		{
			TOCategoria toCategoria = new TOCategoria();
			// TODO: Setar os valores necessários para o toCategoria
			// toCategoria.CodCategoria = ;
			// toCategoria.Descricao = ;
			// toCategoria.CodOperador = ;
			// toCategoria.UltAtualizacao = ;
			Retorno<TOCategoria> retorno = this.RN.ObterPorDescricao(toCategoria);
			MMAssert.Sucesso(retorno);
			// TODO: Incluir as Assertivas necessárias para o ObterPorDescricao
		}
		#endregion
	}
}

