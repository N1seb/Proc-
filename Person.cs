using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirynt2._0
{
    internal class Person : ILabirintPart
    {
        private int _hp

        private int hp
        {
            get => hp;
            set
            {
                if (value > Consts.MaxHp) _hp = Consts.MaxHp;
                else if (value < 0) _hp = 0;
                else _hp = value;
            }
        }
    }
}
