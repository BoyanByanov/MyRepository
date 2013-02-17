using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7NumeralSystemsConvertor
{
    class ex7NumeralSystemsConvertor
    {
        static string GetChar(ulong i)
        {
            if (0 <= i && i < 26) return ((char)('A' + i)).ToString();//ako e do 25 si4ko e nared
            if (26 <= i && i < 52) return ((char)('a')).ToString() + ((char)('A' + i -26)).ToString();//ako e mejdu 26 i 52...
            if (52 <= i && i < 78) return ((char)('b')).ToString() + ((char)('A' + i - 52)).ToString();//ako e mejdu 26 i 52...
            if (78 <= i && i < 104) return ((char)('c')).ToString() + ((char)('A' + i - 78)).ToString();//ako e mejdu 26 i 52...
            if (104 <= i && i < 130) return ((char)('d')).ToString() + ((char)('A' + i - 104)).ToString();//ako e mejdu 26 i 52...
            if (130 <= i && i < 156) return ((char)('e')).ToString() + ((char)('A' + i - 130)).ToString();//ako e mejdu 26 i 52...
            if (156 <= i && i < 182) return ((char)('f')).ToString() + ((char)('A' + i - 156)).ToString();//ako e mejdu 26 i 52...
            if (182 <= i && i < 208) return ((char)('g')).ToString() + ((char)('A' + i - 182)).ToString();//ako e mejdu 26 i 52...
            if (208 <= i && i < 234) return ((char)('h')).ToString() + ((char)('A' + i - 208)).ToString();//ako e mejdu 26 i 52...
            if (234 <= i && i < 256) return ((char)('i')).ToString() + ((char)('A' + i - 234)).ToString();//ako e mejdu 26 i 52...
            else return ("0").ToString();
        }

        // Ot Decimal kam vsiaka druga
        static string DecToAll(ulong d, ulong base256)
        {
            string h = String.Empty;
            for (; d != 0; d /= base256)//dokato ne e nula go delim na bazata
            { h = GetChar(d % base256) + h; }
            return h;//rezultata
        }

        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            if (number == 0) { Console.Write("A"); }
            Console.WriteLine(DecToAll(number, 256));
        }
    }
}