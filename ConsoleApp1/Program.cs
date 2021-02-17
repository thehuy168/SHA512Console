using System;
using System.Security.Cryptography;
using System.Text;



namespace SHA512Console
{

    public static class SHA512Encryptor
    {
       
        public static void Main()
        { 
            string a;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Input String :");
            a = Console.ReadLine();
            Hash(a);
        }

        public static string Hash(string text)
        {


            SHA512 alg = SHA512Managed.Create();
            byte[] result = alg.ComputeHash(Encoding.Default.GetBytes(text));
            string hash = Encoding.UTF8.GetString(result);

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hashing :");
            Console.WriteLine( strBuilder.ToString());
            return strBuilder.ToString();
        }
    }

}
