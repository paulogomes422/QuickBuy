using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    class produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
