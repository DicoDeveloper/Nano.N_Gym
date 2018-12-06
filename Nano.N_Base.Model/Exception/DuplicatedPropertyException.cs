using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class DuplicatedPropertyException : BaseException
    {
        public DuplicatedPropertyException() : base() { Nivel = NivelExcecao.Operacional; }
        public DuplicatedPropertyException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { Nivel = NivelExcecao.Operacional; }
        public DuplicatedPropertyException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { Nivel = NivelExcecao.Operacional; }
    }
}
