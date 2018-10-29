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

            using (FileStream fs = new FileStream(@"..\..\test.txt", mode, FileAccess.ReadWrite, FileShare.Read))
            {
                while (fs.Position < fs.Length)
                {
                    int b = fs.ReadByte();
                    Console.WriteLine(b + " " + (char)b);
                }

                fs.WriteByte(33);
                fs.WriteByte(33);
                fs.WriteByte(33);
            }

            using (DisposableExample example = new DisposableExample())
            {
                example.Method();
            }
            
            Console.ReadKey();
        }
    }
}
