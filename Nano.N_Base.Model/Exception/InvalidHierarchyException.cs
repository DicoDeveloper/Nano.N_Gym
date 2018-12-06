using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidHierarchyException : BaseException
    {
        public InvalidHierarchyException() : base() { Nivel = NivelExcecao.Operacional; }
        public InvalidHierarchyException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { Nivel = NivelExcecao.Operacional; }
        public InvalidHierarchyException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { Nivel = NivelExcecao.Operacional; }
    }
}
