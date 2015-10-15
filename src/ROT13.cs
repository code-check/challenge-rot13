using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rot13Challenge.src
{
    public class ROT13
    {
        //BEGIN_CHALLENGE
        private char[] LookupTable = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
        private char[] TransformTable = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm".ToCharArray();
        //END_CHALLENGE

        public string Encrypt(string sIn)
        {
            // Write your code below here
            //BEGIN_CHALLENGE
            sIn = new string(sIn
                .Select(x => {
                    if (LookupTable.Contains(x))
                        return TransformTable[Array.IndexOf(LookupTable, x)];
                    return x;
                })
                .ToArray());
            //END_CHALLENGE
            return sIn;
        }
    }
}
