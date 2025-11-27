using Bergs.Pwx.Pwxodaxn;
using Bergs.Pwx.Pwxoiexn;
using Bergs.Pwx.Pwxoiexn.Btr;
using System;
using System.Data;
using System.Xml.Serialization;

namespace Bergs.Pxc.Pxcbtoxn
{       
    /// <summary>Representa um registro da tabela IDIOMA da base de dados PXC.</summary>
    public class TOIdioma : TOTabela
  {

        #region Propriedades
        
        #region Chaves Primárias
        /// <summary>Campo COD_IDIOMA da tabela IDIOMA.</summary>
        [XmlAttribute("cod_idioma")]
        [CampoTabela("COD_IDIOMA", Chave = true, Obrigatorio = true, TipoParametro = DbType.Int32, Tamanho = 4, Precisao = 4)]
        public CampoObrigatorio<int> CodIdioma { get; set; }
        #endregion
        
        #region Campos Obrigatórios
        /// <summary>Campo DESC_IDIOMA da tabela IDIOMA.</summary>
        [XmlAttribute("desc_idioma")]
        [CampoTabela("DESC_IDIOMA", Obrigatorio = true, TipoParametro = DbType.String, Tamanho = 50, Precisao = 50)]
        public CampoObrigatorio<string> DescIdioma { get; set; }

        /// <summary>Campo DESC_IDIOMA da tabela IDIOMA.</summary>
        [XmlAttribute("cod_iso_idioma")]
        public CampoObrigatorio<string> CodigoIsoCombinado { get; set; }
        #endregion

        #region Campos Opcionais
        /// <summary>Campo COD_USUARIO da tabela IDIOMA.</summary>
        [XmlAttribute("cod_usuario")]
        [CampoTabela("COD_USUARIO", TipoParametro = DbType.String, Tamanho = 6, Precisao = 6)]
        public CampoOpcional<string> CodUsuario { get; set; }
        
        /// <summary>Campo DTHR_ULT_ATU da tabela IDIOMA.</summary>
        [XmlAttribute("dthr_ult_atu")]
        [CampoTabela("DTHR_ULT_ATU", TipoParametro = DbType.DateTime, Tamanho = 10, Precisao = 10, Escala = 6)]
        public CampoOpcional<DateTime> DthrUltAtu { get; set; }
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
                    case "COD_IDIOMA":
                        CodIdioma = Convert.ToInt32(campo.Conteudo);
                        break;                        
                    #endregion

                    #region Campos Obrigatórios
                    case "DESC_IDIOMA":
                        DescIdioma = Convert.ToString(campo.Conteudo).Trim();
                        break;

                    case "CODIGO_IDIOMA":
                        CodIdioma = Convert.ToInt32(campo.Conteudo);
                        CodigoIsoCombinado = Feconid.CodigoToIso(CodIdioma);
                        break;
                    #endregion

                    #region Campos Opcionais
                    case "COD_USUARIO":
                        CodUsuario = LerCampoOpcional<String>(campo);
                        break;
                    case "DTHR_ULT_ATU":
                        DthrUltAtu = LerCampoOpcional<DateTime>(campo);
                        break;
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