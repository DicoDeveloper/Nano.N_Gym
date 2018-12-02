using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidDeleteOperationException : System.Exception
    {
        public InvalidDeleteOperationException() : base() { }
        public InvalidDeleteOperationException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { }
        public InvalidDeleteOperationException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { }
    }
}
