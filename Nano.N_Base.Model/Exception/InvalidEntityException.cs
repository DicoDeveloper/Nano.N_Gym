using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class InvalidEntityException : BaseException
    {
        public InvalidEntityException() : base() { Nivel = NivelExcecao.Aplicativo; }
        public InvalidEntityException(string message) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}") { Nivel = NivelExcecao.Aplicativo; }
        public InvalidEntityException(string message, System.Exception inner) : base($"{message}\nNivel: {NivelExcecao.Aplicativo}", inner) { Nivel = NivelExcecao.Aplicativo; }
    }
}
