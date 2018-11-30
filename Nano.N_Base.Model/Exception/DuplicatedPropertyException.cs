using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class DuplicatedPropertyException : System.Exception
    {
        public DuplicatedPropertyException() : base() { }
        public DuplicatedPropertyException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { }
        public DuplicatedPropertyException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { }
    }
}
