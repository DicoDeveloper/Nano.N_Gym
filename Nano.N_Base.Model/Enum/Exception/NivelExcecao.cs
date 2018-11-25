using System.ComponentModel;

namespace Nano.N_Base.Model.Enum.Exception
{
    public enum NivelExcecao : int
    {
        [Description("Aplicativo")]
        Aplicativo = 0,
        [Description("Operacional")]
        Operacional = 1
    }
}
