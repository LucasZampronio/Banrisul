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

namespace Bergs.Pxc.Pxcqidxn
{
    /// <summary>Classe que possui os métodos de manipulação de dados da tabela IDIOMA da base de dados PXC.</summary>
    public class Idioma : AplicacaoDados
    {
        #region Métodos
        /// <summary>Método alterar referente à tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Alterar(TOIdioma toIdioma)
        {
            try
            {
                int registrosAfetados;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.Sql.Comando.Length = 0;
                this.Parametros.Clear();
                
                //Inicia montagem do comando
                this.Sql.Comando.Append("UPDATE PXC.IDIOMA");
                //Monta campos que serão modificados
                this.MontarSet(toIdioma);
                //Filtra a alteração pelas chaves da tabela
                this.MontarWhereChaves(toIdioma, String.Empty);
                //Filtra a alteração pelo campo de controle de acessos concorrentes
                this.Sql.MontarCampoWhere("DTHR_ULT_ATU", toIdioma.DthrUltAtu);

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
     
        /// <summary>Método contar referente à tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<long> Contar(TOIdioma toIdioma)
        {
            try
            {
                long quantidadeRegistros;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.Sql.Comando.Length = 0;
                this.Parametros.Clear();

                //Inicia montagem do comando
                this.Sql.Comando.Append("SELECT COUNT(*) FROM PXC.IDIOMA");
                //Filtra consulta pelos dados informados no TO
                this.MontarWhere(toIdioma, String.Empty);

                //Executa o comando
                quantidadeRegistros = this.ContarDados();

                return this.Infra.RetornarSucesso(quantidadeRegistros);
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<long>(ex);
            }
        }
      
        /// <summary>Método excluir referente à tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Excluir(TOIdioma toIdioma)
        {
            try
            {
                int registrosAfetados;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.Sql.Comando.Length = 0;
                this.Parametros.Clear();
                
                //Inicia montagem do comando
                this.Sql.Comando.Append("DELETE FROM PXC.IDIOMA");
                //Filtra a exclusão pelas chaves da tabela
                this.MontarWhereChaves(toIdioma, String.Empty);
                //Filtra a exclusão pelo campo de controle de acessos concorrentes
                this.Sql.MontarCampoWhere("DTHR_ULT_ATU", toIdioma.DthrUltAtu);
          
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
     
        /// <summary>Método incluir referente à tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<int> Incluir(TOIdioma toIdioma)
        {
            try
            { 
                int registrosAfetados;                
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.Sql.Comando.Length = 0;
                this.Sql.Temporario.Length = 0;
                this.Parametros.Clear();
                
                //Inicia montagem do comando
                this.Sql.Comando.Append("INSERT INTO PXC.IDIOMA (");
                //Monta campos que serão inseridos
                this.MontarInsert(toIdioma);
                 
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
    
        /// <summary>Método listar referente à tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <param name="toPaginacao">Classe da infra-estrutura contendo as informações de paginação.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<List<TOIdioma>> Listar(TOIdioma toIdioma, TOPaginacao toPaginacao)
        {
            try
            {
                List<TOIdioma> dados;
                TOIdioma toRetorno;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.Sql.Comando.Length = 0;
                this.Parametros.Clear(); 

                //Inicia montagem do comando
                this.Sql.Comando.Append("SELECT ");
                this.Sql.Comando.Append("IDI.COD_IDIOMA, ");
                this.Sql.Comando.Append("IDI.COD_USUARIO, ");
                this.Sql.Comando.Append("IDI.DESC_IDIOMA, ");
                this.Sql.Comando.Append("IDI.DTHR_ULT_ATU ");
                this.Sql.Comando.Append("FROM PXC.IDIOMA IDI");
                //Filtra consulta pelos dados informados no TO
                this.MontarWhere(toIdioma, "IDI.");

                dados = new List<TOIdioma>();

                if (toPaginacao == null)
                {
                    //Executa o comando sem utilizar paginação
                    using (ListaConectada listaConectada = this.ListarDados())
                    {
                        //Cria TO para cada tupla retornada
                        while (listaConectada.Ler())
                        {
                            toRetorno = new TOIdioma();
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
                        toRetorno = new TOIdioma();
                        toRetorno.PopularRetorno(linha);
                        dados.Add(toRetorno);
                    }
                }

                return this.Infra.RetornarSucesso(dados);
            }    
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<List<TOIdioma>>(ex);
            }
        }
    
        /// <summary>Método obter referente à tabela IDIOMA.</summary>
        /// <param name="toIdioma">Transfer Object de entrada referente à tabela IDIOMA.</param>
        /// <returns>Classe de retorno contendo as informações de resposta ou as informações de erro.</returns>
        public virtual Retorno<TOIdioma> Obter(TOIdioma toIdioma)
        {
            try
            {
                Linha linha;
                TOIdioma dados;
                
                //Limpa as propriedades utilizadas para a montagem do comando
                this.Sql.Comando.Length = 0;
                this.Parametros.Clear(); 

                //Inicia montagem do comando
                this.Sql.Comando.Append("SELECT ");
                this.Sql.Comando.Append("IDI.COD_IDIOMA, ");
                this.Sql.Comando.Append("IDI.COD_USUARIO, ");
                this.Sql.Comando.Append("IDI.DESC_IDIOMA, ");
                this.Sql.Comando.Append("IDI.DTHR_ULT_ATU ");
                this.Sql.Comando.Append("FROM PXC.IDIOMA IDI");
                //Filtra consulta pelos dados informados no TO
                this.MontarWhereChaves(toIdioma, "IDI.");

                //Executa o comando
                linha = this.ObterDados();
                if (linha == null)
                {
                    return this.Infra.RetornarFalha<TOIdioma>(new RegistroInexistenteMensagem());
                }
                
                //Cria TO para a tupla retornada
                dados = new TOIdioma();
                dados.PopularRetorno(linha);

                return this.Infra.RetornarSucesso(dados);
            }
            catch (Exception ex)
            {
                return this.Infra.TratarExcecao<TOIdioma>(ex);
            }
        }
    
        /// <summary>Monta campos para cláusula WHERE.</summary>
        /// <param name="toIdioma">TO contendo os campos.</param>
        /// <param name="alias">Alias da tabela Idioma.</param>
        private void MontarWhere(TOIdioma toIdioma, String alias)
        {
            //Monta no WHERE todos os campos da tabela que foram informados
            
            this.MontarWhereChaves(toIdioma, alias);
            this.MontarCampos(this.Sql.MontarCampoWhere, toIdioma, alias);
            
			this.Sql.MontarCampoWhere(alias + "DTHR_ULT_ATU", toIdioma.DthrUltAtu);
        }
        
        /// <summary>Monta campos chave para cláusula WHERE.</summary>
        /// <param name="toIdioma">TO contendo os campos.</param>
        /// <param name="alias">Alias da tabela Idioma.</param>
        private void MontarWhereChaves(TOIdioma toIdioma, String alias)
        {
            //Monta no WHERE todos os campos chave da tabela
            
            this.MontarCamposChave(this.Sql.MontarCampoWhere, toIdioma, alias);
        }
        
        /// <summary>Monta campos para cláusula SET.</summary>
        /// <param name="toIdioma">TO contendo os campos.</param>
        private void MontarSet(TOIdioma toIdioma)
        {
            //Monta no SET todos os campos não chave da tabela que foram informados
            
            this.MontarCampos(this.Sql.MontarCampoSet, toIdioma, String.Empty);
            this.Sql.MontarCampoSet("DTHR_ULT_ATU");
            this.Sql.Comando.Append("CURRENT_TIMESTAMP");
        }
        
        /// <summary>Monta campos para cláusula INSERT.</summary>
        /// <param name="toIdioma">TO contendo os campos.</param>
        private void MontarInsert(TOIdioma toIdioma)
        {
            //Monta no INSERT todos os campos da tabela que foram informados
            
            this.MontarCamposChave(this.Sql.MontarCampoInsert, toIdioma, String.Empty);
            this.MontarCampos(this.Sql.MontarCampoInsert, toIdioma, String.Empty);
            this.Sql.MontarCampoInsert("DTHR_ULT_ATU");
            this.Sql.Temporario.Append("CURRENT_TIMESTAMP");
        }
        
        /// <summary>Executa uma ação nos campos chave de um TO.</summary>
        /// <param name="montagem">Ação a ser executada.</param>
        /// <param name="toIdioma">TO alvo das ações.</param>
        /// <param name="alias">Alias da tabela Idioma.</param>
        private void MontarCamposChave(ConstrutorSql.MontarCampo montagem, TOIdioma toIdioma, String alias)
        {   
            //Invoca qualquer comando simples de montagem nos campos chave da tabela
            
            montagem.Invoke(alias + "COD_IDIOMA", toIdioma.CodIdioma);
        }
        
        /// <summary>Executa uma ação nos campos não chave de um TO.</summary>
        /// <param name="montagem">Ação a ser executada.</param>
        /// <param name="toIdioma">TO alvo das ações.</param>
        /// <param name="alias">Alias da tabela Idioma.</param>
        private void MontarCampos(ConstrutorSql.MontarCampo montagem, TOIdioma toIdioma, String alias)
        {   
            //Invoca qualquer comando simples de montagem nos campos não chave da tabela, exceto no que faz controle de acessos concorrentes
            
            montagem.Invoke(alias + "COD_USUARIO", toIdioma.CodUsuario);
            montagem.Invoke(alias + "DESC_IDIOMA", toIdioma.DescIdioma);
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
                case "COD_IDIOMA":
                    parametro.Precision = 4;
                    parametro.Size = 4;
                    parametro.DbType = DbType.Int32;
                    break;                        
                #endregion

                #region Campos Obrigatórios
                case "DESC_IDIOMA":
                    parametro.Precision = 50;
                    parametro.Size = 50;
                    parametro.DbType = DbType.String;
                    break;
                #endregion

                #region Campos Opcionais
                case "COD_USUARIO":
                    parametro.Precision = 6;
                    parametro.Size = 6;
                    parametro.DbType = DbType.String;
                    break;
                case "DTHR_ULT_ATU":
                    parametro.Precision = 10;
                    parametro.Scale = 6;
                    parametro.Size = 10;
                    parametro.DbType = DbType.DateTime;
                    break;

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