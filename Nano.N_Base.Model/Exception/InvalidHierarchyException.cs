using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidHierarchyException : System.Exception
    {
        public InvalidHierarchyException() : base() { }
        public InvalidHierarchyException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { }
        public InvalidHierarchyException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { }
    }
}
