using System;

namespace Bergs.Pxc.Pxcscaxn
{
    /// <summary>Mensagens previstas para o componente</summary>
    public enum TipoMensagem
    {
        /// <summary>Código de categoria não encontrado na base</summary>
        CodigoNaoEncontrado,
        /// <summary>A lista está vazia</summary>
        ListaVazia,
        /// <summary>A Descrição não foi encontrada</summary>
        DescricaoNaoEncontrada
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
        private Pxcscaxn.TipoMensagem tipoMensagem;
        
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
        public Mensagem(Pxcscaxn.TipoMensagem mensagem, params string[] argumentos)
        {
            tipoMensagem = mensagem;

            switch (mensagem)
            {
                case Pxcscaxn.TipoMensagem.CodigoNaoEncontrado:
                    this.mensagem = "Código de categoria não encontrado na base.";
                    break;
                case Pxcscaxn.TipoMensagem.ListaVazia:
                    this.mensagem = "A lista de categorias está vazia.";
                    break;
                case Pxcscaxn.TipoMensagem.DescricaoNaoEncontrada:
                    this.mensagem = "A Descrição não foi encontrada.";
                    break;
                default:
                    this.mensagem = "Mensagem não definida.";
                    break;
            }
        }
    }
}
