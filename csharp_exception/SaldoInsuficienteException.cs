﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public SaldoInsuficienteException(string menesagem): base(menesagem)
        {

        }
    }
}
