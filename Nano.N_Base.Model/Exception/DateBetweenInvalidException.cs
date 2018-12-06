using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class DateBetweenInvalidException : BaseException
    {
        public DateBetweenInvalidException() : base() { Nivel = NivelExcecao.Operacional; }
        public DateBetweenInvalidException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { Nivel = NivelExcecao.Operacional; }
        public DateBetweenInvalidException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { Nivel = NivelExcecao.Operacional; }
    }
}
