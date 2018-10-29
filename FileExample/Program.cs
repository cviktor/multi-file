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

            //using (FileStream fs = new FileStream(@"..\..\test.txt", mode, FileAccess.ReadWrite, FileShare.Read))
            //{
            //    while (fs.Position < fs.Length)
            //    {
            //        int b = fs.ReadByte();
            //        Console.WriteLine(b + " " + (char)b);
            //    }

            //    fs.WriteByte(33);
            //    fs.WriteByte(33);
            //    fs.WriteByte(33);
            //}

            //using (DisposableExample example = new DisposableExample())
            //{
            //    example.Method();
            //}

            using (StreamReader sr = new StreamReader(@"..\..\test.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }

            using (StreamWriter sw = new StreamWriter(new FileStream(@"..\..\test.txt", FileMode.Append)))
            {
               sw.Write("StreamWriter voltam");
               sw.WriteLine("StreamWriter voltam2");
            }

            var content = File.ReadAllLines(@"..\..\test.txt");

            //var info = Directory.CreateDirectory("TestFolder");
            DirectoryInfo info = new DirectoryInfo(@"..\..\TestFolder");

            Console.ReadKey();
        }
    }
}
