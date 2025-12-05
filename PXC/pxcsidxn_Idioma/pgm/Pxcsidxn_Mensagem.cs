using System;

namespace Bergs.Pxc.Pxcsidxn
{
    /// <summary>Mensagens previstas para o componente</summary>
    public enum TipoMensagem
    {
        /// <summary>Iso com valor nulo ou vazio</summary>
        IsoNuloOuVazio,
        /// <summary>Formato do iso inválido</summary>
        FormatoInvalido,
        /// <summary>Tamanho do idioma inválido</summary>
        TamanhoIdiomaInvalido,
        /// <summary>Idioma já existe no banco</summary>
        FalhaRnIncluirIdiomaJaExistente
    }

    class Mensagem : Bergs.Pwx.Pwxoiexn.Mensagens.Mensagem
    {
        /// <summary>
        /// Mensagem
        /// </summary>
        private string mensagem;
        
        /// <summary>
        /// Tipo de mensagem
        /// </summary>
        private Pxcsidxn.TipoMensagem tipoMensagem;
        
        /// <summary>
        /// Mensagem para o usuário
        /// </summary>
        public override string ParaUsuario
        {
            get { return this.ParaOperador; }
        }

        /// <summary>
        /// Mensagem para o operador
        /// </summary>
        public override string ParaOperador
        {
            get { return this.mensagem; }
        }

        /// <summary>
        /// Identificador
        /// </summary>
        public override string Identificador
        {
            get { return tipoMensagem.ToString(); }
        }

        /// <summary>
        /// Construtor da classe Mensagem
        /// </summary>
        /// <param name="mensagem">Mensagem</param>
        /// <param name="argumentos">Argumentos</param>
        public Mensagem(Pxcsidxn.TipoMensagem mensagem, params string[] argumentos)
        {
            tipoMensagem = mensagem;

            switch (mensagem)
            {
                case Pxcsidxn.TipoMensagem.IsoNuloOuVazio:
                    this.mensagem = "código combinado ISO não pode ser nulo ou vazio.";
                    break;
                case Pxcsidxn.TipoMensagem.FormatoInvalido:
                    this.mensagem = "Formato inválido do código combinado ISO. Deve ser 'll-PP' ou 'lll-PP'.";
                    break;
                case Pxcsidxn.TipoMensagem.TamanhoIdiomaInvalido:
                    this.mensagem = "Idioma deve ter 2 a 3 caracteres.";
                    break;
                case Pxcsidxn.TipoMensagem.FalhaRnIncluirIdiomaJaExistente:
                    this.mensagem = "Já existe na base de dados um idioma com código equivalente ao código informado.";
                    break;
                default:
                    this.mensagem = "Mensagem não definida.";
                    break;
            }
        }
    }
}
