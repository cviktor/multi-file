using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExample
{
    class Program
    {
        public Program()
        {
            
        }

        static void Main(string[] args)
        {
            FileMode mode = FileMode.Open;
            FileStream fs = new FileStream("test.txt", mode, FileAccess.ReadWrite, FileShare.Read);
            try
            {
                while (fs.Position < fs.Length)
                {
                    int b = fs.ReadByte();
                    Console.WriteLine(b + " " + (char) b);
                }

                fs.WriteByte(33);
                fs.WriteByte(33);
                fs.WriteByte(33);
            }
            finally
            {
                fs.Close();
                fs = null;
            }
            

            Console.ReadKey();
        }
    }
}
