using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace LinkGlutton.Mvc.Utilities.Hashing;

public class Hasher : IHasher
{
    private static readonly IEnumerable<char> _base64Values;

    static Hasher()
    {
        _base64Values = Enumerable.Range('A', 26)
            .Concat(Enumerable.Range('a', 26))
            .Concat(Enumerable.Range('0', 10))
            .Append('-')
            .Append('_')
            .Select(x => (char)x);
    }

    public string Hash(string key)
    {
        SHA256 sha = SHA256.Create();
        int hashLength = 8;

        byte[] hashBytes = sha.ComputeHash(Encoding.Unicode.GetBytes(key));
        string fullHashString = string.Join("", hashBytes.Select(x => Convert.ToString(2).PadLeft(8, '0')));
        StringBuilder hash = new(hashLength);


        for (int i = 0; i < hashLength; i++)
            hash.Append(_base64Values.ElementAt(ConvertToInt(fullHashString, i * 6, 6)));

        return hash.ToString();
    }

    private int ConvertToInt(string values, int start, int length)
    {
        double result = 0;

        for (int i = 0; i < length; i++)
            result += values[start + length - i - 1] * Math.Pow(2, i);
        return (int)result;
    }

}
