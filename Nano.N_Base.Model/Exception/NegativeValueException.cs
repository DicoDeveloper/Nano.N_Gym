using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class NegativeValueException : BaseException
    {
        public NegativeValueException() : base() { Nivel = NivelExcecao.Operacional; }
        public NegativeValueException(string message) : base($"{message}\nNivel: {NivelExcecao.Operacional}") { Nivel = NivelExcecao.Operacional; }
        public NegativeValueException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Operacional}", inner) { Nivel = NivelExcecao.Operacional; }
    }
}
