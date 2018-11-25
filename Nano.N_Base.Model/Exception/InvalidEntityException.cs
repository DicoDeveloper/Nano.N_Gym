using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidEntityException : System.Exception
    {
        public InvalidEntityException() : base() { }
        public InvalidEntityException(string message) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}") { }
        public InvalidEntityException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}", inner) { }
    }
}
