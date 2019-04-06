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
            string text = File.ReadAllText("OpenText.txt", Encoding.GetEncoding(1251));
            string text_to_file;
            Text OT = new Text(text);
            Text key2 = new Text("не");
            Text key3 = new Text("вам");
            Text key4 = new Text("быть");
            Text key5 = new Text("котом");
            Text key13 = new Text("экстерминатус");
            Text ET = new Text(text.Length);
            ET = OT.Encrypt(key2);
            text_to_file = ET.GetString();
            File.WriteAllText("key-2.txt", text_to_file);
            ET = OT.Encrypt(key3);
            text_to_file = ET.GetString();
            File.WriteAllText("key-3.txt", text_to_file);
            ET = OT.Encrypt(key4);
            text_to_file = ET.GetString();
            File.WriteAllText("key-4.txt", text_to_file);
            ET = OT.Encrypt(key5);
            text_to_file = ET.GetString();
            File.WriteAllText("key-5.txt", text_to_file);
            ET = OT.Encrypt(key13);
            text_to_file = ET.GetString();
            File.WriteAllText("key-13.txt", text_to_file);




            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
