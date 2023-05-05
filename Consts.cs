using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirynt2._0
{
    internal class Consts
    {
        public const int LabirinthHeight = 20;
        public const int LabirinthWidth = 20;

        public const char PersonSymbol = '0';
        public const char WallsSymbol = '#';
        public const char ExitSymbol = 'f';

        public const int MaxHp = 100;

        public const ConsoleColor PersonBackgroundColor = ConsoleColor.Gray;
        public const ConsoleColor PersonForegroundColor = ConsoleColor.Red;

        public const ConsoleColor WallBackgroundColor = ConsoleColor.DarkBlue;
        public const ConsoleColor WallForegroundColor = ConsoleColor.Gray;

        public const ConsoleColor ExitBackgroundColor = ConsoleColor.Green;
        public const ConsoleColor ExitForegroundColor = ConsoleColor.Yellow;

        public const ConsoleColor EmptySpaceColor = ConsoleColor.DarkGray;
    }
}
