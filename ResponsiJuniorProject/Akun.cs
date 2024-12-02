using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJuniorProject
{
    internal class Akun
    {
        private int _saldo;
        private int max_saldo = 20;

        public int Saldo { get { return _saldo; } set {
                if (value < 0)
                {
                    throw new Exception("Saldo tidak bisa kurang dari nol");
                }
                if (value > max_saldo)
                {
                    throw new Exception("Saldo lebih dari batas saldo");
                }
                _saldo = value;
            } }

    }
}
