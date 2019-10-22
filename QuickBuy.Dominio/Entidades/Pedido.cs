using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    class Pedido : Entidade
    {
        public int id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public string NumeroEndereco { get; set; }


        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }





        //Pedido deve ter pelo menos um item de pedido ou muitos itens de pedido
        public ICollection<ItemPedido> Itenspedido { get; set; }

        public override void Validate()
        {
            if (!Itenspedido.Any())
                AdicionarCritica("Crítica -Pedido não pode ficar sem item de pedido");
            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica -  CEP não pode ser vazio");
        }
    }
}
