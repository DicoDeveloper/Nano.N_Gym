using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidDeleteOperationException : BaseException
    {
        public InvalidDeleteOperationException() : base() { Nivel = NivelExcecao.Operacional; }
        public InvalidDeleteOperationException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { Nivel = NivelExcecao.Operacional; }
        public InvalidDeleteOperationException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { Nivel = NivelExcecao.Operacional; }
    }
}
