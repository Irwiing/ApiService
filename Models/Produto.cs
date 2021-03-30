using System;

namespace Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
