using Bergs.Pxc.Pxcbtoxn;
using Bergs.Pwx.Pwxoiexn;
using Bergs.Pwx.Pwxoiexn.Relatorios;
using Bergs.Pwx.Pwxoiexn.RN;
using Bergs.Pwx.Pwxoiexn.Mensagens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bergs.Pxc.Pxcsidxn
{ 
    /// <summary>Classe que possui as regras de negócio para o acesso da tabela IDIOMA da base de dados PXC.</summary>
    public class Idioma : AplicacaoRegraNegocio
    {
        #region Métodos
        /// <summary>Altera registro da tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Alterar(TOIdioma toIdioma)
        {
            try
            {
                Pxcqidxn.Idioma bdIdioma;
                Retorno<int> alteracaoIdioma;                
                
                #region Validação de campos
                //Valida que os campos que fazem parte da chave primária foram informados
                if (!toIdioma.CodIdioma.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("COD_IDIOMA"));
                }
                #endregion
      
                #region Validação de regras de negócio
                #endregion

                bdIdioma = this.Infra.InstanciarBD<Pxcqidxn.Idioma>();
                
                //Cria escopo transacional para garantir atomicidade
                using (EscopoTransacional escopo = this.Infra.CriarEscopoTransacional())
                {
                    alteracaoIdioma = bdIdioma.Alterar(toIdioma);
                    if (!alteracaoIdioma.OK)
                    {
                        return alteracaoIdioma;
                    }
                    
                    escopo.EfetivarTransacao();
                    return this.Infra.RetornarSucesso(alteracaoIdioma.Dados, new OperacaoRealizadaMensagem("Alteração"));
                }
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
    
        /// <summary>Conta quantidade de registros da tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<long> Contar(TOIdioma toIdioma)
        {
            try
            {
                Pxcqidxn.Idioma bdIdioma;
                Retorno<long> contagemIdioma;
                
                #region Validação de regras de negócio
                #endregion
            
                bdIdioma = this.Infra.InstanciarBD<Pxcqidxn.Idioma>();

                contagemIdioma = bdIdioma.Contar(toIdioma);
                if (!contagemIdioma.OK)
                {
                    return contagemIdioma;
                }
                
                return this.Infra.RetornarSucesso(contagemIdioma.Dados, new OperacaoRealizadaMensagem());
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<long>(ex);
            }
        }
    
        /// <summary>Exclui registro da tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Excluir(TOIdioma toIdioma)
        {
            try
            {
                Pxcqidxn.Idioma bdIdioma;
                Retorno<int> exclusaoIdioma;
                
                #region Validação de campos
                //Valida que os campos que fazem parte da chave primária foram informados
                if (!toIdioma.CodIdioma.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("COD_IDIOMA"));
                }
                #endregion
      
                #region Validação de regras de negócio
                #endregion

                bdIdioma = this.Infra.InstanciarBD<Pxcqidxn.Idioma>();

                //Cria escopo transacional para garantir atomicidade
                using (EscopoTransacional escopo = this.Infra.CriarEscopoTransacional())
                {
                    exclusaoIdioma = bdIdioma.Excluir(toIdioma);
                    if (!exclusaoIdioma.OK)
                    {
                        return exclusaoIdioma;
                    }
                    
                    escopo.EfetivarTransacao();
                    return this.Infra.RetornarSucesso(exclusaoIdioma.Dados, new OperacaoRealizadaMensagem("Exclusão"));
                }
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
    
        /// <summary>Gera relatório da tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta e o nome do relatório gerado, ou as informações de erro.</returns>
        public virtual Retorno<string> Imprimir(TOIdioma toIdioma)
        {
            try
            {
                Retorno<List<TOIdioma>> listagemIdioma;
                StringBuilder linha;
                
                //Lista registros da tabela
                listagemIdioma = this.Listar(toIdioma, null);
                if (!listagemIdioma.OK)
                {
                    return this.Infra.RetornarFalha<List<TOIdioma>, String>(listagemIdioma);
                }
                
                //Monta relatório com os dados da listagem
                using (RelatorioPadrao relatorio = new RelatorioPadrao(this.Infra))
                {   
                    //Define colunas do relatório
                    relatorio.Colunas.Add(new Coluna("COD_IDIOMA", 4));
                    relatorio.Colunas.Add(new Coluna("COD_USUARIO", 6));
                    relatorio.Colunas.Add(new Coluna("DESC_IDIOMA", 50));
                    relatorio.Colunas.Add(new Coluna("DTHR_ULT_ATU", 26));

                    linha = new StringBuilder();
                    //Monta linhas do relatório
                    foreach(TOIdioma toSaida in listagemIdioma.Dados)
                    {
                        linha.Append(toSaida.CodIdioma.ToString().PadRight(relatorio.Colunas["COD_IDIOMA"].Tamanho));
                        linha.Append(toSaida.CodUsuario.ToString().PadRight(relatorio.Colunas["COD_USUARIO"].Tamanho));
                        linha.Append(toSaida.DescIdioma.ToString().PadRight(relatorio.Colunas["DESC_IDIOMA"].Tamanho));
                        linha.Append(toSaida.DthrUltAtu.ToString().PadRight(relatorio.Colunas["DTHR_ULT_ATU"].Tamanho));

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
    
        /// <summary>Inclui registro na tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Incluir(TOIdioma toIdioma)
        {
            try
            {
                //valida se o campo DescIdioma foi informado no TO
                if (!toIdioma.DescIdioma.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("DESC_IDIOMA"));
                }
                //valida se o campo CodigoIsoCombinado foi informado no TO
                if (!toIdioma.CodigoIsoCombinado.FoiSetado)
                {
                    return this.Infra.RetornarFalha<int>(new CampoObrigatorioMensagem("cod_iso_idioma"));
                }

                //executa a validação de acordo com as annotations
                if (!ValidarTO(toIdioma, out var listaRetornoValidacao))
                    return Infra.RetornarFalha<int>(new ObjetoInvalidoMensagem(listaRetornoValidacao));

                //regra de validação da formatação do iso
                string iso = toIdioma.CodigoIsoCombinado.Conteudo.ToString();
                if (string.IsNullOrEmpty(iso))
                    return this.Infra.RetornarFalha<int>(new Mensagem(TipoMensagem.IsoNuloOuVazio));

                var parts = iso.Split('-');
                if (parts.Length != 2)
                    return this.Infra.RetornarFalha<int>(new Mensagem(TipoMensagem.FormatoInvalido));


                string idioma = parts[0].ToLower();
                string pais = parts[1].ToUpper();

                if (idioma.Length < 2 || idioma.Length > 3)
                    return this.Infra.RetornarFalha<int>(new Mensagem(TipoMensagem.TamanhoIdiomaInvalido));

                //cria o código numérico a partir do código textual ISO
                toIdioma.CodIdioma = Feconid.IsoToCodigo(iso);

                //tenta buscar no banco algum idioma com as mesmas informações
                Retorno<TOIdioma> toIdiomaConsultado = Obter(toIdioma);
                //valida se a busca não deu certo e se o erro foi algo diferente de "registro inexistente". Se for erro de "registro inexistente" então não existe esse idioma no banco ainda.
                if (!toIdiomaConsultado.OK && !(toIdiomaConsultado.Mensagem is RegistroInexistenteMensagem))
                    return Infra.RetornarFalha<int>(toIdiomaConsultado.Mensagem);
                //valida se achou algum idioma no banco com o mesmo código numérico (id)
                if (toIdiomaConsultado.OK)
                    return Infra.RetornarFalha<int>(new Mensagem (TipoMensagem.FalhaRnIncluirIdiomaJaExistente));

                Pxcqidxn.Idioma bdIdioma = this.Infra.InstanciarBD<Pxcqidxn.Idioma>();

                //Cria escopo transacional para garantir atomicidade
                using (EscopoTransacional escopo = this.Infra.CriarEscopoTransacional())
                {
                    Retorno<int> inclusaoIdioma = bdIdioma.Incluir(toIdioma);
                    if (!inclusaoIdioma.OK)
                    {
                        return inclusaoIdioma;
                    }
                    
                    escopo.EfetivarTransacao();
                    return this.Infra.RetornarSucesso(inclusaoIdioma.Dados, new OperacaoRealizadaMensagem("Inclusão"));
                }
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
    
        /// <summary>Lista registros da tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <param name="toPaginacao">Classe da infra-estrutura contendo as informações de paginação.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<List<TOIdioma>> Listar(TOIdioma toIdioma, TOPaginacao toPaginacao)
        {
            try
            {
                Pxcqidxn.Idioma bdIdioma;
                Retorno<List<TOIdioma>> listagemIdioma;
                
                bdIdioma = this.Infra.InstanciarBD<Pxcqidxn.Idioma>();

                listagemIdioma = bdIdioma.Listar(toIdioma, toPaginacao);
                if (!listagemIdioma.OK)
                {
                    return listagemIdioma;
                }
                
                return this.Infra.RetornarSucesso(listagemIdioma.Dados, new OperacaoRealizadaMensagem());
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<List<TOIdioma>>(ex);
            }
        }
    
        /// <summary>Obtém registro da tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<TOIdioma> Obter(TOIdioma toIdioma)
        {
            try
            {
                Pxcqidxn.Idioma bdIdioma;
                Retorno<TOIdioma> obtencaoIdioma;
                
                #region Validação de campos
                //Valida que os campos que fazem parte da chave primária foram informados
                if (!toIdioma.CodIdioma.FoiSetado)
                {
                    return this.Infra.RetornarFalha<TOIdioma>(new CampoObrigatorioMensagem("COD_IDIOMA"));
                }
                #endregion

                #region Validação de regras de negócio
                #endregion

                bdIdioma = this.Infra.InstanciarBD<Pxcqidxn.Idioma>();

                obtencaoIdioma = bdIdioma.Obter(toIdioma);
                if (!obtencaoIdioma.OK)
                {
                    return obtencaoIdioma;
                }
                
                return this.Infra.RetornarSucesso(obtencaoIdioma.Dados, new OperacaoRealizadaMensagem());
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<TOIdioma>(ex);
            }
        }
        #endregion
	} 
}