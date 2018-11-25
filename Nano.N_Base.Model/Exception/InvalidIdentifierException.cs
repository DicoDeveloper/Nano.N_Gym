using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidIdentifierException : System.Exception
    {
        public InvalidIdentifierException() : base() { }
        public InvalidIdentifierException(string message) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}") { }
        public InvalidIdentifierException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}", inner) { }
    }
}
