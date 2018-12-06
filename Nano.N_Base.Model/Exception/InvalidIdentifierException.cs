using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidIdentifierException : BaseException
    {
        public InvalidIdentifierException() : base() { Nivel = NivelExcecao.Aplicativo; }
        public InvalidIdentifierException(string message) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}") { Nivel = NivelExcecao.Aplicativo; }
        public InvalidIdentifierException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}", inner) { Nivel = NivelExcecao.Aplicativo; }
    }
}
