using System.Text;
using System.Text.RegularExpressions;

namespace Atbash;

public static class StringExtensions
{
    private static Regex _alfabetoRegex = new Regex("[A-Za-z]");
    private static Dictionary<char, char> _cipherMap = new ()
    {
        ['A'] = 'Z',
        ['B'] = 'Y',
        ['C'] = 'X',
        ['D'] = 'W',
        ['E'] = 'V',
        ['F'] = 'U',
        ['G'] = 'T',
        ['H'] = 'S',
        ['I'] = 'R',
        ['J'] = 'Q',
        ['K'] = 'P',
        ['L'] = 'O',
        ['M'] = 'Ñ',
        ['N'] = 'N',
        ['Ñ'] = 'M',
        ['O'] = 'L',
        ['P'] = 'K',
        ['Q'] = 'J',
        ['R'] = 'I',
        ['S'] = 'H',
        ['T'] = 'G',
        ['U'] = 'F',
        ['V'] = 'E',
        ['W'] = 'D',
        ['X'] = 'C',
        ['Y'] = 'B',
        ['Z'] = 'A',
    };

    public static string AtbashCipher(this string texto)
    {
        StringBuilder builder = new StringBuilder();
        foreach (char c in texto.ToUpper())
        {
            if (_alfabetoRegex.Matches(c.ToString()).Count > 0)
                builder.Append(_cipherMap[c]);
            else
                builder.Append(c);
        }

        return builder.ToString();
    }

}