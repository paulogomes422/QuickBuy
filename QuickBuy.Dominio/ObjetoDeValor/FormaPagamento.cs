using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    class FormaPagamento
    {

        public int ID { get; set; }
        public string nome { get; set; }
        public string Descricao { get; set; }

        public bool Ehboleto
        {
            get { return ID == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool EhCartaoCredito
        {
            get { return ID == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool Ehdeposito
        {
            get { return ID == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool NaoFoiDefinido
        {
            get { return ID == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }


    }
}
