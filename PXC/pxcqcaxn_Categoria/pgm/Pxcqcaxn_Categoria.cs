using Bergs.Pxc.Pxcbtoxn;
using Bergs.Pwx.Pwxodaxn;
using Bergs.Pwx.Pwxodaxn.Excecoes;
using Bergs.Pwx.Pwxoiexn;
using Bergs.Pwx.Pwxoiexn.BD;
using Bergs.Pwx.Pwxoiexn.Mensagens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Bergs.Pxc.Pxcqcaxn
{
    /// <summary>Classe que possui os métodos de manipulação de dados da tabela CATEGORIA da base de dados PXC.</summary>
    public class Categoria : AplicacaoDados
    {
        private const string NOME_TABELA = "PXC_CATEGORIA";

        #region Métodos
        /// <summary>Método alterar referente à tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Alterar(TOCategoria toCategoria)
        {
            try
            {
                int registrosAfetados;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.Sql.Comando.Length = 0;
                this.Parametros.Clear();
                toCategoria.CodOperador = Infra.Usuario.Matricula;
                    
                //Inicia montagem do comando
                this.Sql.Comando.Append($"UPDATE {NOME_TABELA}");
                //Monta campos que serão modificados
                this.MontarSet(toCategoria);
                //Filtra a alteração pelas chaves da tabela
                this.MontarWhereChaves(toCategoria, String.Empty);
                //Filtra a alteração pelo campo de controle de acessos concorrentes
                this.Sql.MontarCampoWhere("ULT_ATUALIZACAO", toCategoria.UltAtualizacao);

                //Executa o comando
                registrosAfetados = this.AlterarDados();
                if (registrosAfetados == 0)
                {
                    return this.Infra.RetornarFalha<int>(new ConcorrenciaMensagem());
                }

                return this.Infra.RetornarSucesso(registrosAfetados);
            }
			catch (ChaveEstrangeiraInexistenteException ex)
            {
                return this.Infra.RetornarFalha<int>(new ChaveEstrangeiraInexistenteMensagem(ex));
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
     
        /// <summary>Método contar referente à tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<long> Contar(TOCategoria toCategoria)
        {
            try
            {
                long quantidadeRegistros;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.Sql.Comando.Length = 0;
                this.Parametros.Clear();

                //Inicia montagem do comando
                this.Sql.Comando.Append($"SELECT COUNT(*) FROM {NOME_TABELA}");
                //Filtra consulta pelos dados informados no TO
                this.MontarWhere(toCategoria, String.Empty);

                //Executa o comando
                quantidadeRegistros = this.ContarDados();

                return this.Infra.RetornarSucesso(quantidadeRegistros);
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<long>(ex);
            }
        }
      
        /// <summary>Método excluir referente à tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Excluir(TOCategoria toCategoria)
        {
            try
            {
                int registrosAfetados;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.ResetarAtributosDeControle();
                toCategoria.CodOperador = Infra.Usuario.Matricula;
                    
                //Inicia montagem do comando
                this.Sql.Comando.Append($"DELETE FROM {NOME_TABELA}");
                //Filtra a exclusão pelas chaves da tabela
                this.MontarWhereChaves(toCategoria, String.Empty);
                //Filtra a exclusão pelo campo de controle de acessos concorrentes
                this.Sql.MontarCampoWhere("ULT_ATUALIZACAO", toCategoria.UltAtualizacao);
          
                //Executa o comando
                registrosAfetados = this.ExcluirDados();
                if (registrosAfetados == 0)
                {
                    return this.Infra.RetornarFalha<int>(new ConcorrenciaMensagem());
                }
                
                return this.Infra.RetornarSucesso(registrosAfetados);
            }
			catch (ChaveEstrangeiraReferenciadaException ex)
            {
                return this.Infra.RetornarFalha<int>(new ChaveEstrangeiraReferenciadaMensagem(ex));
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
     
        /// <summary>Método incluir referente à tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Incluir(TOCategoria toCategoria)
        {
            try
            { 
                int registrosAfetados;                
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.ResetarAtributosDeControle();
                toCategoria.CodOperador = Infra.Usuario.Matricula; 
                //Inicia montagem do comando
                this.Sql.Comando.Append($"INSERT INTO {NOME_TABELA} (");

                this.Sql.MontarCampoInsert("COD_CATEGORIA",toCategoria.CodCategoria);
                //Monta campos que serão inseridos
                this.MontarInsert(toCategoria);
                 
                //Une os buffers de montagem do comando
                this.Sql.Comando.Append(") VALUES (");                
                this.Sql.Comando.Append(this.Sql.Temporario.ToString());
                
                this.Sql.Comando.Append(")");

                //Executa o comando
                registrosAfetados = this.IncluirDados();

                return this.Infra.RetornarSucesso(registrosAfetados);
            }
			catch (RegistroDuplicadoException ex)
            {
                return this.Infra.RetornarFalha<int>(new RegistroDuplicadoMensagem(ex));
            }
			catch (ChaveEstrangeiraInexistenteException ex)
            {
                return this.Infra.RetornarFalha<int>(new ChaveEstrangeiraInexistenteMensagem(ex));
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<int>(ex);
            }
        }
    
        /// <summary>Método listar referente à tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <param name="toPaginacao">Classe da infra-estrutura contendo as informações de paginação.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<List<TOCategoria>> Listar(TOCategoria toCategoria, TOPaginacao toPaginacao)
        {
            try
            {
                List<TOCategoria> dados;
                TOCategoria toRetorno;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.ResetarAtributosDeControle();

                //Inicia montagem do comando
                this.Sql.Comando.Append("SELECT ");
                this.Sql.Comando.Append("CAT.COD_CATEGORIA, ");
                this.Sql.Comando.Append("CAT.COD_OPERADOR, ");
                this.Sql.Comando.Append("CAT.DESCRICAO, ");
                this.Sql.Comando.Append("CAT.ULT_ATUALIZACAO ");
                this.Sql.Comando.Append($"FROM {NOME_TABELA} CAT");
                //Filtra consulta pelos dados informados no TO
                this.MontarWhere(toCategoria, "CAT.");

                dados = new List<TOCategoria>();

                if (toPaginacao == null)
                {
                    //Executa o comando sem utilizar paginação
                    using (ListaConectada listaConectada = this.ListarDados())
                    {
                        //Cria TO para cada tupla retornada
                        while (listaConectada.Ler())
                        {
                            toRetorno = new TOCategoria();
                            toRetorno.PopularRetorno(listaConectada.LinhaAtual);
                            dados.Add(toRetorno);
                        }
                    }
                }
                else
                {
                    //Executa o comando utilizando paginação
                    ListaDesconectada listaDesconectada = this.ListarDados(toPaginacao);

                    //Cria TO para cada tupla retornada
                    foreach (Linha linha in listaDesconectada.Linhas)
                    {
                        toRetorno = new TOCategoria();
                        toRetorno.PopularRetorno(linha);
                        dados.Add(toRetorno);
                    }
                }

                return this.Infra.RetornarSucesso(dados);
            }    
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<List<TOCategoria>>(ex);
            }
        }
    
        /// <summary>Método obter referente à tabela CATEGORIA.</summary>
        /// <param name="toCategoria">Transfer Object de entrada referente à tabela CATEGORIA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<TOCategoria> Obter(TOCategoria toCategoria)
        {
            try
            {
                Linha linha;
                TOCategoria dados;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.ResetarAtributosDeControle();

                //Inicia montagem do comando
                this.Sql.Comando.Append("SELECT ");
                this.Sql.Comando.Append("CAT.COD_CATEGORIA, ");
                this.Sql.Comando.Append("CAT.COD_OPERADOR, ");
                this.Sql.Comando.Append("CAT.DESCRICAO, ");
                this.Sql.Comando.Append("CAT.ULT_ATUALIZACAO ");
                this.Sql.Comando.Append($"FROM {NOME_TABELA} CAT");
                //Filtra consulta pelos dados informados no TO
                this.MontarWhereChaves(toCategoria, "CAT.");

                //Executa o comando
                linha = this.ObterDados();
                if (linha == null)
                {
                    return this.Infra.RetornarFalha<TOCategoria>(new RegistroInexistenteMensagem());
                }
                
                //Cria TO para a tupla retornada
                dados = new TOCategoria();
                dados.PopularRetorno(linha);

                return this.Infra.RetornarSucesso(dados);
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<TOCategoria>(ex);
            }
        }

        /// <summary>Reseta os atributos de controle.</summary>
        private void ResetarAtributosDeControle()
        {
            this.Sql.Comando.Length = 0;
            this.Parametros.Clear();
            this.Sql.Temporario.Clear();
        }

        /// <summary>Monta campos para cláusula WHERE.</summary>
        /// <param name="toCategoria">TO contendo os campos.</param>
        /// <param name="alias">Alias da tabela Categoria.</param>
        /// 
        private void MontarWhere(TOCategoria toCategoria, String alias)
        {
            //Monta no WHERE todos os campos da tabela que foram informados
            
            this.MontarWhereChaves(toCategoria, alias);
            this.MontarCampos(this.Sql.MontarCampoWhere, toCategoria, alias);
            
			this.Sql.MontarCampoWhere(alias + "ULT_ATUALIZACAO", toCategoria.UltAtualizacao);
        }
        
        /// <summary>Monta campos chave para cláusula WHERE.</summary>
        /// <param name="toCategoria">TO contendo os campos.</param>
        /// <param name="alias">Alias da tabela Categoria.</param>
        private void MontarWhereChaves(TOCategoria toCategoria, String alias)
        {
            //Monta no WHERE todos os campos chave da tabela
            
            this.MontarCamposChave(this.Sql.MontarCampoWhere, toCategoria, alias);
        }
        
        /// <summary>Monta campos para cláusula SET.</summary>
        /// <param name="toCategoria">TO contendo os campos.</param>
        private void MontarSet(TOCategoria toCategoria)
        {
            //Monta no SET todos os campos não chave da tabela que foram informados
            
            this.MontarCampos(this.Sql.MontarCampoSet, toCategoria, String.Empty);
            this.Sql.MontarCampoSet("ULT_ATUALIZACAO");
            this.Sql.Comando.Append("CURRENT_TIMESTAMP");
        }
        
        /// <summary>Monta campos para cláusula INSERT.</summary>
        /// <param name="toCategoria">TO contendo os campos.</param>
        private void MontarInsert(TOCategoria toCategoria)
        {
            //Monta no INSERT todos os campos da tabela que foram informados
            
            this.MontarCamposChave(this.Sql.MontarCampoInsert, toCategoria, String.Empty);
            this.MontarCampos(this.Sql.MontarCampoInsert, toCategoria, String.Empty);
            this.Sql.MontarCampoInsert("ULT_ATUALIZACAO");
            this.Sql.Temporario.Append("CURRENT_TIMESTAMP");
        }
        
        /// <summary>Executa uma ação nos campos chave de um TO.</summary>
        /// <param name="montagem">Ação a ser executada.</param>
        /// <param name="toCategoria">TO alvo das ações.</param>
        /// <param name="alias">Alias da tabela Categoria.</param>
        private void MontarCamposChave(ConstrutorSql.MontarCampo montagem, TOCategoria toCategoria, String alias)
        {   
            //Invoca qualquer comando simples de montagem nos campos chave da tabela
            
            montagem.Invoke(alias + "COD_CATEGORIA", toCategoria.CodCategoria);
        }
        
        /// <summary>Executa uma ação nos campos não chave de um TO.</summary>
        /// <param name="montagem">Ação a ser executada.</param>
        /// <param name="toCategoria">TO alvo das ações.</param>
        /// <param name="alias">Alias da tabela Categoria.</param>
        private void MontarCampos(ConstrutorSql.MontarCampo montagem, TOCategoria toCategoria, String alias)
        {   
            //Invoca qualquer comando simples de montagem nos campos não chave da tabela, exceto no que faz controle de acessos concorrentes
            
            montagem.Invoke(alias + "COD_OPERADOR", toCategoria.CodOperador);
            montagem.Invoke(alias + "DESCRICAO", toCategoria.Descricao);
        }

        /// <summary>Cria um parâmetro para a instrução SQL.</summary>
        /// <param name="nomeCampo">Nome do campo da tabela.</param>
        /// <param name="conteudo">Valor para o parâmetro.</param>
        /// <returns>Parâmetro recém-criado.</returns>
        protected override Parametro CriarParametro(String nomeCampo, Object conteudo)
        {
            Parametro parametro = new Parametro();
            switch (nomeCampo)
            {   
                #region Chaves Primárias
                case "COD_CATEGORIA":
                    parametro.Precision = 4;
                    parametro.Size = 4;
                    parametro.DbType = DbType.Int32;
                    break;                        
                #endregion

                #region Campos Obrigatórios
                case "COD_OPERADOR":
                    parametro.Precision = 6;
                    parametro.Size = 6;
                    parametro.DbType = DbType.String;
                    break;
                case "DESCRICAO":
                    parametro.Precision = 35;
                    parametro.Size = 35;
                    parametro.DbType = DbType.String;
                    break;
                case "ULT_ATUALIZACAO":
                    parametro.Precision = 10;
                    parametro.Scale = 6;
                    parametro.Size = 10;
                    parametro.DbType = DbType.DateTime;
                    break;
                #endregion

                #region Campos Opcionais

#if DEBUG
                default:
                    //Força um erro em modo debug para alertar o programador caso tenha caido no default
                    //Todo parâmetro deve cair em um case neste switch
                    parametro = null;
                    break;
#endif
                #endregion                
            }
            parametro.Direction = ParameterDirection.Input;
            parametro.SourceColumn = nomeCampo;
            
            if (parametro.Scale > 0 && conteudo != null &&  parametro.DbType != DbType.DateTime)
            {
                parametro.Value = String.Format(CultureInfo.InvariantCulture, "{0:F" + parametro.Scale + "}", conteudo);
            }
            else
            {
                parametro.Value = conteudo;
            }
            
            return parametro;
        }
        #endregion
    }
}