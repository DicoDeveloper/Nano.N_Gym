using System.ComponentModel;

namespace Nano.N_Base.Model.Enum.Exception
{
    public enum NivelExcecao : int
    {
        [Description("")]
        None = 0,
        [Description("Aplicativo")]
        Aplicativo = 1,
        [Description("Operacional")]
        Operacional = 2
    }
}
