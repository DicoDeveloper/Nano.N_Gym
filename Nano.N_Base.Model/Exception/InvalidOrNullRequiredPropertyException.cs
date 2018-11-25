using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidOrNullRequiredPropertyException : System.Exception
    {
        public InvalidOrNullRequiredPropertyException() : base() { }
        public InvalidOrNullRequiredPropertyException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { }
        public InvalidOrNullRequiredPropertyException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { }
    }
}
