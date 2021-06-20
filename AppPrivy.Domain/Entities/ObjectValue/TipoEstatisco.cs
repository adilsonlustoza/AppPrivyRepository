using System;

namespace AppPrivy.Domain.Entities.ObjectValue
{
    [Flags]
    public enum TipoEstatisco
    {
        Nenhum = 0,
        GraficoPizzaPainel = 1,
        Dados = 2,
        NaoDefinido=4
    }
}