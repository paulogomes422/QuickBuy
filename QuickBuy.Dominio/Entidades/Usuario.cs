﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario : Entidade
    {
            public int ID { get; set; }
            public string Email { get; set; }
            public string Senha { get; set; }
            public string Nome { get; set; }

            public string Sobrenome { get; set; }

            public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
