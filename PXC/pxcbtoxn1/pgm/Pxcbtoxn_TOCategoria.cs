using Bergs.Pwx.Pwxodaxn;
using Bergs.Pwx.Pwxoiexn;
using Bergs.Pwx.Pwxoiexn.Btr;
using System;
using System.Data;
using System.Xml.Serialization;

namespace Bergs.Pxc.Pxcbtoxn
{       
    /// <summary>Representa um registro da tabela CATEGORIA da base de dados PXC.</summary>
    public class TOCategoria : TOTabela
  {

        #region Propriedades
        
        #region Chaves Primárias
        /// <summary>Campo COD_CATEGORIA da tabela CATEGORIA.</summary>
        [XmlAttribute("cod_categoria")]
        [CampoTabela("COD_CATEGORIA", Chave = true, Obrigatorio = true, TipoParametro = DbType.Int32, Tamanho = 4, Precisao = 4)]
        public CampoObrigatorio<int> CodCategoria { get; set; }
        #endregion
        
        #region Campos Obrigatórios
        /// <summary>Campo COD_OPERADOR da tabela CATEGORIA.</summary>
        [XmlAttribute("cod_operador")]
        [CampoTabela("COD_OPERADOR", Obrigatorio = true, TipoParametro = DbType.String, Tamanho = 6, Precisao = 6)]
        public CampoObrigatorio<string> CodOperador { get; set; }
        
        /// <summary>Campo DESCRICAO da tabela CATEGORIA.</summary>
        [XmlAttribute("descricao")]
        [CampoTabela("DESCRICAO", Obrigatorio = true, TipoParametro = DbType.String, Tamanho = 35, Precisao = 35)]
        public CampoObrigatorio<string> Descricao { get; set; }
        
        /// <summary>Campo ULT_ATUALIZACAO da tabela CATEGORIA.</summary>
        [XmlAttribute("ult_atualizacao")]
        [CampoTabela("ULT_ATUALIZACAO", Obrigatorio = true, UltAtualizacao = true, TipoParametro = DbType.DateTime, Tamanho = 10, Precisao = 10, Escala = 6)]
        public CampoObrigatorio<DateTime> UltAtualizacao { get; set; }
        #endregion
        
        #region Campos Opcionais
        #endregion
        
        #endregion

        #region Métodos
        /// <summary>Popula os atributos da classe a partir de uma linha de dados.</summary>
        /// <param name="linha">Linha de dados retornada pelo acesso à base de dados.</param>
        public override void PopularRetorno(Linha linha)
        {
            //Percorre os campos que foram retornados pela consulta e converte seus valores para tipos do .NET
            foreach (Campo campo in linha.Campos)
            {
                switch (campo.Nome)
                {   
                    #region Chaves Primárias
                    case "COD_CATEGORIA":
                        CodCategoria = Convert.ToInt32(campo.Conteudo);
                        break;                        
                    #endregion

                    #region Campos Obrigatórios
                    case "COD_OPERADOR":
                        CodOperador = Convert.ToString(campo.Conteudo).Trim();
                        break;
                    case "DESCRICAO":
                        Descricao = Convert.ToString(campo.Conteudo).Trim();
                        break;
                    case "ULT_ATUALIZACAO":
                        UltAtualizacao = Convert.ToDateTime(campo.Conteudo);
                        break;
                    #endregion

                    #region Campos Opcionais
                    #endregion

                    default:
                        //TODO: Tratar situação em que a coluna da tabela não tiver sido mapeada para uma propriedade do TO
                        break;
                }
            }
        }
        #endregion
    }
}