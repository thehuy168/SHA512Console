using System;
using System.Security.Cryptography;
using System.Text;



namespace ConsoleApp1
{

    public static class SHAencryptor
    {
       
        public static void Main()
        { 
            string a;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập ký tự ");
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
