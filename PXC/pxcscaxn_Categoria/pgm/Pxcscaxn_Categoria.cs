using Bergs.Pxc.Pxcbtoxn;
using Bergs.Pxc.Pxcqcaxn;
using Bergs.Pwx.Pwxoiexn;
using Bergs.Pwx.Pwxoiexn.Relatorios;
using Bergs.Pwx.Pwxoiexn.RN;
using Bergs.Pwx.Pwxoiexn.Mensagens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bergs.Pxc.Pxcscaxn
{ 
    /// <summary>Classe que possui as regras de negócio para o acesso da tabela CATEGORIA da base de dados PXC.</summary>
    public class Categoria : AplicacaoRegraNegocio
    {
        #region Métodos
        /// <summary>Altera registro da tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Alterar(TOCategoria toCategoria)
        {
            try
            {
                Pxcqcaxn.Categoria bdCategoria;
                Retorno<int> alteracaoCategoria;                
                
                //Valida que os campos que fazem parte da chave primária foram informados
                if (!toCategoria.CodCategoria.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("COD_CATEGORIA"));
                }
                if (!toCategoria.Descricao.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("DESCRICAO"));
                }
                
                if (!ValidarTO(toCategoria, out var listaRetornoValidacao))
                  return Infra.RetornarFalha<int>(new ObjetoInvalidoMensagem(listaRetornoValidacao));

                toCategoria.CodOperador = this.Infra.Usuario.Matricula;

                bdCategoria = this.Infra.InstanciarBD<Pxcqcaxn.Categoria>();
                
                var categoriaObtida = bdCategoria.ObterPorID(toCategoria);
                if (!categoriaObtida.OK && !(categoriaObtida.Mensagem is RegistroInexistenteMensagem))
                {
                    return Infra.RetornarFalha<int>(categoriaObtida.Mensagem);
                }
                    
                if(!categoriaObtida.OK)
                { 
                    return this.Infra.RetornarFalha<int>(new Mensagem(TipoMensagem.CodigoNaoEncontrado));
                }

                categoriaObtida.Dados.Descricao = toCategoria.Descricao;
                
                //Cria escopo transacional para garantir atomicidade
                using (EscopoTransacional escopo = this.Infra.CriarEscopoTransacional())
                {
                    
                    alteracaoCategoria = bdCategoria.Alterar(categoriaObtida.Dados);
                    if (!alteracaoCategoria.OK)
                    {
                        return alteracaoCategoria;
                    }
                    
                    escopo.EfetivarTransacao();
                    return this.Infra.RetornarSucesso(alteracaoCategoria.Dados, new OperacaoRealizadaMensagem("Alteração"));
                }
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
    
        /// <summary>Conta quantidade de registros da tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<long> Contar(TOCategoria toCategoria)
        {
            try
            {
                Pxcqcaxn.Categoria bdCategoria;
                Retorno<long> contagemCategoria;
                
                #region Validação de regras de negócio
                #endregion
            
                bdCategoria = this.Infra.InstanciarBD<Pxcqcaxn.Categoria>();

                contagemCategoria = bdCategoria.Contar(toCategoria);
                if (!contagemCategoria.OK)
                {
                    return contagemCategoria;
                }
                
                return this.Infra.RetornarSucesso(contagemCategoria.Dados, new OperacaoRealizadaMensagem());
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<long>(ex);
            }
        }
    
        /// <summary>Exclui registro da tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Excluir(TOCategoria toCategoria)
        {
            try
            {
                Pxcqcaxn.Categoria bdCategoria;
                Retorno<int> exclusaoCategoria;
                
                #region Validação de campos
                //Valida que os campos que fazem parte da chave primária foram informados
                if (!toCategoria.CodCategoria.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("COD_CATEGORIA"));
                }
                #endregion
      
                #region Validação de regras de negócio
                #endregion

                bdCategoria = this.Infra.InstanciarBD<Pxcqcaxn.Categoria>();

                //Cria escopo transacional para garantir atomicidade
                using (EscopoTransacional escopo = this.Infra.CriarEscopoTransacional())
                {
                    exclusaoCategoria = bdCategoria.Excluir(toCategoria);
                    if (!exclusaoCategoria.OK)
                    {
                        return exclusaoCategoria;
                    }
                    
                    escopo.EfetivarTransacao();
                    return this.Infra.RetornarSucesso(exclusaoCategoria.Dados, new OperacaoRealizadaMensagem("Exclusão"));
                }
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
    
        /// <summary>Gera relatório da tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta e o nome do relatório gerado, ou as informações de erro.</returns>
        public virtual Retorno<string> Imprimir(TOCategoria toCategoria)
        {
            try
            {
                Retorno<List<TOCategoria>> listagemCategoria;
                StringBuilder linha;
                
                //Lista registros da tabela
                listagemCategoria = this.Listar(toCategoria, null);
                if (!listagemCategoria.OK)
                {
                    return this.Infra.RetornarFalha<List<TOCategoria>, String>(listagemCategoria);
                }
                
                //Monta relatório com os dados da listagem
                using (RelatorioPadrao relatorio = new RelatorioPadrao(this.Infra))
                {   
                    //Define colunas do relatório
                    relatorio.Colunas.Add(new Coluna("COD_CATEGORIA", 4));
                    relatorio.Colunas.Add(new Coluna("COD_OPERADOR", 6));
                    relatorio.Colunas.Add(new Coluna("DESCRICAO", 35));
                    relatorio.Colunas.Add(new Coluna("ULT_ATUALIZACAO", 26));

                    linha = new StringBuilder();
                    //Monta linhas do relatório
                    foreach(TOCategoria toSaida in listagemCategoria.Dados)
                    {
                        linha.Append(toSaida.CodCategoria.ToString().PadRight(relatorio.Colunas["COD_CATEGORIA"].Tamanho));
                        linha.Append(toSaida.CodOperador.ToString().PadRight(relatorio.Colunas["COD_OPERADOR"].Tamanho));
                        linha.Append(toSaida.Descricao.ToString().PadRight(relatorio.Colunas["DESCRICAO"].Tamanho));
                        linha.Append(toSaida.UltAtualizacao.ToString().PadRight(relatorio.Colunas["ULT_ATUALIZACAO"].Tamanho));

                        relatorio.AdicionarLinha(linha.ToString());
                        linha.Length = 0;
                    }
                    
                    return this.Infra.RetornarSucesso(relatorio.NomeArquivoVirtual, new OperacaoRealizadaMensagem());
                }                
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<String>(ex);
            }
        }
    
        /// <summary>Inclui registro na tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Incluir(TOCategoria toCategoria)
        {
            try
            {
                Pxcqcaxn.Categoria bdCategoria;
                Retorno<int> inclusaoCategoria;
                
                //Valida que os campos obrigatórios foram informados
                if (!toCategoria.CodCategoria.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("COD_CATEGORIA"));
                }
                if (!toCategoria.Descricao.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("DESCRICAO"));
                }
                
                if (!ValidarTO(toCategoria, out var listaRetornoValidacao))
                  return Infra.RetornarFalha<int>(new ObjetoInvalidoMensagem(listaRetornoValidacao));
                
                toCategoria.CodOperador = this.Infra.Usuario.Matricula;

                bdCategoria = this.Infra.InstanciarBD<Pxcqcaxn.Categoria>();

                //Cria escopo transacional para garantir atomicidade
                using (EscopoTransacional escopo = this.Infra.CriarEscopoTransacional())
                {
                    inclusaoCategoria = bdCategoria.Incluir(toCategoria);
                    if (!inclusaoCategoria.OK)
                    {
                        return inclusaoCategoria;
                    }
                    
                    escopo.EfetivarTransacao();
                    return this.Infra.RetornarSucesso(inclusaoCategoria.Dados, new OperacaoRealizadaMensagem("Inclusão"));
                }
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
    
        /// <summary>Lista registros da tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <param name="toPaginacao">Classe da infra-estrutura contendo as informações de paginação.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<List<TOCategoria>> Listar(TOCategoria toCategoria, TOPaginacao toPaginacao)
        {
            try
            {
                Pxcqcaxn.Categoria bdCategoria;
                Retorno<List<TOCategoria>> listagemCategoria;
                
                bdCategoria = this.Infra.InstanciarBD<Pxcqcaxn.Categoria>();

                listagemCategoria = bdCategoria.Listar(toCategoria, toPaginacao);
                if (!listagemCategoria.OK)
                {
                    return listagemCategoria;
                }
                if(listagemCategoria.Dados.Count == 0)
                {
                    this.Infra.RetornarFalha<List<TOCategoria>>(new Mensagem(TipoMensagem.ListaVazia));
                }
                
                return this.Infra.RetornarSucesso(listagemCategoria.Dados, new OperacaoRealizadaMensagem());
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<List<TOCategoria>>(ex);
            }
        }
    
        /// <summary>Obtém registro da tabela CATEGORIA a partir do ID.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<TOCategoria> ObterPorID(TOCategoria toCategoria)
        {
            try
            {
                Pxcqcaxn.Categoria bdCategoria;
                Retorno<TOCategoria> obtencaoCategoria;
                
                //Valida que os campos que fazem parte da chave primária foram informados
                if (!toCategoria.CodCategoria.FoiSetado)
                {
                    return this.Infra.RetornarFalha<TOCategoria>(new CampoObrigatorioMensagem("COD_CATEGORIA"));
                }

                bdCategoria = this.Infra.InstanciarBD<Pxcqcaxn.Categoria>();

                obtencaoCategoria = bdCategoria.ObterPorID(toCategoria);

                if(!obtencaoCategoria.OK && (obtencaoCategoria.Mensagem is RegistroInexistenteMensagem))
                {
                    return this.Infra.RetornarFalha<TOCategoria>(new Mensagem(TipoMensagem.CodigoNaoEncontrado));
                }

                if (!obtencaoCategoria.OK)
                {
                    return obtencaoCategoria;
                }
                
                return this.Infra.RetornarSucesso(obtencaoCategoria.Dados, new OperacaoRealizadaMensagem());
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<TOCategoria>(ex);
            }
        }

        /// <summary>Obtém registro da tabela CATEGORIA a partir da Descricao.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<TOCategoria> ObterPorDescricao(TOCategoria toCategoria)
        {
            try
            {
                Pxcqcaxn.Categoria bdCategoria;
                Retorno<TOCategoria> obtencaoCategoria;

                //Valida que os campos que fazem parte da chave primária foram informados
                if (!toCategoria.Descricao.FoiSetado)
                {
                    return this.Infra.RetornarFalha<TOCategoria>(new CampoObrigatorioMensagem("DESCRICAO"));
                }

                bdCategoria = this.Infra.InstanciarBD<Pxcqcaxn.Categoria>();

                obtencaoCategoria = bdCategoria.ObterPorDescricao(toCategoria);

                if (!obtencaoCategoria.OK && (obtencaoCategoria.Mensagem is RegistroInexistenteMensagem))
                {
                    return this.Infra.RetornarFalha<TOCategoria>(new Mensagem(TipoMensagem.DescricaoNaoEncontrada));
                }

                if (!obtencaoCategoria.OK)
                {
                    return obtencaoCategoria;
                }

                return this.Infra.RetornarSucesso(obtencaoCategoria.Dados, new OperacaoRealizadaMensagem());
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<TOCategoria>(ex);
            }
        }
        #endregion
    } 
}