using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidOrNullRequiredPropertyException : BaseException
    {
        public InvalidOrNullRequiredPropertyException() : base() { Nivel = NivelExcecao.Operacional; }
        public InvalidOrNullRequiredPropertyException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { Nivel = NivelExcecao.Operacional; }
        public InvalidOrNullRequiredPropertyException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { Nivel = NivelExcecao.Operacional; }
    }
}
