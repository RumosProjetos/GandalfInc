using System.ComponentModel;

namespace Projeto.Lib.Faturacao
{
    public enum TipoPagamento
    {
        [Description("Indefinido")]
        Indefinido = 0,
        [Description("Multibanco")]
        Multibanco = 1,
        [Description("Dinheiro")]
        Dinheiro = 2,
        [Description("MbWay")]
        MbWay = 3
    }
}
