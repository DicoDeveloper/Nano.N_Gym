using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class NullEntityException : BaseException
    {
        public NullEntityException() : base() { Nivel = NivelExcecao.Aplicativo; }
        public NullEntityException(string message) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}") { Nivel = NivelExcecao.Aplicativo; }
        public NullEntityException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}", inner) { Nivel = NivelExcecao.Aplicativo; }
    }
}
