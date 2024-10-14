using System.ComponentModel;

namespace MultiplasJanelas
{
    public class Produto
    {
        public int Id { get; set; }

        [DisplayName("Produto")]
        public string Nome { get; set; }
        public string Fabricante { get; set; }

        [DisplayName("Preço de Compra")]
        public decimal PrecoCompra {  get; set; }

        [DisplayName("Preço de Venda")]
        public decimal PrecoVenda { get; set; }
    }
}
