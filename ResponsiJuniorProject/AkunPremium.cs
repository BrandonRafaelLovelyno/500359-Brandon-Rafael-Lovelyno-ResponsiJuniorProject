using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJuniorProject
{
    internal class AkunPremium : Akun
    {
        private int _saldo;

        public int Saldo { get { return _saldo; } set { 
                if(value < 0)
                {
                    throw new Exception("Saldo tidak bisa kurang dari nol");
                }
                _saldo = value; } }
    }
}
