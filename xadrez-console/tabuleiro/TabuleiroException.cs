using System;


namespace tabuleiro
{

    class TabuleiroException : Exception //classe que que faz excessões personalizadas
    {
        public TabuleiroException(string message) : base(message)//ok
        {
        }
    }
}
