using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SymCrypto2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string text = File.ReadAllText("OpenText.txt", Encoding.GetEncoding(1251));
            string text_to_file;
            Text OT = new Text(text);
            Text key2 = new Text("не");
            Text key3 = new Text("вам");
            Text key4 = new Text("быть");
            Text key5 = new Text("котом");
            Text key13 = new Text("экстерминатус");
            double IoC_2, IoC_3, IoC_4, IoC_5, IoC_13;
            double IoC_OT = OT.IoC();
            Console.WriteLine("Index of Coincedence : " + IoC_OT);
            Text ET = new Text(text.Length);
            
            
            ET = OT.Encrypt(key2);
            text_to_file = ET.GetString();
            File.WriteAllText("key-2.txt", text_to_file);
            Console.WriteLine("Encrypted Text with keylength 2");
            IoC_2 = ET.IoC_small(2); Console.WriteLine("Index of Coincedence for keylength 2 : " + IoC_2);
            IoC_3 = ET.IoC_small(3); Console.WriteLine("Index of Coincedence for keylength 3 : " + IoC_3);
            IoC_4 = ET.IoC_small(4); Console.WriteLine("Index of Coincedence for keylength 4 : " + IoC_4); 
            IoC_5 = ET.IoC_small(5); Console.WriteLine("Index of Coincedence for keylength 5 : " + IoC_5);
            IoC_13 = ET.IoC_small(13); Console.WriteLine("Index of Coincedence for keylength 13 : " + IoC_13);
            Console.WriteLine(); Console.WriteLine();
            
            ET = OT.Encrypt(key3);
            text_to_file = ET.GetString();
            File.WriteAllText("key-3.txt", text_to_file);
            Console.WriteLine("Encrypted Text with keylength 3");
            IoC_2 = ET.IoC_small(2); Console.WriteLine("Index of Coincedence for keylength 2 : " + IoC_2);
            IoC_3 = ET.IoC_small(3); Console.WriteLine("Index of Coincedence for keylength 3 : " + IoC_3);
            IoC_4 = ET.IoC_small(4); Console.WriteLine("Index of Coincedence for keylength 4 : " + IoC_4);
            IoC_5 = ET.IoC_small(5); Console.WriteLine("Index of Coincedence for keylength 5 : " + IoC_5);
            IoC_13 = ET.IoC_small(13); Console.WriteLine("Index of Coincedence for keylength 13 : " + IoC_13);
            Console.WriteLine(); Console.WriteLine();
            
            ET = OT.Encrypt(key4);
            text_to_file = ET.GetString();
            File.WriteAllText("key-4.txt", text_to_file);
            Console.WriteLine("Encrypted Text with keylength 4");
            IoC_2 = ET.IoC_small(2); Console.WriteLine("Index of Coincedence for keylength 2 : " + IoC_2);
            IoC_3 = ET.IoC_small(3); Console.WriteLine("Index of Coincedence for keylength 3 : " + IoC_3);
            IoC_4 = ET.IoC_small(4); Console.WriteLine("Index of Coincedence for keylength 4 : " + IoC_4);
            IoC_5 = ET.IoC_small(5); Console.WriteLine("Index of Coincedence for keylength 5 : " + IoC_5);
            IoC_13 = ET.IoC_small(13); Console.WriteLine("Index of Coincedence for keylength 13 : " + IoC_13);
            Console.WriteLine(); Console.WriteLine();

            ET = OT.Encrypt(key5);
            text_to_file = ET.GetString();
            File.WriteAllText("key-5.txt", text_to_file);
            Console.WriteLine("Encrypted Text with keylength 5");
            IoC_2 = ET.IoC_small(2); Console.WriteLine("Index of Coincedence for keylength 2 : " + IoC_2);
            IoC_3 = ET.IoC_small(3); Console.WriteLine("Index of Coincedence for keylength 3 : " + IoC_3);
            IoC_4 = ET.IoC_small(4); Console.WriteLine("Index of Coincedence for keylength 4 : " + IoC_4);
            IoC_5 = ET.IoC_small(5); Console.WriteLine("Index of Coincedence for keylength 5 : " + IoC_5);
            IoC_13 = ET.IoC_small(13); Console.WriteLine("Index of Coincedence for keylength 13 : " + IoC_13);
            Console.WriteLine(); Console.WriteLine();

            ET = OT.Encrypt(key13);
            text_to_file = ET.GetString();
            File.WriteAllText("key-13.txt", text_to_file);
            Console.WriteLine("Encrypted Text with keylength 13");
            IoC_2 = ET.IoC_small(2); Console.WriteLine("Index of Coincedence for keylength 2 : " + IoC_2);
            IoC_3 = ET.IoC_small(3); Console.WriteLine("Index of Coincedence for keylength 3 : " + IoC_3);
            IoC_4 = ET.IoC_small(4); Console.WriteLine("Index of Coincedence for keylength 4 : " + IoC_4);
            IoC_5 = ET.IoC_small(5); Console.WriteLine("Index of Coincedence for keylength 5 : " + IoC_5);
            IoC_13 = ET.IoC_small(13); Console.WriteLine("Index of Coincedence for keylength 13 : " + IoC_13);
            Console.WriteLine(); Console.WriteLine(); 
            */

            string E_Text = File.ReadAllText("EncryptedText.txt", Encoding.GetEncoding(1251));
            Text EText = new Text(E_Text);


            string text = File.ReadAllText("OpenText.txt", Encoding.GetEncoding(1251));
            Text OT = new Text(text);
            Text key13 = new Text("экстерминатус");
            Text key2 = new Text("не");
            Text ET = new Text(text.Length);
            ET = OT.Encrypt(key13);

            var t = EText.FindKey();
            Text key = new Text("громнкаведьма");
            var r = EText.Decrypt(key);
            r.Print();

            //var v = EText.Decrypt(t);
            //v.Print();
            
            


            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
