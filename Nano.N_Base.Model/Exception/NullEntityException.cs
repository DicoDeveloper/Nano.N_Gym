using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class NullEntityException : System.Exception
    {
        public NullEntityException() : base() { }
        public NullEntityException(string message) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}") { }
        public NullEntityException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}", inner) { }
    }
}
