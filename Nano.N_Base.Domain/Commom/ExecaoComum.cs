using System;

namespace Nano.N_Base.Domain.Commom
{
    public static class ExecaoComum
    {
        public static void ErroDeIdInvalido(Type tipoEntidade)
        {
            throw new ArgumentException($"O identifcador de {tipoEntidade.Name} não pode ser menor que zero.");
        }
    }
}
