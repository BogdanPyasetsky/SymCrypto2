using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymCrypto2
{
   

    class Text
    {
        static int Mod(int a, int b)
        {
            var res = a;
            while (res >= b)
                res -= b;
            return res;            
        }

        static int ModAdd(int a, int b)
        {
            var res = a + b;
            while (res >= 32)
                res -= 32;
            return res;
        }

        private int[] word;

        private int Convert(char a)
        {
            char[] lett = new char[32];
            lett[0] = 'а'; lett[1] = 'б'; lett[2] = 'в'; lett[3] = 'г'; lett[4] = 'д'; lett[5] = 'е'; lett[6] = 'ж'; lett[7] = 'з'; lett[8] = 'и'; lett[9] = 'й'; lett[10] = 'к';
            lett[11] = 'л'; lett[12] = 'м'; lett[13] = 'н'; lett[14] = 'о'; lett[15] = 'п'; lett[16] = 'р'; lett[17] = 'с'; lett[18] = 'т'; lett[19] = 'у'; lett[20] = 'ф'; lett[21] = 'х';
            lett[22] = 'ц'; lett[23] = 'ч'; lett[24] = 'ш'; lett[25] = 'щ'; lett[26] = 'ъ'; lett[27] = 'ы'; lett[28] = 'ь'; lett[29] = 'э'; lett[30] = 'ю'; lett[31] = 'я'; 
            for (int i = 0; i < 32; i++)
                if(a == lett[i])
                    return i;
            return -1;
        }

        private char ReConvert(int k)
        {
            char[] lett = new char[32];
            lett[0] = 'а'; lett[1] = 'б'; lett[2] = 'в'; lett[3] = 'г'; lett[4] = 'д'; lett[5] = 'е'; lett[6] = 'ж'; lett[7] = 'з'; lett[8] = 'и'; lett[9] = 'й'; lett[10] = 'к';
            lett[11] = 'л'; lett[12] = 'м'; lett[13] = 'н'; lett[14] = 'о'; lett[15] = 'п'; lett[16] = 'р'; lett[17] = 'с'; lett[18] = 'т'; lett[19] = 'у'; lett[20] = 'ф'; lett[21] = 'х';
            lett[22] = 'ц'; lett[23] = 'ч'; lett[24] = 'ш'; lett[25] = 'щ'; lett[26] = 'ъ'; lett[27] = 'ы'; lett[28] = 'ь'; lett[29] = 'э'; lett[30] = 'ю'; lett[31] = 'я';
            for (int i = 0; i < 32; i++)
                if (k == i)
                    return lett[i];
            return '?';
        }

        public Text(string a)
        {
            word = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                word[i] = Convert(a[i]);
        }

        public Text(int k)
        {
            word = new int[k];
        }

        public Text Encrypt(Text k)
        {
            Text res = new Text(word.Length);
            for (int i = 0; i < word.Length; i++)
                res.word[i] = ModAdd(word[i], k.word[Mod(i, 2)]);
            return res;
        }

        public void Print()
        {
            char temp;
            for (int i = 0; i < word.Length; i++)
            {
                temp = ReConvert(word[i]);
                //Console.Write(word[i] + "  ");
                //Console.Write(temp + "  ");
                Console.Write(temp + "(" + word[i] + ")" +"  ");
            }
            Console.WriteLine();
        }

        public string GetString()
        {
            string res = "";
            char temp;
            for (int i = 0; i < word.Length; i++)
            {
                temp = ReConvert(word[i]);
                res = res + temp;
            }
            return res;
        }
    }
}
