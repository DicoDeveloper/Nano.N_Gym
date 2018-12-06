using Nano.N_Base.Model.Enum.Exception;

namespace Nano.N_Base.Model.Exception
{
    public class BaseException : System.Exception
    {
        public NivelExcecao Nivel { get; set; }

        public BaseException() : base() { }
        public BaseException(string message) : base(message) { }
        public BaseException(string message, System.Exception inner) : base(message, inner) { }
    }
}
