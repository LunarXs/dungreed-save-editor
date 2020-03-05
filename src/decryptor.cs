//
// Dungreed save decryption and encryption program
// By LunarXs
// Find it on: 

using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace save_decryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checking that the user calls the program correctly
            if(args.Length != 2)
            {
                Console.WriteLine("This programs needs 2 arugments.");
                Console.WriteLine("Correct usage:");
                Console.WriteLine("    decryptor.exe <encrypted_input_path> <xml_output_path>");
                return;
            }

            String source = args[0]; // The file to decrypt
            String target = args[1]; // Where to save the result


            // Decryption of the save file
            using (FileStream fileStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = Encoding.ASCII.GetBytes("HORAYGAME123DOPE");
                    rijndael.IV = Encoding.ASCII.GetBytes("SUPERDUPER123123");
                    ICryptoTransform transform = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV);
                    using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Read))
                    {
                        // At this point the save is decoded, all that's left to
                        // do is to save the result in a file
                        StreamReader reader = new StreamReader(cryptoStream);
                        string msg = reader.ReadToEnd();
                        WriteStringToFile(msg, target);
                    }
                }
            }
        }

        static public void WriteStringToFile(string text, string target)
        {
            using (StreamWriter writer = new StreamWriter(target))
            {
                writer.WriteLine(text);
            }
        }
    }
}
