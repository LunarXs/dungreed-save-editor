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
                Console.WriteLine("    encryptor.exe <xml_input_path> <encrypted_output_path>");
                return;
            }

            String source = args[0]; // The file to encrypt
            String target = args[1]; // Where to save the result


            String text = File.ReadAllText(source);

            // Encrypting the file
            using (FileStream fileStream = new FileStream(target, FileMode.Create, FileAccess.Write))
          	{
            		using (Rijndael rijndael = Rijndael.Create())
            		{
              			rijndael.Key = Encoding.ASCII.GetBytes("HORAYGAME123DOPE");
              			rijndael.IV = Encoding.ASCII.GetBytes("SUPERDUPER123123");
              			ICryptoTransform transform = rijndael.CreateEncryptor(rijndael.Key, rijndael.IV);
              			using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
              			{
                				using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                			  {
                            // Here we're writing the source file into the cryptoStream
                            streamWriter.Write(text);
                				}
              			}
            		}
          	}

        }

    }
}
