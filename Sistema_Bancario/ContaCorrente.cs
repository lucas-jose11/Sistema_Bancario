﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario
{
    //herda da ContaBancaria

    public class ContaCorrente : ContaBancaria // Herda de ContaBancaria
    {
        private int _id;

        // Construtor
        public ContaCorrente(int id, string titular, int numeroConta, double saldo) : base(titular, numeroConta, saldo) // Chama o construtor da classe pai
        {
            Id = id;
        }

        public int Id // +algo aq?
        {
            get { return _id; }
            set { _id = value; }
        }

        public void TaxaDeSaque()
        {
            //cobrar uma taxa fixa de R$5,00 a cada saque

        }




    }
}
